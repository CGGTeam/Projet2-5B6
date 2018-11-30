using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.GestionReabonnement
{
   public partial class FrmReabonnement : Form
   {
      DataClasses1DataContext data = new DataClasses1DataContext();

      public FrmReabonnement()
      {
         InitializeComponent();
      }

      private void FrmReabonnement_Load(object sender, EventArgs e)
      {
         idEtNomCompletAboBindingSource.DataSource = from abonne in data.Abonnements
                                                     let dateExpiration = abonne.DateAbonnement.AddYears(1)
                                                     where DateTime.Now > dateExpiration
                                                     select new
                                                     {
                                                        id = abonne.Id,
                                                        nomComplet = abonne.Prenom + " " + abonne.Nom
                                                     };

         gbAbonne.Visible = false;
      }

      private void idEtNomCompletAboDataGridView_SelectionChanged(object sender, EventArgs e)
      {
         if (idEtNomCompletAboDataGridView.SelectedRows.Count == 1)
         {
            gbAbonne.Visible = true;

            string id = (string)idEtNomCompletAboDataGridView.CurrentRow.Cells[0].Value;
            string nomComplet = (string)idEtNomCompletAboDataGridView.CurrentRow.Cells[1].Value;

            lblNomAbo.Text = nomComplet;

         }
      }

      private void btnRenouveler_Click(object sender, EventArgs e)
      {
         if (idEtNomCompletAboDataGridView.SelectedRows.Count == 1)
         {
            string id = (string)idEtNomCompletAboDataGridView.CurrentRow.Cells[0].Value;
            string nomComplet = (string)idEtNomCompletAboDataGridView.CurrentRow.Cells[1].Value;



         }
         else
         {
            MessageBox.Show("Vous devez sélectionner un abonné avant de continuer !", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }
   }
}
