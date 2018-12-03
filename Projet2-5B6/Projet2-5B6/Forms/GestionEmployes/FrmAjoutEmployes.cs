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
            else if (!(new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$").Match(tbPassword.Text)).Success)
            {
                btnConfirmer.Enabled = false;
                errorProvider1.SetError(btnConfirmer, "Le mot de passe n'est pas valide");
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
            else if(!tbTelephone.MaskCompleted)
            {
                btnConfirmer.Enabled = false;
                errorProvider1.SetError(btnConfirmer, "Le numéro de téléphone n'est pas valide");
            }
            else if((!tbCellulaire.MaskCompleted) && tbCellulaire.Text != "(   )    -")
            {
                btnConfirmer.Enabled = false;
                errorProvider1.SetError(btnConfirmer, "Ls numéro de cellulaire n'est pas valide");
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
            if(employeModifier == null)
            {
                AjouterEmploye();
            }
            else
            {
                ModifierEmploye();
            }
        }
        private void ModifierEmploye()
        {
            Nullable<decimal> cellulaire = null;

            int.TryParse(ddlTypeEmploye.SelectedValue.ToString(), out int noTypeEmploi);

            decimal.TryParse(tbSalaireHoraire.Text, out decimal salaire);

            decimal.TryParse(Regex.Replace(tbTelephone.Text, @"[\(\)\- ]", ""), out decimal telephone);

            if (tbCellulaire.Text != "(   )    -")
            {
                decimal.TryParse(Regex.Replace(tbCellulaire.Text, @"[\(\)\- ]", ""), out decimal cell);
                if(cell==0)
                    cellulaire = cell;
            }

            employeModifier.MotDePasse = tbPassword.Text;
            employeModifier.Nom = tbNom.Text;
            employeModifier.Prenom = tbPrenom.Text;
            employeModifier.Sexe = (ddlSexe.SelectedValue.ToString())[0];
            employeModifier.Age = Convert.ToInt32(Math.Round(numAge.Value));
            employeModifier.NoCivique = Convert.ToInt32(Math.Round(numNoCivique.Value));
            employeModifier.Rue = tbRue.Text;
            employeModifier.Ville = tbVille.Text;
            employeModifier.IdProvince = ddlProvince.SelectedValue.ToString();
            employeModifier.CodePostal = tbCodePostal.Text;
            employeModifier.Telephone = telephone;
            employeModifier.Cellulaire = cellulaire;
            employeModifier.Courriel = tbCourriel.Text;
            employeModifier.SalaireHoraire = salaire;
            employeModifier.NoTypeEmploye = noTypeEmploi;
            employeModifier.Remarque = tbRemarque.Text == ""?null: tbRemarque.Text;

            new Abonnement
            {
                Cellulaire = null
            };

            frmGestion.Enregistrer();
            this.Hide();
        }
        private void AjouterEmploye()
        {
            Nullable<decimal> cellulaire = null;

            int.TryParse(ddlTypeEmploye.SelectedValue.ToString(), out int noTypeEmploi);

            decimal.TryParse(tbSalaireHoraire.Text, out decimal salaire);

            decimal.TryParse(Regex.Replace(tbTelephone.Text, @"[\(\)\- ]", ""), out decimal telephone);

            if (tbCellulaire.Text != "(   )    -")
            {
                decimal.TryParse(Regex.Replace(tbCellulaire.Text, @"[\(\)\- ]", ""), out decimal cell);
                if (cell == 0)
                    cellulaire = cell;
            }
            Employe employe = new Employe
            {
                No = int.Parse(tbNo.Text),
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
        private void LoadToolTip()
        {
            int VisibleTime = 5000; 
            toolTip1.Show(" 8 caractères minimum /n 1 majuscule minimum /n 1 chiffre minimum /n 1`caractères spéciales minimum", tbPassword,0,0, VisibleTime);
        }
        private void FrmAjoutEmployes_Load(object sender, EventArgs e)
        {

            LoadProvince();
            LoadTypeEmploye();
            LoadSexe();
            LoadToolTip();

            if(employeModifier != null)
            {
                LoadEmploye();
                ddlTypeEmploye.Enabled = false;
            }
            else
            {
                tbNo.Text = FindNextNoAvailable().ToString();
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
            tbPassword.Text = employeModifier.MotDePasse;
            tbNom.Text = employeModifier.Nom;
            tbPrenom.Text = employeModifier.Prenom;
            ddlSexe.SelectedValue = employeModifier.Sexe;
            numAge.Value = employeModifier.Age;
            numNoCivique.Value = employeModifier.NoCivique;
            tbRue.Text = employeModifier.Rue;
            tbVille.Text = employeModifier.Ville;
            ddlProvince.SelectedValue = employeModifier.IdProvince;
            tbCodePostal.Text = employeModifier.CodePostal;
            tbTelephone.Text = Convert.ToString(employeModifier.Telephone);
            tbCellulaire.Text = Convert.ToString(employeModifier.Cellulaire);
            tbCourriel.Text = employeModifier.Courriel;
            tbSalaireHoraire.Text = Convert.ToString(employeModifier.SalaireHoraire);
            ddlTypeEmploye.SelectedValue = employeModifier.NoTypeEmploye;
            tbRemarque.Text = employeModifier.Remarque;
        }
        private int FindNextNoAvailable()
        {

            var employes = from unEmploye in monDatatContext.Employes
                                              orderby unEmploye.No ascending
                                              select unEmploye;

            int plusGrandId = 0;

            foreach (Employe employe in employes.ToList())
            {
                if (employe.No > plusGrandId)
                {
                    plusGrandId = employe.No;
                }
            }

            return plusGrandId + 1;
        }
    }
}
        