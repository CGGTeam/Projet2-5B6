using Projet2_5B6.Forms;
using Projet2_5B6.Forms.DiversRapports;
using Projet2_5B6.Forms.DiversStatistiques;
using Projet2_5B6.Forms.EnregistrementPartie;
using Projet2_5B6.Forms.GestionAbonnements;
using Projet2_5B6.Forms.GestionReabonnement;
using Projet2_5B6.Forms.MAJAbonnes;
using Projet2_5B6.Forms.ModifPrix;
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
    public partial class BaseForm : Form
    {
        public static bool aAccepte = false;

        public BaseForm()
        {
            InitializeComponent();
            aAccepte = false;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirmationClosing(null, null);
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            demandeDeconnexion();

        }

        private void confirmationClosing(object sender, FormClosingEventArgs e)
        {
            if (aAccepte) return;

            DialogResult result = MessageBox.Show("Vous êtes sur le point de fermer l'aplication! \n Êtes-vous sûr de vouloir quitter?", "Fermeture de l'aplication", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                aAccepte = true;
                if (e == null) Application.Exit(); 
            }
            else
            {
                if(e!=null) e.Cancel = true;
            }
        }
        private void demandeDeconnexion()
        {
            DialogResult result = MessageBox.Show("Vous êtes sur le point de vous déconnecter! \n Êtes-vous sûr de vouloir fermer votre session?", "Fermeture de la session", MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                aAccepte = true;
                FindForm()?.Hide();
                Deconnexion?.Invoke(this, null);

                GestionForms gf = new GestionForms();
                gf.Demarrer();
            }
        }
        public event EventHandler Deconnexion;

        private void gestionDesEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmGestionEmployes().ShowDialog();
        }

        private void miseÀJourDesAbonnésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmMAJAbonnes().ShowDialog();
        }

        private void modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmModifPrix().ShowDialog();
        }
        private void gestionDesAbonnementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmAbonnement().ShowDialog();
        }
        private void gestionDesRéabonnementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FindForm()?.Hide();
           new FrmReabonnement().ShowDialog();
        }
        private void inscriptionDunePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm()?.Hide();
            new FrmInscriptionPartie().ShowDialog();
        }
      private void visualiserLesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FindForm()?.Hide();
         new FrmRapports().ShowDialog();
      }
      private void visualiserLesStatistiquesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FindForm()?.Hide();
         new FrmStatistiques().ShowDialog();
      }
      private void BaseForm_Load(object sender, EventArgs e)
        {                     
            int[] permissionGestionUtilisateurs = { 1, 2 };
            int[] permissionGestionAbonnements = { 1, 3, 4 };
            int[] permissionMAJAbonnement = { 1, 3, 4 };
            int[] permissionModifPrix = { 1, 2, 3};
            int[] permissionInscriptionPartie = { 1, 3, 4, 5, 6 };
            /**
             * Permet d'afficher uniquement les menu que l'utilisateur à le droit de consulter selon son type d'employé 
             * 1=Administrateur , 2=Direction , 3=Propriétaire d’un club , 4=Employé d’un club, 5=Employé Pro-Shop , 6=Employé d’un restaurant , 7=Professeur de golf
             */
            foreach (ToolStripItem item in menuOption.DropDownItems)
            {
                if (item == gestionDesEmployésToolStripMenuItem)
                {
                    if (!permissionGestionUtilisateurs.Contains(GestionForms.utilisateurConnecte.noType))
                        item.Visible = false;
                }
                else if (item == gestionDesAbonnementsToolStripMenuItem)
                {
                    if (!permissionGestionAbonnements.Contains(GestionForms.utilisateurConnecte.noType))
                        item.Visible = false;
                }
                else if (item == miseÀJourDesAbonnésToolStripMenuItem)
                {
                    if (!permissionMAJAbonnement.Contains(GestionForms.utilisateurConnecte.noType))
                        item.Visible = false;
                }
                else if (item == modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem)
                {
                    if (!permissionModifPrix.Contains(GestionForms.utilisateurConnecte.noType))
                        item.Visible = false;
                }
                else if (item == inscriptionDunePartieToolStripMenuItem)
                {
                    if (!permissionInscriptionPartie.Contains(GestionForms.utilisateurConnecte.noType))
                        item.Visible = false;
                }
            }         
        }

      
   }    
}
