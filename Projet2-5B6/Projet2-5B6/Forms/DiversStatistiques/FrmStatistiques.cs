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
   public partial class FrmStatistiques : Form
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

         this.reportViewer1.RefreshReport();
         this.reportViewer2.RefreshReport();
         this.reportViewer3.RefreshReport();
      }
   }
}
