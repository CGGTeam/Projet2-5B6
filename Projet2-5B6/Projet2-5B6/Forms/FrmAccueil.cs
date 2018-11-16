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

namespace Projet2_5B6.Forms
{
    public partial class FrmAccueil : BaseForm
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void FrmAcceuil_Load(object sender, EventArgs e)
        {
            String strAcceuil = "";
            strAcceuil = "Bonjour " + GestionForms.utilisateurConnecte.NomUtilisateur + "!";
            strAcceuil += "\n\nVous pouvez sélectionner un \nitem dans le menu supérieur! ";
            strAcceuil += "\n\nBonne journée!";
            lblAcceuil.Text = strAcceuil;
        }
    }
}
