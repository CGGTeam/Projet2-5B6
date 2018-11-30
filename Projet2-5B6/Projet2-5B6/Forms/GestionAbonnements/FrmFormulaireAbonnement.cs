using Projet2_5B6.ClassesUtiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Projet2_5B6.Forms.GestionAbonnements
{
   public partial class FrmFormulaireAbonnement : Form
   {
      private DataClasses1DataContext data = new DataClasses1DataContext();
      public int noTypeAbonnement;

      private List<Enfant> lstEnfants = new List<Enfant>();

      public FrmFormulaireAbonnement()
      {
         InitializeComponent();
      }

      private void FrmFormulaireAbonnement_Load(object sender, EventArgs e)
      {
         // remplir mes data sources
         provinceBindingSource.DataSource = from provinces in data.Provinces
                                            select provinces;

         // instancier la bonne interface
         switch (noTypeAbonnement)
         {
            case 1: personneSeule(); break;
            case 2: ageDOr(); break;
            case 3: couple(); break;
            case 4: familleUn(); break;
            case 5: familleDeux(); break;
            case 6: familleTroisOuPlus(); break;
            default: personneSeule(); break;
         }

         cbSexeEnfant.SelectedIndex = 0;
         cbSexeAbo.SelectedIndex = 0;
         cbSexeConjoint.SelectedIndex = 0;
      }

      private void lblTitre_Click(object sender, EventArgs e)
      {

      }

      private void tbCell_MouseHover(object sender, EventArgs e)
      {

      }

      private void personneSeule()
      {
         gbConjoint.Visible = false;
         gbEnfants.Visible = false;
         gbListeEnfants.Visible = false;
      }

      private void ageDOr()
      {
         gbConjoint.Visible = false;
         gbEnfants.Visible = false;
         gbListeEnfants.Visible = false;
      }

      private void couple()
      {
         gbEnfants.Visible = false;
         gbListeEnfants.Visible = false;
      }

      private void familleUn()
      {
         nudNbEnfants.Value = 1;
         nudNbEnfants.Enabled = false;
      }

      private void familleDeux()
      {
         nudNbEnfants.Value = 2;
         nudNbEnfants.Enabled = false;
      }

      private void familleTroisOuPlus()
      {
         nudNbEnfants.Value = 3;
         nudNbEnfants.Minimum = 3;
         nudNbEnfants.Maximum = 9;
      }

      private void viderGbEnfants()
      {
         tbNomEnfant.Text = "";
         tbPrenomEnfant.Text = "";
         tbRemarqueEnfant.Text = "";
         cbSexeEnfant.SelectedIndex = 0;
         dateNaissanceEnfant.Value = DateTime.Now;
      }

      private void enableDisableInfosEnfant(bool enabled)
      {
         tbNomEnfant.Enabled = enabled;
         tbPrenomEnfant.Enabled = enabled;
         cbSexeEnfant.Enabled = enabled;
         dateNaissanceEnfant.Enabled = enabled;
         tbRemarqueEnfant.Enabled = enabled;
         btnAjouterEnfant.Enabled = enabled;
      }

      private void nudNbEnfants_ValueChanged(object sender, EventArgs e)
      {
         if (lstEnfants.Count < nudNbEnfants.Value)
         {
            enableDisableInfosEnfant(true);
         }
         else
         {
            enableDisableInfosEnfant(false);
         }
      }

      private void enregistrerDansLaBD()
      {
         using (TransactionScope tran = new TransactionScope())
         {
            // créer le bon id pour abonné
            var maxAboID = from abonnement in data.Abonnements
                           let id = abonnement.Id.Substring(abonnement.Id.Length - 2, 1)
                           select new
                           {
                              id = id
                           };

            var plusGrosID = maxAboID.Max(id => id.id);
            int intLePlusGrosID = int.Parse(plusGrosID) + 1;

            // créer le nouvel abonné
            string idNouvelAbonne = tbNomAbo.Text + intLePlusGrosID + "P";

            var nouvelAbonnement = new Projet2_5B6.Abonnement
            {
               Id = idNouvelAbonne,
               DateAbonnement = DateTime.Now,
               Nom = tbNomAbo.Text.Trim(),
               Prenom = tbPrenomAbo.Text.Trim(),
               Sexe = (cbSexeAbo.Text == "Homme") ? 'H' : 'F',
               DateNaissance = dateNaissanceAbo.Value,
               NoCivique = int.Parse(tbCiviqueAbo.Text.Trim()),
               Rue = tbRueAbo.Text.Trim(),
               Ville = tbVilleAbo.Text.Trim(),
               IdProvince = cbProvinceAbo.SelectedValue.ToString(),
               CodePostal = tbPostalAbo.Text.Trim(),
               Telephone = int.Parse(tbTelephoneAbo.Text.Replace("-", "")),
               Cellulaire = int.Parse(tbCellAbo.Text.Replace("-", "")),
               Courriel = tbCourrielAbo.Text.Trim(),
               NoTypeAbonnement = this.noTypeAbonnement,
               Remarque = tbRemarqueAbo.Text.Trim()
            };
            data.Abonnements.InsertOnSubmit(nouvelAbonnement);

            // si couple
            if (this.noTypeAbonnement >= 3)
            {
               string idConjoint = tbNomConjoint.Text.Trim() + intLePlusGrosID + ((cbSexeConjoint.Text == "Homme") ? 'H' : 'F') + "0";

               var nouveauConjoint = new Projet2_5B6.Dependant
               {
                  Id = idConjoint,
                  Nom = tbNomConjoint.Text.Trim(),
                  Prenom = tbPrenomConjoint.Text.Trim(),
                  Sexe = ((cbSexeConjoint.Text == "Homme") ? 'H' : 'F'),
                  DateNaissance = dateNaissanceConjoint.Value,
                  IdAbonnement = idNouvelAbonne,
                  Remarque = tbRemarqueConjoint.Text.Trim()
               };

               data.Dependants.InsertOnSubmit(nouveauConjoint);
            }

            // si couple avec enfants
            if (this.noTypeAbonnement >= 4)
            {
               // créer les enfants dans la BD
               int index = 1;
               foreach (Enfant enf in lstEnfants)
               {
                  var nouvelEnfant = new Projet2_5B6.Dependant
                  {
                     Id = enf.id = tbNomAbo.Text.Trim() + intLePlusGrosID + "E" + index,
                     Nom = enf.nom,
                     Prenom = enf.prenom,
                     Sexe = enf.sexe,
                     DateNaissance = enf.dateNaissance,
                     IdAbonnement = idNouvelAbonne,
                     Remarque = enf.remarque
                  };
                  data.Dependants.InsertOnSubmit(nouvelEnfant);

                  index++;
               }
            }

            data.SubmitChanges();
            tran.Complete();
         }
      }

      private void btnAjouterEnfant_Click(object sender, EventArgs e)
      {
         bool valide = true;

         if (tbNomEnfant.Text == "")
         {
            errorProvider.SetError(tbNomEnfant, "Le nom ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(tbNomEnfant, "");

         if (tbPrenomEnfant.Text == "")
         {
            errorProvider.SetError(tbPrenomEnfant, "Le prénom ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(tbPrenomEnfant, "");

         if (cbSexeEnfant.Text == "")
         {
            errorProvider.SetError(cbSexeEnfant, "Le sexe ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(cbSexeEnfant, "");

         var dateNaissance = dateNaissanceEnfant.Value;
         var date18 = dateNaissance.AddYears(18);
         if (DateTime.Now < dateNaissanceEnfant.Value)
         {
            errorProvider.SetError(dateNaissanceEnfant, "L'enfant doit être au moins âgé de 1 jour.");
            valide = false;
         }
         else if (DateTime.Now >= date18)
         {
            errorProvider.SetError(dateNaissanceEnfant, "L'enfant doit être âgé de moins de 18 ans.");
            valide = false;
         }
         else errorProvider.SetError(dateNaissanceEnfant, "");

         if (valide)
         {
            this.lstEnfants.Add(
               new Enfant
               {
                  id = "",
                  nom = tbNomEnfant.Text,
                  prenom = tbPrenomEnfant.Text,
                  sexe = (cbSexeEnfant.Text == "Homme") ? 'H' : 'F',
                  dateNaissance = dateNaissanceEnfant.Value,
                  remarque = tbRemarqueEnfant.Text.Trim()
               });

            // ajouter l'enfant à la liste visuelle
            listeEnfantsControle.Items.Add(tbPrenomEnfant.Text + " " + tbNomEnfant.Text);

            // vider cb enfants
            viderGbEnfants();

            // ajuster le minimum d'enfants
            if (this.noTypeAbonnement == 6)
            {
               if (lstEnfants.Count > 3)
               {
                  nudNbEnfants.Minimum = lstEnfants.Count;
               }
            }

            if (nudNbEnfants.Value == lstEnfants.Count)
            {
               enableDisableInfosEnfant(false);
            }
         }

      }

      private void btnRetirerEnfant_Click(object sender, EventArgs e)
      {
         int indexEnfant = listeEnfantsControle.SelectedIndex;
         if (indexEnfant != -1)
         {
            lstEnfants.RemoveAt(indexEnfant);
            listeEnfantsControle.Items.RemoveAt(indexEnfant);
            enableDisableInfosEnfant(true);
            if (noTypeAbonnement == 6)
            {
               if ((nudNbEnfants.Minimum - 1) >= 3)
               {
                  nudNbEnfants.Minimum--;
                  nudNbEnfants.Value--;
               }
            }

         }
         else
         {
            MessageBox.Show("Vous devez sélectionner un enfant avant de retirer !", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void btnConfirmer_Click(object sender, EventArgs e)
      {
         bool valide = true;

         if (tbNomAbo.Text == "")
         {
            errorProvider.SetError(tbNomAbo, "Le nom ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(tbNomAbo, "");

         if (tbPrenomAbo.Text == "")
         {
            errorProvider.SetError(tbPrenomAbo, "Le prénom ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(tbPrenomAbo, "");

         if (cbSexeAbo.Text == "")
         {
            errorProvider.SetError(cbSexeAbo, "Le sexe ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(cbSexeAbo, "");

         Regex regxTelephone = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
         if (tbTelephoneAbo.Text == "")
         {
            errorProvider.SetError(tbTelephoneAbo, "Le téléphone ne peut pas être vide.");
            valide = false;
         }
         else if (!regxTelephone.IsMatch(tbTelephoneAbo.Text))
         {
            errorProvider.SetError(tbTelephoneAbo, "Format non respecté. Format : 999-999-9999");
            valide = false;
         }
         else errorProvider.SetError(tbTelephoneAbo, "");

         if (tbCellAbo.Text != "")
         {
            if (!regxTelephone.IsMatch(tbCellAbo.Text))
            {
               errorProvider.SetError(tbCellAbo, "Format non respecté. Format : 999-999-9999");
               valide = false;
            }
            else errorProvider.SetError(tbCellAbo, "");
         }
         else
         {
            errorProvider.SetError(tbCellAbo, "");
         }

         if (tbCourrielAbo.Text == "")
         {
            errorProvider.SetError(tbCourrielAbo, "Le courriel ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(tbCourrielAbo, "");

         var dateNaissance = dateNaissanceAbo.Value;
         if (this.noTypeAbonnement == 2)
         {
            var date60 = dateNaissance.AddYears(60);
            if (date60 > DateTime.Now)
            {
               errorProvider.SetError(dateNaissanceAbo, "L'abonné doit être âgé d'au moins 60 ans.");
               valide = false;
            }
            else errorProvider.SetError(dateNaissanceAbo, "");
         }
         else
         {
            var date18 = dateNaissance.AddYears(18);
            if (date18 > DateTime.Now)
            {
               errorProvider.SetError(dateNaissanceAbo, "L'abonné doit être âgé d'au moins 18 ans.");
               valide = false;
            }
            else errorProvider.SetError(dateNaissanceAbo, "");
         }

         Regex regxCivique = new Regex("^[0-9]{0,}$");
         if (tbCiviqueAbo.Text == "")
         {
            errorProvider.SetError(tbCiviqueAbo, "L'adresse civique ne peut pas être vide.");
            valide = false;
         }
         else if (!regxCivique.IsMatch(tbCiviqueAbo.Text))
         {
            errorProvider.SetError(tbCiviqueAbo, "L'adresse civique doit être un entier.");
            valide = false;
         }
         else errorProvider.SetError(tbCiviqueAbo, "");

         if (tbRueAbo.Text == "")
         {
            errorProvider.SetError(tbRueAbo, "Le nom de la rue ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(tbRueAbo, "");

         if (tbVilleAbo.Text == "")
         {
            errorProvider.SetError(tbVilleAbo, "Le nom de la ville ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(tbVilleAbo, "");

         if (cbProvinceAbo.Text == "")
         {
            errorProvider.SetError(cbProvinceAbo, "La province ne peut pas être vide.");
            valide = false;
         }
         else errorProvider.SetError(cbProvinceAbo, "");

         Regex regxPostal = new Regex("^[A-Z]{1}[0-9]{1}[A-Z]{1}[0-9]{1}[A-Z]{1}[0-9]{1}$");
         if (tbPostalAbo.Text == "")
         {
            errorProvider.SetError(tbPostalAbo, "Le code postal ne peut pas être vide.");
            valide = false;
         }
         else if (!regxPostal.IsMatch(tbPostalAbo.Text))
         {
            errorProvider.SetError(tbPostalAbo, "Format non respecté. Format : A9A9A9");
            valide = false;
         }
         else errorProvider.SetError(tbPostalAbo, "");

         if (this.noTypeAbonnement >= 3)
         {
            if (tbNomConjoint.Text == "")
            {
               errorProvider.SetError(tbNomConjoint, "Le nom ne peut pas être vide.");
               valide = false;
            }
            else errorProvider.SetError(tbNomConjoint, "");

            if (tbPrenomConjoint.Text == "")
            {
               errorProvider.SetError(tbPrenomConjoint, "Le prénom ne peut pas être vide.");
               valide = false;
            }
            else errorProvider.SetError(tbPrenomConjoint, "");

            if (cbSexeConjoint.Text == "")
            {
               errorProvider.SetError(cbSexeConjoint, "Le sexe ne peut pas être vide.");
               valide = false;
            }
            else errorProvider.SetError(cbSexeConjoint, "");

            var date18 = dateNaissanceConjoint.Value.AddYears(18);
            if (date18 > DateTime.Now)
            {
               errorProvider.SetError(dateNaissanceConjoint, "Le conjoint doit être âgé d'au moins 18 ans.");
               valide = false;
            }
            else errorProvider.SetError(dateNaissanceConjoint, "");
         }

         if (this.noTypeAbonnement >= 4)
         {
            decimal nbEnfants = nudNbEnfants.Value;
            if (!(nbEnfants == lstEnfants.Count))
            {
               errorProvider.SetError(nudNbEnfants, "Il manque au moins un enfant à ajouter dans le système.");
               valide = false;
            }
            else
            {
               errorProvider.SetError(nudNbEnfants, "");
            }
         }

         if (valide)
         {
            enregistrerDansLaBD();
            this.Close();
         }



      }
   }
}
