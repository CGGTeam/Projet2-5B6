namespace Projet2_5B6.Forms.ModifPrix
{
    partial class FrmModifPrix
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAbonnementPrixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrorProvider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeAbonnementPrixBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.anneeDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.depenseDataGridViewTextBoxColumn,
            this.remarqueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.typeAbonnementPrixBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(797, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No type d\'abonnement";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.Width = 75;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // depenseDataGridViewTextBoxColumn
            // 
            this.depenseDataGridViewTextBoxColumn.DataPropertyName = "Depense";
            this.depenseDataGridViewTextBoxColumn.HeaderText = "Depense";
            this.depenseDataGridViewTextBoxColumn.Name = "depenseDataGridViewTextBoxColumn";
            // 
            // remarqueDataGridViewTextBoxColumn
            // 
            this.remarqueDataGridViewTextBoxColumn.DataPropertyName = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.HeaderText = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.Name = "remarqueDataGridViewTextBoxColumn";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(1, 312);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(115, 33);
            this.btnConfirmer.TabIndex = 1;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des type d\'abonnements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "vous pouvez modifier les prix des cases en rose et cliquer sur le bouton confirme" +
    "r à la toute fin";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblErrorProvider
            // 
            this.lblErrorProvider.AutoSize = true;
            this.lblErrorProvider.Location = new System.Drawing.Point(123, 313);
            this.lblErrorProvider.Name = "lblErrorProvider";
            this.lblErrorProvider.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProvider.TabIndex = 4;
            // 
            // FrmModifPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.lblErrorProvider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmModifPrix";
            this.Text = "Modification d’un prix et des dépenses obligatoires";
            this.Load += new System.EventHandler(this.FrmModifPrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeAbonnementPrixBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource typeAbonnementPrixBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErrorProvider;
    }
}