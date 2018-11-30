using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
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

            if(abonnementBindingSource.Current != null)
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
            dependantBindingSource.DataSource = from unDependant in monDatatContext.Dependants
                                                where unDependant.IdAbonnement == currentAbonnement.Id
                                                select unDependant;
        }
        private void abonnementBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (abonnementBindingSource.Current != null)
                LoadDependants();
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

        private void abonnementDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Erreur \n"+e, "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
