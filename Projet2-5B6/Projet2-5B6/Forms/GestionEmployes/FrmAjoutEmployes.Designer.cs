namespace Projet2_5B6.Forms.GestionEmployes
{
    partial class FrmAjoutEmployes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.ddlSexe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.tbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.numNoCivique = new System.Windows.Forms.NumericUpDown();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlProvince = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ddlTypeEmploye = new System.Windows.Forms.ComboBox();
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSalaireHoraire = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(13, 13);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(161, 20);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Ajout d\'un employé";
            // 
            // tbNo
            // 
            this.tbNo.Enabled = false;
            this.tbNo.Location = new System.Drawing.Point(101, 35);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(130, 20);
            this.tbNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No d\'employé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe :";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(101, 61);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(130, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextChanged += new System.EventHandler(this.Valider);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(101, 87);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(130, 20);
            this.tbNom.TabIndex = 5;
            this.tbNom.TextChanged += new System.EventHandler(this.Valider);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prénom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(101, 113);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(130, 20);
            this.tbPrenom.TabIndex = 7;
            this.tbPrenom.TextChanged += new System.EventHandler(this.Valider);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Age :";
            // 
            // Sexe
            // 
            this.Sexe.AutoSize = true;
            this.Sexe.Location = new System.Drawing.Point(18, 142);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(37, 13);
            this.Sexe.TabIndex = 10;
            this.Sexe.Text = "Sexe :";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(101, 165);
            this.numAge.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(130, 20);
            this.numAge.TabIndex = 13;
            this.numAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // ddlSexe
            // 
            this.ddlSexe.FormattingEnabled = true;
            this.ddlSexe.Location = new System.Drawing.Point(101, 138);
            this.ddlSexe.Name = "ddlSexe";
            this.ddlSexe.Size = new System.Drawing.Size(130, 21);
            this.ddlSexe.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.tbCellulaire);
            this.groupBox1.Controls.Add(this.tbTelephone);
            this.groupBox1.Controls.Add(this.numNoCivique);
            this.groupBox1.Controls.Add(this.tbCodePostal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbCourriel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ddlProvince);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbRue);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbVille);
            this.groupBox1.Location = new System.Drawing.Point(316, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 321);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de contact";
            // 
            // tbCellulaire
            // 
            this.tbCellulaire.Location = new System.Drawing.Point(99, 261);
            this.tbCellulaire.Mask = "(999) 000-0000";
            this.tbCellulaire.Name = "tbCellulaire";
            this.tbCellulaire.Size = new System.Drawing.Size(130, 20);
            this.tbCellulaire.TabIndex = 36;
            this.tbCellulaire.TextChanged += new System.EventHandler(this.Valider);
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(99, 236);
            this.tbTelephone.Mask = "(999) 000-0000";
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(130, 20);
            this.tbTelephone.TabIndex = 35;
            this.tbTelephone.TextChanged += new System.EventHandler(this.Valider);
            // 
            // numNoCivique
            // 
            this.numNoCivique.Location = new System.Drawing.Point(99, 49);
            this.numNoCivique.Maximum = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            this.numNoCivique.Name = "numNoCivique";
            this.numNoCivique.Size = new System.Drawing.Size(130, 20);
            this.numNoCivique.TabIndex = 34;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(99, 153);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(130, 20);
            this.tbCodePostal.TabIndex = 33;
            this.tbCodePostal.TextChanged += new System.EventHandler(this.Valider);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Téléphone :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Courriel :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Cellulaire :";
            // 
            // tbCourriel
            // 
            this.tbCourriel.Location = new System.Drawing.Point(99, 288);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(130, 20);
            this.tbCourriel.TabIndex = 31;
            this.tbCourriel.TextChanged += new System.EventHandler(this.Valider);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "No civique :";
            // 
            // ddlProvince
            // 
            this.ddlProvince.DataSource = this.provinceBindingSource;
            this.ddlProvince.DisplayMember = "Nom";
            this.ddlProvince.FormattingEnabled = true;
            this.ddlProvince.Location = new System.Drawing.Point(99, 127);
            this.ddlProvince.Name = "ddlProvince";
            this.ddlProvince.Size = new System.Drawing.Size(130, 21);
            this.ddlProvince.TabIndex = 26;
            this.ddlProvince.ValueMember = "Id";
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(Projet2_5B6.Province);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Province :";
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(99, 75);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(130, 20);
            this.tbRue.TabIndex = 17;
            this.tbRue.TextChanged += new System.EventHandler(this.Valider);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ville :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Code postal :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rue :";
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(99, 101);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(130, 20);
            this.tbVille.TabIndex = 19;
            this.tbVille.TextChanged += new System.EventHandler(this.Valider);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNo);
            this.groupBox2.Controls.Add(this.ddlSexe);
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Controls.Add(this.numAge);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbNom);
            this.groupBox2.Controls.Add(this.Sexe);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbPrenom);
            this.groupBox2.Location = new System.Drawing.Point(17, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 200);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information sur l\'employé";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.ddlTypeEmploye);
            this.groupBox3.Controls.Add(this.tbSalaireHoraire);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(17, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 114);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type d\'emploi";
            // 
            // ddlTypeEmploye
            // 
            this.ddlTypeEmploye.DataSource = this.typesEmployeBindingSource;
            this.ddlTypeEmploye.DisplayMember = "Description";
            this.ddlTypeEmploye.FormattingEnabled = true;
            this.ddlTypeEmploye.Location = new System.Drawing.Point(101, 58);
            this.ddlTypeEmploye.Name = "ddlTypeEmploye";
            this.ddlTypeEmploye.Size = new System.Drawing.Size(130, 21);
            this.ddlTypeEmploye.TabIndex = 37;
            this.ddlTypeEmploye.ValueMember = "No";
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataSource = typeof(Projet2_5B6.TypesEmploye);
            // 
            // tbSalaireHoraire
            // 
            this.tbSalaireHoraire.Location = new System.Drawing.Point(101, 32);
            this.tbSalaireHoraire.Name = "tbSalaireHoraire";
            this.tbSalaireHoraire.Size = new System.Drawing.Size(130, 20);
            this.tbSalaireHoraire.TabIndex = 34;
            this.tbSalaireHoraire.TextChanged += new System.EventHandler(this.Valider);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Type d\'employé :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Salaire horraire:";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(118, 376);
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(246, 62);
            this.tbRemarque.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 383);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Remarque :";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Enabled = false;
            this.btnConfirmer.Location = new System.Drawing.Point(389, 376);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(190, 30);
            this.btnConfirmer.TabIndex = 20;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(389, 408);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(190, 30);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(237, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(237, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(237, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(237, 141);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(237, 167);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(237, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(11, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(237, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(11, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(235, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "*";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(235, 78);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(11, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "*";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(235, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(11, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(235, 130);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(11, 13);
            this.label28.TabIndex = 42;
            this.label28.Text = "*";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(235, 156);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(11, 13);
            this.label29.TabIndex = 43;
            this.label29.Text = "*";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(235, 239);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(11, 13);
            this.label30.TabIndex = 44;
            this.label30.Text = "*";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(235, 291);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(11, 13);
            this.label31.TabIndex = 45;
            this.label31.Text = "*";
            // 
            // FrmAjoutEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAjoutEmployes";
            this.Text = "Ajout d\'un employé";
            this.Load += new System.EventHandler(this.FrmAjoutEmployes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCivique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Sexe;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox ddlSexe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlProvince;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ddlTypeEmploye;
        private System.Windows.Forms.TextBox tbSalaireHoraire;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numNoCivique;
        private System.Windows.Forms.MaskedTextBox tbCellulaire;
        private System.Windows.Forms.MaskedTextBox tbTelephone;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}