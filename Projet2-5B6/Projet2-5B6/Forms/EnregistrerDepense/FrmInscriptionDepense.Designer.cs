namespace Projet2_5B6.Forms.EnregistrerDepense
{
    partial class FrmInscriptionDepense
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
            this.idEtNomCompletAboDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMontant = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlTypeDepense = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblErrorProvider = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.dataGridViewTbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCompletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEtNomCompletAboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idEtNomCompletAboDataGridView
            // 
            this.idEtNomCompletAboDataGridView.AllowUserToAddRows = false;
            this.idEtNomCompletAboDataGridView.AllowUserToDeleteRows = false;
            this.idEtNomCompletAboDataGridView.AutoGenerateColumns = false;
            this.idEtNomCompletAboDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idEtNomCompletAboDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTbId,
            this.nomCompletDataGridViewTextBoxColumn});
            this.idEtNomCompletAboDataGridView.DataSource = this.idEtNomCompletAboBindingSource;
            this.idEtNomCompletAboDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.idEtNomCompletAboDataGridView.Location = new System.Drawing.Point(13, 107);
            this.idEtNomCompletAboDataGridView.MultiSelect = false;
            this.idEtNomCompletAboDataGridView.Name = "idEtNomCompletAboDataGridView";
            this.idEtNomCompletAboDataGridView.ReadOnly = true;
            this.idEtNomCompletAboDataGridView.RowHeadersVisible = false;
            this.idEtNomCompletAboDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idEtNomCompletAboDataGridView.Size = new System.Drawing.Size(365, 264);
            this.idEtNomCompletAboDataGridView.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liste des abonnements encore valide";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Inscription d\'une dépense";
            // 
            // numMontant
            // 
            this.numMontant.DecimalPlaces = 2;
            this.numMontant.Location = new System.Drawing.Point(101, 34);
            this.numMontant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMontant.Name = "numMontant";
            this.numMontant.Size = new System.Drawing.Size(132, 20);
            this.numMontant.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Montant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Type de service :";
            // 
            // ddlTypeDepense
            // 
            this.ddlTypeDepense.FormattingEnabled = true;
            this.ddlTypeDepense.Location = new System.Drawing.Point(101, 73);
            this.ddlTypeDepense.Name = "ddlTypeDepense";
            this.ddlTypeDepense.Size = new System.Drawing.Size(147, 21);
            this.ddlTypeDepense.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRemarque);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numMontant);
            this.groupBox1.Controls.Add(this.ddlTypeDepense);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(407, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 193);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information sur la dépense";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(496, 306);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(116, 37);
            this.btnConfirmer.TabIndex = 22;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lblErrorProvider
            // 
            this.lblErrorProvider.AutoSize = true;
            this.lblErrorProvider.Location = new System.Drawing.Point(404, 358);
            this.lblErrorProvider.Name = "lblErrorProvider";
            this.lblErrorProvider.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProvider.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Remarque :";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(101, 124);
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(150, 51);
            this.tbRemarque.TabIndex = 22;
            // 
            // dataGridViewTbId
            // 
            this.dataGridViewTbId.DataPropertyName = "id";
            this.dataGridViewTbId.HeaderText = "id";
            this.dataGridViewTbId.Name = "dataGridViewTbId";
            this.dataGridViewTbId.ReadOnly = true;
            this.dataGridViewTbId.Width = 150;
            // 
            // nomCompletDataGridViewTextBoxColumn
            // 
            this.nomCompletDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomCompletDataGridViewTextBoxColumn.DataPropertyName = "nomComplet";
            this.nomCompletDataGridViewTextBoxColumn.HeaderText = "nomComplet";
            this.nomCompletDataGridViewTextBoxColumn.Name = "nomCompletDataGridViewTextBoxColumn";
            this.nomCompletDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEtNomCompletAboBindingSource
            // 
            this.idEtNomCompletAboBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.IdEtNomCompletAbo);
            // 
            // FrmInscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.lblErrorProvider);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idEtNomCompletAboDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "FrmInscriptionDepense";
            this.Text = "Inscription d\'une dépense";
            this.Load += new System.EventHandler(this.FrmInscriptionDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idEtNomCompletAboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView idEtNomCompletAboDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource idEtNomCompletAboBindingSource;
        private System.Windows.Forms.NumericUpDown numMontant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlTypeDepense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblErrorProvider;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompletDataGridViewTextBoxColumn;
    }
}