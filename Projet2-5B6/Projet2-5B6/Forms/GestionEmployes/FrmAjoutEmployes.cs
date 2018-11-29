using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.GestionEmployes
{
    public partial class FrmAjoutEmployes : Form
    {
        DataClasses1DataContext monDatatContext;
        FrmGestionEmployes frmGestion;
        Employe employeModifier;
        private Control[] controlesAValider;
        public FrmAjoutEmployes(DataClasses1DataContext monDatatContext, FrmGestionEmployes frmGestion, Employe employeModifier)
        {
            InitializeComponent();

            this.monDatatContext = monDatatContext;
            this.frmGestion = frmGestion;
            this.employeModifier = employeModifier;

            controlesAValider = new Control[]
            {
                tbPassword,
                tbNom,
                tbPrenom,
                tbRue,
                tbVille,
                tbCodePostal,
                tbTelephone,
                tbCellulaire,
                tbCourriel,
                tbSalaireHoraire
            };
        }
        private void Valider(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(tbTelephone.Text);

            double salaire;
            if (!controlesAValider.All(ctrl => ctrl.Text.Trim() != "")){
                btnConfirmer.Enabled = false;
                errorProvider1.SetError(btnConfirmer, "Il y a des champs vides");
            }
            else if(!double.TryParse(tbSalaireHoraire.Text ,out salaire)){
                btnConfirmer.Enabled = false;
                errorProvider1.SetError(btnConfirmer, "Le salaire n'est pas dans un format valide");
            }
            else if(salaire < 10.00 || salaire > 500.00)
            {
                btnConfirmer.Enabled = false;
                errorProvider1.SetError(btnConfirmer, "Le salaire doit être entre 10.00 et 500.00");
            }
            else if(!tbCellulaire.MaskCompleted || !tbTelephone.MaskCompleted)
            {
                btnConfirmer.Enabled = false;
                errorProvider1.SetError(btnConfirmer, "Les numéros de téléphone ne sont pas valide");
            }
            else if (!(new Regex(@"^([ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]){1}$").Match(tbCodePostal.Text)).Success)
            {
                btnConfirmer.Enabled = false;
                errorProvider1.SetError(btnConfirmer, "Le code postal n'est pas valide");
            }
            else
            {
                btnConfirmer.Enabled = true;
                errorProvider1.Clear();
            }
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            int.TryParse(ddlTypeEmploye.SelectedValue.ToString(), out int noTypeEmploi );

            decimal.TryParse(tbSalaireHoraire.Text, out decimal salaire);

            decimal.TryParse(tbTelephone.Text.Trim(new Char[] { ' ', '(', ')', '-' }), out decimal telephone);

            decimal.TryParse(tbCellulaire.Text.Trim(new Char[] { ' ', '(', ')', '-' }), out decimal cellulaire);
            Employe employe = new Employe
            {
                No = 2,
                MotDePasse = tbPassword.Text,
                Nom = tbNom.Text,
                Prenom = tbPrenom.Text,
                Sexe = (ddlSexe.SelectedValue.ToString())[0],
                Age = Convert.ToInt32(Math.Round(numAge.Value)),
                NoCivique = Convert.ToInt32(Math.Round(numNoCivique.Value)),
                Rue = tbRue.Text,
                Ville = tbVille.Text,
                IdProvince = ddlProvince.SelectedValue.ToString(),
                CodePostal = tbCodePostal.Text,
                Telephone = telephone,
                Cellulaire = cellulaire,
                Courriel = tbCourriel.Text,
                SalaireHoraire = salaire,
                NoTypeEmploye = noTypeEmploi,
                Remarque = tbRemarque.Text
            };

            monDatatContext.Employes.InsertOnSubmit(employe);
            frmGestion.Enregistrer();
            this.Hide();
        }

        private void FrmAjoutEmployes_Load(object sender, EventArgs e)
        {

            LoadProvince();
            LoadTypeEmploye();
            LoadSexe();

            if(employeModifier != null)
            {
                LoadEmploye();
            }
        }
        private void LoadProvince()
        {
            //load les provinces
            provinceBindingSource.DataSource = from province in monDatatContext.Provinces
                                               orderby province.Nom ascending
                                               select province;
        }
        private void LoadTypeEmploye()
        {
            //load les types d'employé
            typesEmployeBindingSource.DataSource = from type in monDatatContext.TypesEmployes
                                                   orderby type.No ascending
                                                   where type.No != 1
                                                   select type;
        }
        private void LoadSexe()
        {
            //load les sexes
            Dictionary<char, String> comboSource = new Dictionary<char, String>();
            comboSource.Add('H', "Homme");
            comboSource.Add('F', "Femme");

            ddlSexe.DataSource = new BindingSource(comboSource, null);
            ddlSexe.DisplayMember = "Value";
            ddlSexe.ValueMember = "Key";
        }
        private void LoadEmploye()
        {
            this.Text = "Modification d'un employé";
            lblTitre.Text = "Modification d'un employé";

            tbNo.Text = Convert.ToString(employeModifier.No);
        }
    }
}
        