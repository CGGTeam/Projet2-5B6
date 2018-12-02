using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

         this.reportViewer1.RefreshReport();
      }
   }
}
