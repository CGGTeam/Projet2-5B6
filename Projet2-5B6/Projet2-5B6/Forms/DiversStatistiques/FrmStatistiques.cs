using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.DiversStatistiques
{
   public partial class FrmStatistiques : BaseForm
   {
      DataClasses1DataContext data = new DataClasses1DataContext();

      public FrmStatistiques()
      {
         InitializeComponent();
      }

      private void FrmStatistiques_Load(object sender, EventArgs e)
      {

         // Abonnements par année et par type d’abonnement
         this.ObjetAbonnementsParAnneeEtParTypeAbonnementBindingSource.DataSource = from abonne in data.Abonnements
                                                                                    join typeabo in data.TypeAbonnements on abonne.NoTypeAbonnement equals typeabo.No
                                                                                    select new
                                                                                    {
                                                                                       annee = abonne.DateAbonnement.Year,
                                                                                       typeAbonnement = typeabo.Description,
                                                                                       id = abonne.Id,
                                                                                       nom = abonne.Nom,
                                                                                       prenom = abonne.Prenom
                                                                                    };

         // Abonnements par mois de l’année courante et par type d’abonnement
         this.ObjetAbonnementsMoiAnneeCouranteBindingSource.DataSource = from abonne in data.Abonnements
                                                                         join typeabo in data.TypeAbonnements on abonne.NoTypeAbonnement equals typeabo.No
                                                                         where abonne.DateAbonnement.Year == DateTime.Now.Year
                                                                         select new
                                                                         {
                                                                            mois = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(abonne.DateAbonnement.Month),
                                                                            typeAbonnement = typeabo.Description,
                                                                            id = abonne.Id,
                                                                            nom = abonne.Nom,
                                                                            prenom = abonne.Prenom
                                                                         };

         // parties jouées par année et par terrain
         this.ObjetPartiesJoueesParAnneeBindingSource.DataSource =  from partie in data.PartiesJouees
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

         // Parties jouées par mois de l’année courante et par terrain
         this.ObjetPartiesJoueesParMoisEtTerrainBindingSource.DataSource = from partie in data.PartiesJouees
                                                                           join unTerrain in data.Terrains on partie.NoTerrain equals unTerrain.No
                                                                           join abonne in data.Abonnements on partie.IdAbbonement equals abonne.Id
                                                                           where abonne.DateAbonnement.Year == DateTime.Now.Year
                                                                           select new
                                                                           {
                                                                              mois = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(partie.DatePartie.Month),
                                                                              nomTerrain = unTerrain.Nom,
                                                                              datePartie = partie.DatePartie,
                                                                              nomCompletAbonne = abonne.Prenom + " " + abonne.Nom,
                                                                              pointage = partie.Pointage
                                                                           };

         // Dépenses par année et par abonnement
         this.ObjetDepensesParAnneeEtAbonnementBindingSource.DataSource = from employe in data.Employes
                                                                          join service in data.Services on employe.No equals service.NoEmple
                                                                          join depense in data.Depenses on service.No equals depense.NoService
                                                                          join abonnement in data.Abonnements on depense.IdAbonnement equals abonnement.Id
                                                                          select new
                                                                          {
                                                                             annee = depense.DateDepense.Year,
                                                                             idAbonne = abonnement.Id,
                                                                             nomCompletAbonne = abonnement.Prenom + " " + abonnement.Nom,
                                                                             montant = depense.Montant,
                                                                             dateDepense = depense.DateDepense,
                                                                             typeService = service.TypeService,
                                                                             nomCompletEmploye = employe.Prenom + " " + employe.Nom
                                                                          };

         // Dépenses par mois de l’année courante et par abonnement
         this.ObjetDepensesParMoisEtAbonnementBindingSource.DataSource = from employe in data.Employes
                                                                         join service in data.Services on employe.No equals service.NoEmple
                                                                         join depense in data.Depenses on service.No equals depense.NoService
                                                                         join abonnement in data.Abonnements on depense.IdAbonnement equals abonnement.Id
                                                                         where abonnement.DateAbonnement.Year == DateTime.Now.Year
                                                                         select new
                                                                         {
                                                                            mois = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(depense.DateDepense.Month),
                                                                            idAbonne = abonnement.Id,
                                                                            nomCompletAbonne = abonnement.Prenom + " " + abonnement.Nom,
                                                                            montant = depense.Montant,
                                                                            dateDepense = depense.DateDepense,
                                                                            typeService = service.TypeService,
                                                                            nomCompletEmploye = employe.Prenom + " " + employe.Nom
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
