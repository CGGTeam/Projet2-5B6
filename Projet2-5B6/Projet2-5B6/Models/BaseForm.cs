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
                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
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
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
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
    }
    
}
