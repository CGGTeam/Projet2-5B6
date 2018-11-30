namespace Projet2_5B6.Forms.GestionReabonnement
{
   partial class FrmReabonnement
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
         this.lblInformations = new System.Windows.Forms.Label();
         this.lblTitre = new System.Windows.Forms.Label();
         this.idEtNomCompletAboBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.idEtNomCompletAboDataGridView = new System.Windows.Forms.DataGridView();
         this.gbAbonne = new System.Windows.Forms.GroupBox();
         this.label1 = new System.Windows.Forms.Label();
         this.lblNomAbo = new System.Windows.Forms.Label();
         this.tbRemarque = new System.Windows.Forms.TextBox();
         this.btnRenouveler = new System.Windows.Forms.Button();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.label2 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboDataGridView)).BeginInit();
         this.gbAbonne.SuspendLayout();
         this.SuspendLayout();
         // 
         // lblInformations
         // 
         this.lblInformations.AutoSize = true;
         this.lblInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInformations.Location = new System.Drawing.Point(15, 105);
         this.lblInformations.Name = "lblInformations";
         this.lblInformations.Size = new System.Drawing.Size(313, 17);
         this.lblInformations.TabIndex = 9;
         this.lblInformations.Text = "Sélectionner un abonnement à renouveler";
         // 
         // lblTitre
         // 
         this.lblTitre.AutoSize = true;
         this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitre.Location = new System.Drawing.Point(12, 55);
         this.lblTitre.Name = "lblTitre";
         this.lblTitre.Size = new System.Drawing.Size(395, 36);
         this.lblTitre.TabIndex = 8;
         this.lblTitre.Text = "Formulaire de réabonnement";
         // 
         // idEtNomCompletAboBindingSource
         // 
         this.idEtNomCompletAboBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.IdEtNomCompletAbo);
         // 
         // idEtNomCompletAboDataGridView
         // 
         this.idEtNomCompletAboDataGridView.AllowUserToAddRows = false;
         this.idEtNomCompletAboDataGridView.AllowUserToDeleteRows = false;
         this.idEtNomCompletAboDataGridView.AllowUserToOrderColumns = true;
         this.idEtNomCompletAboDataGridView.AllowUserToResizeColumns = false;
         this.idEtNomCompletAboDataGridView.AllowUserToResizeRows = false;
         this.idEtNomCompletAboDataGridView.AutoGenerateColumns = false;
         this.idEtNomCompletAboDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.idEtNomCompletAboDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
         this.idEtNomCompletAboDataGridView.DataSource = this.idEtNomCompletAboBindingSource;
         this.idEtNomCompletAboDataGridView.Location = new System.Drawing.Point(18, 136);
         this.idEtNomCompletAboDataGridView.Name = "idEtNomCompletAboDataGridView";
         this.idEtNomCompletAboDataGridView.ReadOnly = true;
         this.idEtNomCompletAboDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.idEtNomCompletAboDataGridView.Size = new System.Drawing.Size(295, 259);
         this.idEtNomCompletAboDataGridView.TabIndex = 10;
         this.idEtNomCompletAboDataGridView.SelectionChanged += new System.EventHandler(this.idEtNomCompletAboDataGridView_SelectionChanged);
         // 
         // gbAbonne
         // 
         this.gbAbonne.Controls.Add(this.label2);
         this.gbAbonne.Controls.Add(this.btnRenouveler);
         this.gbAbonne.Controls.Add(this.tbRemarque);
         this.gbAbonne.Controls.Add(this.lblNomAbo);
         this.gbAbonne.Controls.Add(this.label1);
         this.gbAbonne.Location = new System.Drawing.Point(332, 128);
         this.gbAbonne.Name = "gbAbonne";
         this.gbAbonne.Size = new System.Drawing.Size(453, 267);
         this.gbAbonne.TabIndex = 11;
         this.gbAbonne.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(6, 16);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(306, 22);
         this.label1.TabIndex = 12;
         this.label1.Text = "Renouvellement de l\'abonnement de ";
         // 
         // lblNomAbo
         // 
         this.lblNomAbo.AutoSize = true;
         this.lblNomAbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNomAbo.Location = new System.Drawing.Point(303, 16);
         this.lblNomAbo.Name = "lblNomAbo";
         this.lblNomAbo.Size = new System.Drawing.Size(47, 22);
         this.lblNomAbo.TabIndex = 13;
         this.lblNomAbo.Text = "Nom";
         // 
         // tbRemarque
         // 
         this.tbRemarque.Location = new System.Drawing.Point(10, 66);
         this.tbRemarque.MaxLength = 100;
         this.tbRemarque.Multiline = true;
         this.tbRemarque.Name = "tbRemarque";
         this.tbRemarque.Size = new System.Drawing.Size(437, 158);
         this.tbRemarque.TabIndex = 14;
         // 
         // btnRenouveler
         // 
         this.btnRenouveler.Location = new System.Drawing.Point(10, 230);
         this.btnRenouveler.Name = "btnRenouveler";
         this.btnRenouveler.Size = new System.Drawing.Size(168, 31);
         this.btnRenouveler.TabIndex = 15;
         this.btnRenouveler.Text = "Renouveler l\'abonnement";
         this.btnRenouveler.UseVisualStyleBackColor = true;
         this.btnRenouveler.Click += new System.EventHandler(this.btnRenouveler_Click);
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
         this.dataGridViewTextBoxColumn1.HeaderText = "Id";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "nomComplet";
         this.dataGridViewTextBoxColumn2.HeaderText = "Nom complet";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         this.dataGridViewTextBoxColumn2.ReadOnly = true;
         this.dataGridViewTextBoxColumn2.Width = 150;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(7, 46);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(97, 17);
         this.label2.TabIndex = 12;
         this.label2.Text = "Remarque...";
         // 
         // FrmReabonnement
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(835, 484);
         this.Controls.Add(this.gbAbonne);
         this.Controls.Add(this.idEtNomCompletAboDataGridView);
         this.Controls.Add(this.lblInformations);
         this.Controls.Add(this.lblTitre);
         this.Name = "FrmReabonnement";
         this.Text = "FrmReabonnement";
         this.Load += new System.EventHandler(this.FrmReabonnement_Load);
         ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboDataGridView)).EndInit();
         this.gbAbonne.ResumeLayout(false);
         this.gbAbonne.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblInformations;
      private System.Windows.Forms.Label lblTitre;
      private System.Windows.Forms.BindingSource idEtNomCompletAboBindingSource;
      private System.Windows.Forms.DataGridView idEtNomCompletAboDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.GroupBox gbAbonne;
      private System.Windows.Forms.Button btnRenouveler;
      private System.Windows.Forms.TextBox tbRemarque;
      private System.Windows.Forms.Label lblNomAbo;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
   }
}