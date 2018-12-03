using Projet2_5B6.ObjetsLINQ;
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

namespace Projet2_5B6.Forms.EnregistrementPartie
{
    public partial class FrmInscriptionPartie : BaseForm 
    {
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();
        public FrmInscriptionPartie()
        {
            InitializeComponent();
        }

        private void FrmInscriptionPartie_Load(object sender, EventArgs e)
        {
            LoadAbonnement();
            LoadTerrains();
        }
        private void LoadAbonnement()
        {
            idEtNomCompletAboBindingSource.DataSource = from abonne in monDatatContext.Abonnements
                                                        let dateValide = abonne.DateAbonnement.AddYears(1)
                                                        where DateTime.Now < dateValide
                                                        select new
                                                        {
                                                            id = abonne.Id,
                                                            nomComplet = abonne.Prenom + " " + abonne.Nom
                                                        };
        }
        private void LoadTerrains()
        {
            terrainBindingSource.DataSource = from terrain in monDatatContext.Terrains
                                              select terrain;
        }
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            int selectedrowindex = idEtNomCompletAboDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = idEtNomCompletAboDataGridView.Rows[selectedrowindex];
            string id = Convert.ToString(selectedRow.Cells["dataGridViewTbId"].Value);

            Terrain terrain = this.lstTerrains.SelectedItem as Terrain;

            DateTime date = DateTime.Now;
            PartiesJouee partie = new PartiesJouee
            {
                IdAbbonement = id,
                NoTerrain = terrain.No,
                DatePartie = date,
                Pointage = Convert.ToInt32(numPoint.Value),
                Remarque = tbPartie.Text == "" ? null : tbPartie.Text
            };
            monDatatContext.PartiesJouees.InsertOnSubmit(partie);
            Enregistrer();
        }
        public void Enregistrer()
        {

            using (var transaction = new TransactionScope())
            {
                try
                {
                    monDatatContext.SubmitChanges();
                    transaction.Complete();
                    lblErrorProvider.Text = "Enregistrement éffectué avec succès";
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
        }
    }
}
