using Projet2_5B6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.EnregistrerDepense
{
    public partial class FrmInformationDepense : Form
    {
        Depense depense;
        DataClasses1DataContext monDatatContext;
        public FrmInformationDepense(DataClasses1DataContext monDatatContext, Depense depense)
        {
            this.depense = depense;
            this.monDatatContext = monDatatContext;

            InitializeComponent();
        }

        private void FrmInformationDepense_Load(object sender, EventArgs e)
        {
            LoadLables();
        }
        private void LoadLables()
        {
            string nomAbonnement = GetNomAbonnement();
            Service service = GetService();
            string nomEmploye = GetNomEmploye(service);

            decimal total = GetTotalDepense();
            decimal minimum = GetDepenseMinimal(GetTypeAbonnement());
            decimal reste = minimum - total;

            lblNom.Text = nomAbonnement;
            lblDate.Text = depense.DateDepense.ToString("dd/MM/yyyy");
            lblMontant.Text = depense.Montant.ToString("C2");
            lblType.Text = service.TypeService;
            lblEmploye.Text = nomEmploye;

            lblMontantTotal.Text = total.ToString("C2");
            lblMontantRestant.Text = reste.ToString("C2");


        }
        private int GetTypeAbonnement()
        {
            var noTypeAbonnements = from e in monDatatContext.Abonnements
                               where e.Id == depense.IdAbonnement
                               select e.NoTypeAbonnement;
            return noTypeAbonnements.First();
        }
        private string GetNomEmploye(Service service)
        {
            var nomsEmployes = from e in monDatatContext.Employes
                               where e.No == service.NoEmple
                               select e.Nom + ", " + e.Prenom;
            return nomsEmployes.First();
        }
        private string GetNomAbonnement()
        {
            var nomsAbonnements = from e in monDatatContext.Abonnements
                               where e.Id == depense.IdAbonnement
                               select e.Nom + ", " + e.Prenom;
            return nomsAbonnements.First();
        }
        private Abonnement GetAbonnement()
        {
            string id = depense.IdAbonnement;
            var abonnements = from s in monDatatContext.Abonnements
                           where s.Id == id
                           orderby s.Id descending
                           select s;

            List<Abonnement> list = abonnements.ToList();
            Abonnement ab =null ;
            if (list.Any())
                ab = list.First();

            return ab;
        }
        private Service GetService()
        {
            var services = from s in monDatatContext.Services
                           where s.No == depense.NoService
                           select s;
            Service service = services.First();
            return service;
        }
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private decimal GetTotalDepense()
        {
            var montants = from d in monDatatContext.Depenses
                               where d.IdAbonnement == depense.IdAbonnement
                               select d.Montant;

            decimal total = montants.Sum();
            return total;
        }
        private decimal GetDepenseMinimal(int noType)
        {
            var listes = from d in monDatatContext.PrixDepenseAbonnements
                               where d.NoTypeAbonnement == noType
                                orderby d.Anne descending
                               select d.DepenseObligatoire;

            return listes.First();
        }
    }
}
