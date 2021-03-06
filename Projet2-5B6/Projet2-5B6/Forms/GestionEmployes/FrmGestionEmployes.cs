﻿using Projet2_5B6.Forms.GestionEmployes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
            var modifier = from p in monDatatContext.Employes
                         where p == (Employe)employeBindingSource.Current
                         select p;
            Employe employeModifier = modifier.First();

            if (employeModifier.No == 1)
            {
                MessageBox.Show("Impossible de modifier l'administrateur");
                return;
            }

            new FrmAjoutEmployes(monDatatContext, this, employeModifier).Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            var delete = from p in monDatatContext.Employes
                         where p == (Employe)employeBindingSource.Current
                         select p;

            if (!EmployeEstSupprimable(delete.First())) return;

            if (ADOUtils.DemandeSupprimer())
            {

                monDatatContext.Employes.DeleteAllOnSubmit(delete);
                Enregistrer();
            }

        }
        private bool EmployeEstSupprimable(Employe selection)
        {
            bool peutEtreSupprime = true;
            if (selection.No == 1)
            {
                MessageBox.Show("Impossible de supprimer l'administrateur", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                peutEtreSupprime = false;
            }
            else
            {
                var test = from unService in monDatatContext.Services
                           where unService.NoEmple == selection.No
                           select unService;

                if (test.Any())
                {
                    MessageBox.Show("Impossible de supprimer un employé qui a des services de liés", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    peutEtreSupprime = false;
                }
            }

            return peutEtreSupprime;
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

            using(var transaction = new TransactionScope())
            {
                try
                {
                    monDatatContext.SubmitChanges();
                    transaction.Complete();
                }
                catch (ChangeConflictException)
                {
                    monDatatContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
                catch (Exception ex)
                {
                    lblErrorProvide.Text = "Une erreure est survenue : " + ex.Message;
                }
            }
            LoadEmployeBindingSource();
        }
    }
}
