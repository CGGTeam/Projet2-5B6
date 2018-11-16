using Projet2_5B6.Forms;
using Projet2_5B6.Models;
using System;
using System.Windows.Forms;

namespace Projet2_5B6
{

    class GestionForms
    {
        public static Utilisateur utilisateurConnecte;
        private readonly FrmLogin frmConnexion;

        public GestionForms()
        {
            frmConnexion = new FrmLogin();
        }

        public void Demarrer()
        {
            frmConnexion.Connexion += GestionConnexion;

            frmConnexion.ShowDialog();
        }

        private void GestionConnexion(object sender, Utilisateur util)
        {
            utilisateurConnecte = util;
            BaseForm formUtilisatteur = new BaseForm();
            formUtilisatteur.Deconnexion += GestionDeconnexion;

            new FrmAcceuil().ShowDialog();
        }

        private void GestionDeconnexion(object sender, EventArgs e)
        {
            this.frmConnexion.Deconnexion();
        }
    }
}
