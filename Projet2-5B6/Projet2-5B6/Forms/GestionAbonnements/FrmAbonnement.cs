using Projet2_5B6.Models;
using Projet2_5B6.ObjetsLINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.GestionAbonnements
{
   public partial class FrmAbonnement : Form
   {
      private DataClasses1DataContext data = new DataClasses1DataContext();

      public FrmAbonnement()
      {
         InitializeComponent();
      }

      private void FrmAbonnement_Load(object sender, EventArgs e)
      {
         

         /*infosAbonnementsDetaillesBindingSource.DataSource = from typeAbonnement in data.TypeAbonnements
                                                             join prixDepenseAbonnements in data.PrixDepenseAbonnements
                                                             on typeAbonnement equals prixDepenseAbonnements.TypeAbonnement
                                                             select new
                                                             {
                                                                noTypeAbonnement = typeAbonnement.No,
                                                                descriptionAbonnement = typeAbonnement.Description,
                                                                prix = prixDepenseAbonnements.Prix,
                                                                depenseObligatoire = prixDepenseAbonnements.DepenseObligatoire
                                                             };*/

         //selectionner tout les types avec leurs prix
         IEnumerable<InfosAbonnementsDetailles> typeAbonnements = from unType in data.TypeAbonnements
                                                           join unPrix in data.PrixDepenseAbonnements
                                                              on unType.No equals unPrix.NoTypeAbonnement
                                                           select new InfosAbonnementsDetailles(unType.No, unType.Description, unPrix.Prix, unPrix.DepenseObligatoire, unPrix.Anne);

         //selectionner uniquement le prix le plus recent
         var dataSource = typeAbonnements.GroupBy(item => item.noTypeAbonnement)
                          .SelectMany(grouping => grouping.OrderByDescending(item => item.date).Take(1))
                          .OrderBy(item => item.noTypeAbonnement)
                          .ToList();

         infosAbonnementsDetaillesBindingSource.DataSource = dataSource;
      }

      private void btnSelection_Click(object sender, EventArgs e)
      {
         if (infosAbonnementsDetaillesDataGridView.SelectedRows.Count == 1)
         {
            int noTypeAbonnement = (int)infosAbonnementsDetaillesDataGridView.CurrentRow.Cells[0].Value;

            // cération du formulaire de saisie des donnéees
            this.Hide();
            FrmFormulaireAbonnement frmFormulaire = new FrmFormulaireAbonnement();
            frmFormulaire.noTypeAbonnement = noTypeAbonnement;
            frmFormulaire.ShowDialog();
            this.Show();

         }
         else
         {
            MessageBox.Show("Vous devez sélectionner un abonnement avant de continuer !", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }
   }
}
