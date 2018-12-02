﻿namespace Projet2_5B6.Forms.DiversStatistiques
{
   partial class FrmStatistiques
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
         this.ObjetAbonnementsParAnneeEtParTypeAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.ObjetAbonnementsMoiAnneeCouranteBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
         this.ObjetPartiesJoueesParAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.ObjetAbonnementsParAnneeEtParTypeAbonnementBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.ObjetAbonnementsMoiAnneeCouranteBindingSource)).BeginInit();
         this.tabPage3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.ObjetPartiesJoueesParAnneeBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Controls.Add(this.tabPage3);
         this.tabControl1.Location = new System.Drawing.Point(0, 30);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(1513, 623);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.reportViewer1);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(1505, 597);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Abonnements par année et par type d\'abonnement";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.reportViewer2);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(1505, 597);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Abonnement par mois de l\'année courante et par type d\'abonnement";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // reportViewer1
         // 
         this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
         reportDataSource1.Name = "DataSet1";
         reportDataSource1.Value = this.ObjetAbonnementsParAnneeEtParTypeAbonnementBindingSource;
         this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
         this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projet2_5B6.AssistantsRapportStatistiques.AbonnementsParAnneeEtTypeAbonnement.rdl" +
    "c";
         this.reportViewer1.Location = new System.Drawing.Point(3, 3);
         this.reportViewer1.Name = "reportViewer1";
         this.reportViewer1.ServerReport.BearerToken = null;
         this.reportViewer1.Size = new System.Drawing.Size(1499, 591);
         this.reportViewer1.TabIndex = 0;
         // 
         // reportViewer2
         // 
         this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
         reportDataSource2.Name = "DataSet1";
         reportDataSource2.Value = this.ObjetAbonnementsMoiAnneeCouranteBindingSource;
         this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
         this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projet2_5B6.AssistantsRapportStatistiques.AbonnementsParMoisAnneeCourante.rdlc";
         this.reportViewer2.Location = new System.Drawing.Point(3, 3);
         this.reportViewer2.Name = "reportViewer2";
         this.reportViewer2.ServerReport.BearerToken = null;
         this.reportViewer2.Size = new System.Drawing.Size(1499, 591);
         this.reportViewer2.TabIndex = 0;
         // 
         // ObjetAbonnementsParAnneeEtParTypeAbonnementBindingSource
         // 
         this.ObjetAbonnementsParAnneeEtParTypeAbonnementBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.ObjetAbonnementsParAnneeEtParTypeAbonnement);
         // 
         // ObjetAbonnementsMoiAnneeCouranteBindingSource
         // 
         this.ObjetAbonnementsMoiAnneeCouranteBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.ObjetAbonnementsMoiAnneeCourante);
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.reportViewer3);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage3.Size = new System.Drawing.Size(1505, 597);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Parties jouées par année et par terrain";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // reportViewer3
         // 
         this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
         reportDataSource3.Name = "DataSet1";
         reportDataSource3.Value = this.ObjetPartiesJoueesParAnneeBindingSource;
         this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
         this.reportViewer3.LocalReport.ReportEmbeddedResource = "Projet2_5B6.AssistantsRapportStatistiques.PartiesJoueesParAnneeEtTerrain.rdlc";
         this.reportViewer3.Location = new System.Drawing.Point(3, 3);
         this.reportViewer3.Name = "reportViewer3";
         this.reportViewer3.ServerReport.BearerToken = null;
         this.reportViewer3.Size = new System.Drawing.Size(1499, 591);
         this.reportViewer3.TabIndex = 0;
         // 
         // ObjetPartiesJoueesParAnneeBindingSource
         // 
         this.ObjetPartiesJoueesParAnneeBindingSource.DataSource = typeof(Projet2_5B6.ObjetsLINQ.ObjetPartiesJoueesParAnnee);
         // 
         // FrmStatistiques
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1514, 650);
         this.Controls.Add(this.tabControl1);
         this.Name = "FrmStatistiques";
         this.Text = "FrmStatistiques";
         this.Load += new System.EventHandler(this.FrmStatistiques_Load);
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.ObjetAbonnementsParAnneeEtParTypeAbonnementBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.ObjetAbonnementsMoiAnneeCouranteBindingSource)).EndInit();
         this.tabPage3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.ObjetPartiesJoueesParAnneeBindingSource)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
      private System.Windows.Forms.BindingSource ObjetAbonnementsParAnneeEtParTypeAbonnementBindingSource;
      private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
      private System.Windows.Forms.BindingSource ObjetAbonnementsMoiAnneeCouranteBindingSource;
      private System.Windows.Forms.TabPage tabPage3;
      private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
      private System.Windows.Forms.BindingSource ObjetPartiesJoueesParAnneeBindingSource;
   }
}