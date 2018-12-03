using Projet2_5B6.Models;
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

namespace Projet2_5B6.Forms.ModifPrix
{
    public partial class FrmModifPrix : BaseForm
    {
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();
        public FrmModifPrix()
        {
            InitializeComponent();
        }

        private void FrmModifPrix_Load(object sender, EventArgs e)
        {
            LoadType();
            
        }
        private void LoadType()
        {
            //selectionner tout les types avec leurs prix
            IEnumerable<TypeAbonnementPrix> typeAbonnements = from unType in monDatatContext.TypeAbonnements
                                  join unPrix in monDatatContext.PrixDepenseAbonnements
                                     on unType.No equals unPrix.NoTypeAbonnement
                                  select new TypeAbonnementPrix(unType.No,unType.Description,unPrix.Anne,unPrix.Prix,unPrix.DepenseObligatoire, unPrix.Remarque);

            //selectionner uniquement le prix le plus recent
            var dataSource = typeAbonnements.GroupBy(item => item.No)
                             .SelectMany(grouping => grouping.OrderByDescending(item => item.Annee).Take(1))
                             .OrderBy(item => item.No)
                             .ToList();

            typeAbonnementPrixBindingSource.DataSource = dataSource;

            DisablePrixNonModifiable();
        }
        private void DisablePrixNonModifiable()
        {
            DateTime anneCourante = DateTime.Now;
            bool estToutAJour = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                 DateTime anneDuPrix = (DateTime)row.Cells["anneeDataGridViewTextBoxColumn"].Value;
                 if (anneDuPrix.Year == anneCourante.Year)
                 {
                     foreach (DataGridViewCell cell in row.Cells)
                     {
                         cell.ReadOnly = true;
                     }
                 }
                 else
                 {
                     row.DefaultCellStyle.BackColor = Color.LightBlue;
                     foreach (DataGridViewCell cell in row.Cells)
                     {
                         int columnIndex = cell.ColumnIndex;
                         string columnName = dataGridView1.Columns[columnIndex].Name;

                         if (columnName == "prixDataGridViewTextBoxColumn" 
                            || columnName == "depenseDataGridViewTextBoxColumn"
                            || columnName == "remarqueDataGridViewTextBoxColumn")
                         {
                             cell.ReadOnly = false;
                            estToutAJour = false;

                         }
                         else
                         {
                             cell.ReadOnly = true;
                         }
                     }
                 }                
            }
            btnConfirmer.Enabled = !estToutAJour;
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            DataGridViewRow row = dataGridView1.CurrentRow;
            row.ErrorText = "Le prix doit être dans un fromat décimal";
            e.Cancel = true;
        }
    
        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            btnConfirmer.Enabled = true;

            DataGridViewCell cellPrix = dataGridView1[3, e.RowIndex];
            DataGridViewCell cellDepense = dataGridView1[4, e.RowIndex];
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string msgErreur = "";
            decimal prix;
            decimal depense;

            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                if (!decimal.TryParse(cellPrix.Value.ToString(), out prix))
                {
                    msgErreur += "Le prix doit être dans un fromat décimal \n";
                }
                else if (prix < 0 || prix > 50000)
                {
                    msgErreur += "Le prix doit être entre 0 et 50 000 \n";
                }

                if (!decimal.TryParse(cellDepense.Value.ToString(), out depense))
                {
                    msgErreur += "Les depenses minimales doivent être dans un fromat décimal \n";
                }
                else if (depense < 0 || depense > 50000)
                {
                    msgErreur += "Les depenses minimales doivent être entre 0 et 50 000 \n";
                }
                row.ErrorText = msgErreur;
            }
            btnConfirmer.Enabled = !ContientErreur();
        }
        private bool ContientErreur()
        {
            bool aUneErreur = false;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
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
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            DateTime anneCourante = DateTime.Now;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var prixAbonnement = (TypeAbonnementPrix)row.DataBoundItem;
                if (prixAbonnement.Annee.Year != anneCourante.Year)
                {
                    PrixDepenseAbonnement prix = new PrixDepenseAbonnement
                    {
                        NoTypeAbonnement = prixAbonnement.No,
                        Anne = anneCourante,
                        DepenseObligatoire = prixAbonnement.Depense,
                        Prix = prixAbonnement.Prix,
                        Remarque = prixAbonnement.Remarque
                    };
                    monDatatContext.PrixDepenseAbonnements.InsertOnSubmit(prix);
                }
            }
            Enregistrer();
        }
        public void Enregistrer()
        {
            typeAbonnementPrixBindingSource.EndEdit();

            using (var transaction = new TransactionScope())
            {
                try
                {
                    monDatatContext.SubmitChanges();
                    transaction.Complete();
                }
                catch (ChangeConflictException)
                {
                    monDatatContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    lblErrorProvider.Text = "Une erreure est survenue : " + ex.Message;
                }
            }
            LoadType();
        }
    }
}
