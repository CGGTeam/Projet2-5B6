using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.MAJAbonnes
{
    public partial class FrmMAJAbonnes : BaseForm
    {
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();
        public FrmMAJAbonnes()
        {
            InitializeComponent();
        }

        private void MAJAbonnes_Load(object sender, EventArgs e)
        {
            LoadProvince();
            LoadTypeAbonnement();
            LoadSexes();
            LoadAbonnements();

            LoadDependants();
        }
        private void LoadSexes()
        {
            Dictionary<char, string> dictionnarySexes = new Dictionary<char, string>
            {
              {'H', "Homme"},
              {'F', "Femme"},
            };
            dataGridViewSexes.DataSource = new BindingSource(dictionnarySexes, null);
            dataGridViewSexes.DisplayMember = "Key";
            dataGridViewSexes.ValueMember = "Key";

            dataGridViewDependantsSexes.DataSource = new BindingSource(dictionnarySexes, null);
            dataGridViewDependantsSexes.DisplayMember = "Key";
            dataGridViewDependantsSexes.ValueMember = "Key";
        }
        private void LoadProvince()
        {
            provinceBindingSource.DataSource = from uneProvince in monDatatContext.Provinces
                                               select uneProvince;
        }
        private void LoadTypeAbonnement()
        {
            typeAbonnementBindingSource.DataSource = from unType in monDatatContext.TypeAbonnements
                                               select unType;
        }
        private void LoadAbonnements()
        {
            abonnementBindingSource.DataSource = from unAbonnement in monDatatContext.Abonnements
                                               select unAbonnement;
        }
        private void LoadDependants()
        {
            Abonnement currentAbonnement = (Abonnement)abonnementBindingSource.Current;
            var dependants = from unDependant in monDatatContext.Dependants
                                                where unDependant.IdAbonnement == currentAbonnement.Id
                                                select unDependant;
            dependantBindingSource.DataSource = dependants;

        }
        private void abonnementBindingSource_CurrentChanged(object sender, EventArgs e)
        {   
            if (abonnementBindingSource.Current != null)
            {
                LoadDependants();
                dependantDataGridView.Visible = true;
            }
            else
            {
                dependantDataGridView.Visible = false;
            }
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }
        public void Enregistrer()
        {
            abonnementBindingSource.EndEdit();
            dependantBindingSource.EndEdit();

            using (var transaction = new TransactionScope())
            {
                try
                {
                    monDatatContext.SubmitChanges();
                    transaction.Complete();
                    lblErrorProvide.Text = "Les modifications ont été sauvegarder";
                }
                catch (ChangeConflictException)
                {
                    monDatatContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    lblErrorProvide.Text = "Une erreure est survenue : " + ex.Message;
                }
            }
            MAJAbonnes_Load(null, null);
        }
        private bool ContientErreur()
        {
            bool aUneErreur = false;
            foreach (DataGridViewRow row in this.abonnementDataGridView.Rows)
            {
                if (row.ErrorText.Length > 0)
                {
                    aUneErreur = true;
                    break;
                }
                if (aUneErreur)
                    break;
            }
            foreach (DataGridViewRow row in this.dependantDataGridView.Rows)
            {
                if (row.ErrorText.Length > 0)
                {
                    aUneErreur = true;
                    break;
                }
                if (aUneErreur)
                    break;
            }

            return aUneErreur;
        }
        private void abonnementDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridViewRow row = abonnementDataGridView.CurrentRow;
            row.ErrorText = "Une erreur de format est présente";
            e.Cancel = true;

            btnSauvegarder.Enabled = !ContientErreur();
        }

        private void dependantDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridViewRow row = dependantDataGridView.CurrentRow;
            row.ErrorText = "Une erreur de format est présente";
            e.Cancel = true;

            btnSauvegarder.Enabled = !ContientErreur();
        }

        private void abonnementDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            btnSauvegarder.Enabled = true;
            string msgErreur = "";
            DataGridViewRow row = abonnementDataGridView.Rows[e.RowIndex];

            var Prenom = abonnementDataGridView[3, e.RowIndex].Value;
            var NoCivique = abonnementDataGridView[6, e.RowIndex].Value;
            var Rue = abonnementDataGridView[7, e.RowIndex].Value;
            var Ville = abonnementDataGridView[8, e.RowIndex].Value;
            var CodePostal = abonnementDataGridView[10, e.RowIndex].Value;
            var Telephone = abonnementDataGridView[11, e.RowIndex].Value;
            var Cellulaire = abonnementDataGridView[12, e.RowIndex].Value;
            var Courriel = abonnementDataGridView[13, e.RowIndex].Value;

            if (Prenom == null || NoCivique == null || Rue == null || Ville == null ||
                CodePostal == null || Telephone == null ||  Courriel == null)
            {
                msgErreur += "Il y a des champs vide" + Environment.NewLine;
            }
            else
            {
                if (Telephone.ToString().Length != 10 && Telephone.ToString()!="0")
                {
                    msgErreur += "Le numéroe de téléphone doit être 10 de long" + Environment.NewLine;
                }
                if(Cellulaire != null)
                {
                    if (Cellulaire.ToString().Length != 10)
                    {
                        msgErreur += "Le numéroe de cellulaire doit être 10 de long" + Environment.NewLine;
                    }
                }
                if(!(new Regex(@"^([ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]){1}$").Match(CodePostal.ToString())).Success)
                {
                    msgErreur += "Le code postal n'est pas valide" + Environment.NewLine;
                }
                
            }

            row.ErrorText = msgErreur;
            btnSauvegarder.Enabled = !ContientErreur();
        }
        private void dependantDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (abonnementBindingSource.Current != null)
            {
                btnSauvegarder.Enabled = true;
                string msgErreur = "";
                DataGridViewRow row = dependantDataGridView.Rows[e.RowIndex];

                var Nom = dependantDataGridView[2, e.RowIndex].Value;
                var Prenom = dependantDataGridView[3, e.RowIndex].Value;

                if (Prenom == null || Nom == null)
                {
                    msgErreur += "Il y a des champs vide" + Environment.NewLine;
                }

                row.ErrorText = msgErreur;
                btnSauvegarder.Enabled = !ContientErreur();
            }
        }
    }
}
