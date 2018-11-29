using Projet2_5B6.Forms.GestionEmployes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms
{
    public partial class FrmGestionEmployes : Form
    {
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();
        public FrmGestionEmployes()
        {
            InitializeComponent();
        }

        private void FrmGestionEmployes_Load(object sender, EventArgs e)
        {

            LoadTypesEmployeBindingSource();
            LoadProvinceBindingSource();
            LoadEmployeBindingSource();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            new FrmAjoutEmployes(monDatatContext, this, null).Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int iid = 0;

            int rowindex = employeDataGridView.CurrentRow.Index;

            iid = Convert.ToInt32(employeDataGridView.Rows[rowindex].Cells[0].Value);

            var modifier = from p in monDatatContext.Employes
                         where p.No == iid
                         select p;
            Employe employeModifier = modifier.First();
            if(employeModifier.No == 1)
            {
                MessageBox.Show("Impossible de modifier l'administrateur");
                return;
            }

            new FrmAjoutEmployes(monDatatContext, this, employeModifier).Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int iid = 0;

            int rowindex = employeDataGridView.CurrentRow.Index;

            iid = Convert.ToInt32(employeDataGridView.Rows[rowindex].Cells[0].Value);

            var delete = from p in monDatatContext.Employes
                         where p.No == iid
                         select p;

            monDatatContext.Employes.DeleteAllOnSubmit(delete);
            Enregistrer();
        }
        private void LoadEmployeBindingSource()
        {
            employeBindingSource.DataSource = from unEmploye in monDatatContext.Employes
                                              orderby unEmploye.No ascending
                                              select unEmploye;
        }
        private void LoadTypesEmployeBindingSource()
        {
            typesEmployeBindingSource.DataSource = from unType in monDatatContext.TypesEmployes
                                                   select unType;
        }
        private void LoadProvinceBindingSource()
        {
            provinceBindingSource.DataSource = from uneProvince in monDatatContext.Provinces
                                              select uneProvince;
        }
        public void Enregistrer()
        {
            employeBindingSource.EndEdit();

            try
            {
                monDatatContext.SubmitChanges();
            }
            catch (ChangeConflictException)
            {
                monDatatContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
            }
            catch (Exception ex)
            {
                lblErrorProvide.Text = "Une erreure est survenue : " + ex.Message;
            }
            LoadEmployeBindingSource();
        }
    }
}
