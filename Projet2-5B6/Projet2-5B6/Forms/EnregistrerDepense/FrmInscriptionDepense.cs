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

namespace Projet2_5B6.Forms.EnregistrerDepense
{
    public partial class FrmInscriptionDepense : Form
    {
        DataClasses1DataContext monDatatContext = new DataClasses1DataContext();
        public FrmInscriptionDepense()
        {
            InitializeComponent();
        }

        private void FrmInscriptionDepense_Load(object sender, EventArgs e)
        {
            LoadAbonnement();
            LoadTypeDepense();
        }
        private void LoadAbonnement()
        {
            idEtNomCompletAboBindingSource.DataSource = from abonne in monDatatContext.Abonnements
                                                        let dateValide = abonne.DateAbonnement.AddYears(1)
                                                        where DateTime.Now < dateValide
                                                        select new
                                                        {
                                                            id = abonne.Id,
                                                            nomComplet = abonne.Prenom + " " + abonne.Nom
                                                        };
        }
        private void LoadTypeDepense()
        {
            SortedDictionary<int, string> userCache = new SortedDictionary<int, string>
                {
                  {1, "Magasin Pro Shop"},
                  {2, "Restaurant"},
                  {3, "Leçon de golf"}
                };
            ddlTypeDepense.DataSource = new BindingSource(userCache, null);
            ddlTypeDepense.DisplayMember = "Value";
            ddlTypeDepense.ValueMember = "Value";

            int noTypeEmploye = GestionForms.utilisateurConnecte.noType;

            switch (noTypeEmploye)
            {
                case 5:
                    ddlTypeDepense.SelectedValue = "Magasin Pro Shop";
                    ddlTypeDepense.Enabled = false;
                    break;
                case 6:
                    ddlTypeDepense.SelectedValue = "Restaurant";
                    ddlTypeDepense.Enabled = false;
                    break;
                case 7:
                    ddlTypeDepense.SelectedValue = "Leçon de golf";
                    ddlTypeDepense.Enabled = false;
                    break;
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string idAbonnement = GetSelectedIdAbonnement();
            int noDepense = FindNextNoDepenseAvailable();
            int noService = FindNoServie();
            decimal montant = numMontant.Value;
            DateTime date = DateTime.Now;
            string remarque = tbRemarque.Text == "" ? null : tbRemarque.Text;

            Depense depense = InsererDepense(noDepense, idAbonnement, date, montant, noService, remarque);

            if (Enregistrer())
            {
                new FrmInformationDepense(monDatatContext, depense).ShowDialog();
            }
        }
        private Depense InsererDepense(int no, string idAbonnement, DateTime date, decimal montant, int noService, string remarque)
        {
            Depense depense = new Depense
            {
                No = no,
                IdAbonnement = idAbonnement,
                DateDepense = date,
                Montant = montant,
                NoService = noService,
                Remarque = remarque
            };
            monDatatContext.Depenses.InsertOnSubmit(depense);

            return depense;
        }
        private bool Enregistrer()
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    monDatatContext.SubmitChanges();
                    transaction.Complete();
                    lblErrorProvider.Text = "Enregistrement éffectué avec succès";

                    return true;
                }
                catch (ChangeConflictException ex)
                {
                    monDatatContext.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                    lblErrorProvider.Text = "Une erreure est survenue : " + Environment.NewLine + ex.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    lblErrorProvider.Text = "Une erreure est survenue : " + Environment.NewLine + ex.Message;

                    return false;
                }
            }
        }
        private string GetSelectedIdAbonnement()
        {
            int selectedrowindex = idEtNomCompletAboDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = idEtNomCompletAboDataGridView.Rows[selectedrowindex];
            string idAbonnement = Convert.ToString(selectedRow.Cells["dataGridViewTbId"].Value);

            return idAbonnement;
        }
        private string GetSelectedTypeDepense()
        {
            string typeDepense = ddlTypeDepense.SelectedValue.ToString();

            return typeDepense;
        }
        private int FindNextNoDepenseAvailable()
        {
            var depenses = from uneDepense in monDatatContext.Depenses
                           orderby uneDepense.No ascending
                           select uneDepense;

            int plusGrandId = 0;

            foreach (Depense depense in depenses.ToList())
            {
                if (depense.No > plusGrandId)
                {
                    plusGrandId = depense.No;
                }
            }

            return plusGrandId + 1;
        }
        private int FindNextNoServiceAvailable()
        {
            var services = from unService in monDatatContext.Services
                           orderby unService.No ascending
                           select unService;

            int plusGrandId = 0;

            foreach (Service service in services.ToList())
            {
                if (service.No > plusGrandId)
                {
                    plusGrandId = service.No;
                }
            }

            return plusGrandId + 1;
        }
        private int FindNoServie()
        {
            int noService = 0;
            int noEmploye = GestionForms.utilisateurConnecte.no;
            string typeDepense = GetSelectedTypeDepense();

            var services = from unService in monDatatContext.Services
                           orderby unService.No ascending
                           where unService.TypeService == typeDepense
                                && unService.NoEmple == noEmploye
                           select unService;

            //si le service n'existe pas, l'ajouté
            if (!services.Any())
            {
                noService = FindNextNoServiceAvailable();
                Service service = new Service
                {
                    No = noService,
                    TypeService = typeDepense,
                    NoEmple = noEmploye
                };
                monDatatContext.Services.InsertOnSubmit(service);
            }
            else
            {
                noService = services.First().No;
            }
            return noService;
        }
    }
}
