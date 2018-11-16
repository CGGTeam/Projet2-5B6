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

namespace Projet2_5B6
{
    public partial class FrmLogin : Form
    {
        private Utilisateur utilisateur = null;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!EstUtilisateurValide()) return;

            Hide();
            Connexion?.Invoke(this, utilisateur);

        }

        private bool EstUtilisateurValide()
        {
            // TODO : Valider la connexion

            // TODO : Créer le nouvel utilisateur 
            //(int noUtilisateur, string nomUtilisateur, int typeUtilisateur)
            utilisateur = new Utilisateur(1, "UtilisateurBidon", 1);
            return true;
        }

        public event EventHandler<Utilisateur> Connexion;

        public void Deconnexion()
        {
            this.Show();
            Console.WriteLine("in deconnexion login");
        }
    }
}
