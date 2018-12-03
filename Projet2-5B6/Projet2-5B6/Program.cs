using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6
{
    static class Program
    {
        /// VERSION 1.0
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GestionForms gf = new GestionForms();
            gf.Demarrer();
        }
    }
}
