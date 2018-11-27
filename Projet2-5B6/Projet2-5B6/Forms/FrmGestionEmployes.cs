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
    public partial class FrmGestionEmployes : BaseForm
    {
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();
        public FrmGestionEmployes()
        {
            InitializeComponent();
        }

        private void FrmGestionEmployes_Load(object sender, EventArgs e)
        {
            employeBindingSource.DataSource = from unEmploye in monDatatContext.Employes
                                                select unEmploye;
        }
    }
}
