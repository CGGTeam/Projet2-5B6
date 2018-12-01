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

         this.reportViewer1.RefreshReport();
         this.reportViewer2.RefreshReport();
         this.reportViewer3.RefreshReport();
      }
   }
}
