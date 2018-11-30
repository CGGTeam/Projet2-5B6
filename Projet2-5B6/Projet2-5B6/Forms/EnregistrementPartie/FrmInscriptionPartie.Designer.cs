namespace Projet2_5B6.Forms.EnregistrementPartie
{
    partial class FrmInscriptionPartie
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstTerrains = new System.Windows.Forms.ListBox();
            this.terrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPartie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numPoint = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idEtNomCompletAboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idEtNomCompletAboDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblErrorProvider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des abonnements encore valide";
            // 
            // lstTerrains
            // 
            this.lstTerrains.DataSource = this.terrainBindingSource;
            this.lstTerrains.DisplayMember = "Nom";
            this.lstTerrains.FormattingEnabled = true;
            this.lstTerrains.Location = new System.Drawing.Point(402, 111);
            this.lstTerrains.Name = "lstTerrains";
            this.lstTerrains.Size = new System.Drawing.Size(203, 342);
            this.lstTerrains.TabIndex = 3;
            this.lstTerrains.ValueMember = "No";
            // 
            // terrainBindingSource
            // 
            this.terrainBindingSource.DataSource = typeof(Projet2_5B6.Terrain);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des terrains";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inscription d\'une partie";
            // 
            // tbPartie
            // 
            this.tbPartie.Location = new System.Drawing.Point(80, 111);
            this.tbPartie.Multiline = true;
            this.tbPartie.Name = "tbPartie";
            this.tbPartie.Size = new System.Drawing.Size(163, 104);
            this.tbPartie.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "pointage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "remarque :";
            // 
            // numPoint
            // 
            this.numPoint.Location = new System.Drawing.Point(80, 39);
            this.numPoint.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numPoint.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numPoint.Name = "numPoint";
            this.numPoint.Size = new System.Drawing.Size(162, 20);
            this.numPoint.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPartie);
            this.groupBox1.Controls.Add(this.numPoint);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(624, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 260);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information sur la partie";
            // 
            // idEtNomCompletAboBindingSource
            // 
            this.idEtNomCompletAboBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.IdEtNomCompletAbo);
            // 
            // idEtNomCompletAboDataGridView
            // 
            this.idEtNomCompletAboDataGridView.AllowUserToAddRows = false;
            this.idEtNomCompletAboDataGridView.AllowUserToDeleteRows = false;
            this.idEtNomCompletAboDataGridView.AutoGenerateColumns = false;
            this.idEtNomCompletAboDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idEtNomCompletAboDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.idEtNomCompletAboDataGridView.DataSource = this.idEtNomCompletAboBindingSource;
            this.idEtNomCompletAboDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.idEtNomCompletAboDataGridView.Location = new System.Drawing.Point(12, 101);
            this.idEtNomCompletAboDataGridView.MultiSelect = false;
            this.idEtNomCompletAboDataGridView.Name = "idEtNomCompletAboDataGridView";
            this.idEtNomCompletAboDataGridView.ReadOnly = true;
            this.idEtNomCompletAboDataGridView.RowHeadersVisible = false;
            this.idEtNomCompletAboDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idEtNomCompletAboDataGridView.Size = new System.Drawing.Size(365, 352);
            this.idEtNomCompletAboDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomComplet";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomComplet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(663, 377);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(164, 43);
            this.btnConfirmer.TabIndex = 12;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lblErrorProvider
            // 
            this.lblErrorProvider.AutoSize = true;
            this.lblErrorProvider.Location = new System.Drawing.Point(635, 439);
            this.lblErrorProvider.Name = "lblErrorProvider";
            this.lblErrorProvider.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProvider.TabIndex = 13;
            // 
            // FrmInscriptionPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 489);
            this.Controls.Add(this.lblErrorProvider);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.idEtNomCompletAboDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTerrains);
            this.Controls.Add(this.label1);
            this.Name = "FrmInscriptionPartie";
            this.Text = "Inscription d\'une partie de golf jouée";
            this.Load += new System.EventHandler(this.FrmInscriptionPartie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTerrains;
        private System.Windows.Forms.BindingSource terrainBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPartie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource idEtNomCompletAboBindingSource;
        private System.Windows.Forms.DataGridView idEtNomCompletAboDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblErrorProvider;
    }
}