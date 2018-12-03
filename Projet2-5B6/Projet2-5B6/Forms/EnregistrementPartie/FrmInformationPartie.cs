using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.EnregistrementPartie
{
    public partial class FrmInformationPartie : Form
    {
        PartiesJouee partie;
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();
        public FrmInformationPartie(PartiesJouee partie)
        {
            this.partie = partie;

            InitializeComponent();
        }

        private void FrmInformationPartie_Load(object sender, EventArgs e)
        {
            LoadLables();
        }
        private void LoadLables()
        {
            string nomAbonnement = GetNomAbonnement();
            string nomTerrrain = GetNomTerrain();

            lblNom.Text = nomAbonnement;
            lblDate.Text = partie.DatePartie.ToString("dd/MM/yyyy");
            lblPoint.Text = partie.Pointage.ToString();
            lblRemarque.Text = partie.Remarque;
            lblTerrain.Text = nomTerrrain;
 
        }
        private string GetNomAbonnement()
        {
            var nomsAbonnements = from e in monDatatContext.Abonnements
                                  where e.Id == partie.IdAbbonement
                                  select e.Nom + ", " + e.Prenom;
            return nomsAbonnements.First();
        }
        private string GetNomTerrain()
        {
            var nomTerrains = from e in monDatatContext.Terrains
                              where e.No == partie.NoTerrain
                              select e.Nom;
            return nomTerrains.First();
        }
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
