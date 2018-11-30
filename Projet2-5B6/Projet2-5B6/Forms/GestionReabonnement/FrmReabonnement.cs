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
         Dictionary<string, DateTime> abonnementsDatePlusRecente = new Dictionary<string, DateTime>();

         var abonnementsExpires = from abonne in data.Abonnements
                                    let dateExpiration = abonne.DateAbonnement.AddYears(1)
                                    where DateTime.Now > dateExpiration
                                       select new
                                       {
                                          id = abonne.Id,
                                          dateAbonnement = abonne.DateAbonnement
                                       };

         var reabonnements = from reabonne in data.Reabonnements
                             select new
                              {
                                 id = reabonne.IdAbbonement,
                                 dateAbonnement = reabonne.DateRenouvellement
                              };

         // ajouter les abonnements à la liste
         foreach (var abo in abonnementsExpires)
         {
            abonnementsDatePlusRecente.Add(abo.id, abo.dateAbonnement);
         }

         // vérifier s'il y a eu des réabonnements
         foreach (var abo in reabonnements)
         {
            DateTime dateAncienneEntree = DateTime.Now;
            if (abonnementsDatePlusRecente.TryGetValue(abo.id.ToString(), out dateAncienneEntree))
            {
               if (dateAncienneEntree < abo.dateAbonnement)
               {
                  abonnementsDatePlusRecente[abo.id] = abo.dateAbonnement;
               }
            }
            else
            {
               abonnementsDatePlusRecente.Add(abo.id, abo.dateAbonnement);
            }
         }
         
         // ajouter les données au grid view
         foreach (KeyValuePair<string, DateTime> entry in abonnementsDatePlusRecente)
         {
            System.Diagnostics.Debug.WriteLine("ID : " + entry.Key + " | " + "Date début : " + entry.Value.ToString());
            var ligne = from abonne in data.Abonnements
                        where abonne.Id == entry.Key && DateTime.Now > entry.Value.AddYears(1)
                        select new
                        {
                           id = abonne.Id,
                           nomComplet = abonne.Prenom + " " + abonne.Nom
                        };

            foreach (var abo in ligne)
            {
               string[] row = new string[] { abo.id, abo.nomComplet };
               idEtNomCompletAboDataGridView.Rows.Add(row);
            }
               

         }
   



         gbAbonne.Visible = false;
         idEtNomCompletAboDataGridView.ClearSelection();
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
