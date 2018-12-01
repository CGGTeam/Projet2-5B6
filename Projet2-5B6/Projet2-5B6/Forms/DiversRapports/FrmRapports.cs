using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.DiversRapports
{
   public partial class FrmRapports : Form
   {
      DataClasses1DataContext data = new DataClasses1DataContext();

      public FrmRapports()
      {
         InitializeComponent();
      }

      private void FrmRapports_Load(object sender, EventArgs e)
      {

         // binding source 2 premiers rapports
         this.ObjetDepensesParAbonnementBindingSource.DataSource = from employe in data.Employes
                                                                   join service in data.Services on employe.No equals service.NoEmple
                                                                   join depense in data.Depenses on service.No equals depense.NoService
                                                                   join abonnement in data.Abonnements on depense.IdAbonnement equals abonnement.Id
                                                                   select new
                                                                   {
                                                                      nomCompletAbonne = abonnement.Prenom + " " + abonnement.Nom,
                                                                      montant = depense.Montant,
                                                                      dateDepense = depense.DateDepense,
                                                                      typeService = service.TypeService,
                                                                      nomCompletEmploye = employe.Prenom + " " + employe.Nom
                                                                   };

         // dépenses par année
         this.ObjetDepensesParAnneeBindingSource.DataSource = from employe in data.Employes
                                                              join service in data.Services on employe.No equals service.NoEmple
                                                              join depense in data.Depenses on service.No equals depense.NoService
                                                              join abonnement in data.Abonnements on depense.IdAbonnement equals abonnement.Id
                                                              select new
                                                              {
                                                                 annee = depense.DateDepense.Year,
                                                                 nomCompletAbonne = abonnement.Prenom + " " + abonnement.Nom,
                                                                 montant = depense.Montant,
                                                                 dateDepense = depense.DateDepense,
                                                                 typeService = service.TypeService,
                                                                 nomCompletEmploye = employe.Prenom + " " + employe.Nom
                                                              };

         // parties jouées par terrain et parties jouées par abonnement
         this.ObjetPartiesJoueesParTerrainBindingSource.DataSource = from partie in data.PartiesJouees
                                                                     join unTerrain in data.Terrains on partie.NoTerrain equals unTerrain.No
                                                                     join abonne in data.Abonnements on partie.IdAbbonement equals abonne.Id
                                                                     select new
                                                                     {
                                                                        nomTerrain = unTerrain.Nom,
                                                                        datePartie = partie.DatePartie,
                                                                        nomCompletAbonne = abonne.Prenom + " " + abonne.Nom,
                                                                        pointage = partie.Pointage
                                                                     };

         // parties jouées par année
         this.ObjetPartiesJoueesParAnneeBindingSource.DataSource = from partie in data.PartiesJouees
                                                                     join unTerrain in data.Terrains on partie.NoTerrain equals unTerrain.No
                                                                     join abonne in data.Abonnements on partie.IdAbbonement equals abonne.Id
                                                                     select new
                                                                     {
                                                                        annee = partie.DatePartie.Year,
                                                                        nomTerrain = unTerrain.Nom,
                                                                        datePartie = partie.DatePartie,
                                                                        nomCompletAbonne = abonne.Prenom + " " + abonne.Nom,
                                                                        pointage = partie.Pointage
                                                                     };

         this.reportViewer1.RefreshReport();
         this.reportViewer2.RefreshReport();
         this.reportViewer3.RefreshReport();
         this.reportViewer4.RefreshReport();
         this.reportViewer5.RefreshReport();
         this.reportViewer6.RefreshReport();
      }
   }
}
