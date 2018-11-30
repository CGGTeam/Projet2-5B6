using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6
{
    /// classe permettant l'implémentation de fonction utile pour toutes les pages
    static class ADOUtils
    {
        public static Boolean DemandeSupprimer()
        {
            var confirmResult = MessageBox.Show("Êtes-vous sure de vouloir supprimer cet élément?",
                                   "Confirmation",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
                return true;

            else
                return false;
        }
    }
}

