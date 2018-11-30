using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.ModifPrix
{
    public partial class FrmModifPrix : Form
    {
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();
        public FrmModifPrix()
        {
            InitializeComponent();
        }

        private void FrmModifPrix_Load(object sender, EventArgs e)
        {
            LoadType();
            DisablePrixNonModifiable();
        }
        private void LoadType()
        {
            //selectionner tout les types avec leurs prix
            var typeAbonnements = from unType in monDatatContext.TypeAbonnements
                                  join unPrix in monDatatContext.PrixDepenseAbonnements
                                     on unType.No equals unPrix.NoTypeAbonnement
                                  select new {no=unType.No,desription=unType.Description,annee=unPrix.Anne,prix=unPrix.Prix,depense=unPrix.DepenseObligatoire,remarque=unType.Remarque };

            //selectionner uniquement le prix le plus recent
            var dataSource = typeAbonnements.GroupBy(item => item.no)
                             .SelectMany(grouping => grouping.OrderByDescending(item => item.annee).Take(1))
                             .OrderBy(item => item.no)
                             .ToList();

            BindingSource source = new BindingSource(dataSource, null);

            dataGridView1.DataSource = dataSource;
        }
        private void DisablePrixNonModifiable()
        {
            DateTime anneCourante = DateTime.Now;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime anneDuPrix = (DateTime)row.Cells["annee"].Value;
                if (anneDuPrix.Year == anneCourante.Year)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.ReadOnly = true;
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        int columnIndex = cell.ColumnIndex;
                        string columnName = dataGridView1.Columns[columnIndex].Name;
                        if (columnName == "depense" || columnName == "prix")
                        {
                            cell.ReadOnly = false;
                            cell.Style.BackColor = Color.LightPink;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.CurrentCell.ReadOnly = false;
        }
    }
}
