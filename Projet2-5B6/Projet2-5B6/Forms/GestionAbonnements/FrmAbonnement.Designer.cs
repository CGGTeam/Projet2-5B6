namespace Projet2_5B6.Forms.GestionAbonnements
{
   partial class FrmAbonnement
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.btnSelection = new System.Windows.Forms.Button();
         this.lblInformations = new System.Windows.Forms.Label();
         this.lblTitre = new System.Windows.Forms.Label();
         this.infosAbonnementsDetaillesDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.infosAbonnementsDetaillesBindingSource = new System.Windows.Forms.BindingSource(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.infosAbonnementsDetaillesDataGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.infosAbonnementsDetaillesBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // btnSelection
         // 
         this.btnSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSelection.Location = new System.Drawing.Point(24, 336);
         this.btnSelection.Name = "btnSelection";
         this.btnSelection.Size = new System.Drawing.Size(240, 30);
         this.btnSelection.TabIndex = 8;
         this.btnSelection.Text = "Sélectionner cet abonnement";
         this.btnSelection.UseVisualStyleBackColor = true;
         this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
         // 
         // lblInformations
         // 
         this.lblInformations.AutoSize = true;
         this.lblInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInformations.Location = new System.Drawing.Point(21, 115);
         this.lblInformations.Name = "lblInformations";
         this.lblInformations.Size = new System.Drawing.Size(325, 17);
         this.lblInformations.TabIndex = 7;
         this.lblInformations.Text = "Veuillez sélectionner un type d\'abonnement";
         // 
         // lblTitre
         // 
         this.lblTitre.AutoSize = true;
         this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitre.Location = new System.Drawing.Point(21, 53);
         this.lblTitre.Name = "lblTitre";
         this.lblTitre.Size = new System.Drawing.Size(286, 36);
         this.lblTitre.TabIndex = 6;
         this.lblTitre.Text = "Nouvel Abonnement";
         // 
         // infosAbonnementsDetaillesDataGridView
         // 
         this.infosAbonnementsDetaillesDataGridView.AllowUserToAddRows = false;
         this.infosAbonnementsDetaillesDataGridView.AllowUserToDeleteRows = false;
         this.infosAbonnementsDetaillesDataGridView.AllowUserToOrderColumns = true;
         this.infosAbonnementsDetaillesDataGridView.AllowUserToResizeColumns = false;
         this.infosAbonnementsDetaillesDataGridView.AllowUserToResizeRows = false;
         this.infosAbonnementsDetaillesDataGridView.AutoGenerateColumns = false;
         this.infosAbonnementsDetaillesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.infosAbonnementsDetaillesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
         this.infosAbonnementsDetaillesDataGridView.DataSource = this.infosAbonnementsDetaillesBindingSource;
         this.infosAbonnementsDetaillesDataGridView.Location = new System.Drawing.Point(24, 135);
         this.infosAbonnementsDetaillesDataGridView.MultiSelect = false;
         this.infosAbonnementsDetaillesDataGridView.Name = "infosAbonnementsDetaillesDataGridView";
         this.infosAbonnementsDetaillesDataGridView.ReadOnly = true;
         this.infosAbonnementsDetaillesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.infosAbonnementsDetaillesDataGridView.Size = new System.Drawing.Size(545, 195);
         this.infosAbonnementsDetaillesDataGridView.TabIndex = 9;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "noTypeAbonnement";
         this.dataGridViewTextBoxColumn1.HeaderText = "Numéro";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         this.dataGridViewTextBoxColumn1.Width = 50;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "descriptionAbonnement";
         this.dataGridViewTextBoxColumn2.HeaderText = "Type d\'abonnement";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         this.dataGridViewTextBoxColumn2.ReadOnly = true;
         this.dataGridViewTextBoxColumn2.Width = 150;
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "prix";
         dataGridViewCellStyle1.Format = "C2";
         dataGridViewCellStyle1.NullValue = "0";
         this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         this.dataGridViewTextBoxColumn3.ReadOnly = true;
         this.dataGridViewTextBoxColumn3.Width = 150;
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "depenseObligatoire";
         dataGridViewCellStyle2.Format = "C2";
         dataGridViewCellStyle2.NullValue = "0";
         this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
         this.dataGridViewTextBoxColumn4.HeaderText = "Dépenses obligatoires";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         this.dataGridViewTextBoxColumn4.ReadOnly = true;
         this.dataGridViewTextBoxColumn4.Width = 150;
         // 
         // infosAbonnementsDetaillesBindingSource
         // 
         this.infosAbonnementsDetaillesBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.InfosAbonnementsDetailles);
         // 
         // FrmAbonnement
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 519);
         this.Controls.Add(this.infosAbonnementsDetaillesDataGridView);
         this.Controls.Add(this.btnSelection);
         this.Controls.Add(this.lblInformations);
         this.Controls.Add(this.lblTitre);
         this.Name = "FrmAbonnement";
         this.Text = "Gestion des abonnements";
         this.Load += new System.EventHandler(this.FrmAbonnement_Load);
         ((System.ComponentModel.ISupportInitialize)(this.infosAbonnementsDetaillesDataGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.infosAbonnementsDetaillesBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnSelection;
      private System.Windows.Forms.Label lblInformations;
      private System.Windows.Forms.Label lblTitre;
      private System.Windows.Forms.BindingSource infosAbonnementsDetaillesBindingSource;
      private System.Windows.Forms.DataGridView infosAbonnementsDetaillesDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
   }
}