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
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!EstUtilisateurValide()) return;

            //Ouvre le form d'acceuil
            Hide();
            Connexion?.Invoke(this, utilisateur);

        }

        private bool EstUtilisateurValide()
        {
            int identifiant;
            if (!Int32.TryParse(tbIdentifiant.Text, out identifiant))
            {
                errorProvider1.SetError(btnConnexion, "Mauvais identifiant ou mot de passe");
                return false;
            }
            string password = tbPassword.Text;

            var employe = from unEmploye in monDatatContext.Employes
                          where unEmploye.No == identifiant
                          && unEmploye.MotDePasse == password
                          select unEmploye;

            //regrade su la requete linq a retourné un employe
            if (!employe.Any())
            {
                errorProvider1.SetError(btnConnexion,"Mauvais identifiant ou mot de passe");
                return false;
            }

            //créer l'utilisateur
            utilisateur = new Utilisateur(employe.First());
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
