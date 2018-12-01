namespace Projet2_5B6.Forms.DiversRapports
{
   partial class FrmRapports
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
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
         this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
         this.ObjetDepensesParAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.ObjetDepensesParAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.ObjetDepensesParAbonnementBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.ObjetDepensesParAnneeBindingSource)).BeginInit();
         this.tabPage3.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Controls.Add(this.tabPage3);
         this.tabControl1.Location = new System.Drawing.Point(3, 29);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(1423, 593);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.reportViewer1);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(1415, 567);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "DepensesParEmploye";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.reportViewer2);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(1415, 567);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Dépenses par abonnement";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // reportViewer1
         // 
         this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
         reportDataSource1.Name = "DataSet1";
         reportDataSource1.Value = this.ObjetDepensesParAbonnementBindingSource;
         this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
         this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projet2_5B6.AssistantsRapport.DepensesParEmploye.rdlc";
         this.reportViewer1.Location = new System.Drawing.Point(3, 3);
         this.reportViewer1.Name = "reportViewer1";
         this.reportViewer1.ServerReport.BearerToken = null;
         this.reportViewer1.Size = new System.Drawing.Size(1409, 561);
         this.reportViewer1.TabIndex = 0;
         // 
         // reportViewer2
         // 
         this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
         reportDataSource2.Name = "DataSet1";
         reportDataSource2.Value = this.ObjetDepensesParAbonnementBindingSource;
         this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
         this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projet2_5B6.AssistantsRapport.DepensesParAbonnement.rdlc";
         this.reportViewer2.Location = new System.Drawing.Point(3, 3);
         this.reportViewer2.Name = "reportViewer2";
         this.reportViewer2.ServerReport.BearerToken = null;
         this.reportViewer2.Size = new System.Drawing.Size(1409, 561);
         this.reportViewer2.TabIndex = 0;
         // 
         // ObjetDepensesParAbonnementBindingSource
         // 
         this.ObjetDepensesParAbonnementBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.ObjetDepensesParAbonnement);
         // 
         // ObjetDepensesParAnneeBindingSource
         // 
         this.ObjetDepensesParAnneeBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.ObjetDepensesParAnnee);
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.reportViewer3);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage3.Size = new System.Drawing.Size(1415, 567);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Dépenses par année";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // reportViewer3
         // 
         this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
         reportDataSource3.Name = "DataSet1";
         reportDataSource3.Value = this.ObjetDepensesParAnneeBindingSource;
         this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
         this.reportViewer3.LocalReport.ReportEmbeddedResource = "Projet2_5B6.AssistantsRapport.DepensesParAnnee.rdlc";
         this.reportViewer3.Location = new System.Drawing.Point(3, 3);
         this.reportViewer3.Name = "reportViewer3";
         this.reportViewer3.ServerReport.BearerToken = null;
         this.reportViewer3.Size = new System.Drawing.Size(1409, 561);
         this.reportViewer3.TabIndex = 0;
         // 
         // FrmRapports
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1427, 623);
         this.Controls.Add(this.tabControl1);
         this.Name = "FrmRapports";
         this.Text = "FrmRapports";
         this.Load += new System.EventHandler(this.FrmRapports_Load);
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.ObjetDepensesParAbonnementBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.ObjetDepensesParAnneeBindingSource)).EndInit();
         this.tabPage3.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
      private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
      private System.Windows.Forms.BindingSource ObjetDepensesParAbonnementBindingSource;
      private System.Windows.Forms.BindingSource ObjetDepensesParAnneeBindingSource;
      private System.Windows.Forms.TabPage tabPage3;
      private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
   }
}