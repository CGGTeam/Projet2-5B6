namespace Projet2_5B6
{
    partial class BaseForm
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
         this.menuBar = new System.Windows.Forms.MenuStrip();
         this.menuOption = new System.Windows.Forms.ToolStripMenuItem();
         this.gestionDesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.gestionDesAbonnementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.miseÀJourDesAbonnésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.gestionDesRéabonnementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.inscriptionDunePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.visualiserLesRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.visualiserLesStatistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuBar.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuBar
         // 
         this.menuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
         this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOption,
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
         this.menuBar.Location = new System.Drawing.Point(0, 0);
         this.menuBar.Name = "menuBar";
         this.menuBar.Size = new System.Drawing.Size(800, 24);
         this.menuBar.TabIndex = 0;
         this.menuBar.Text = "PLACEHOLDER";
         // 
         // menuOption
         // 
         this.menuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEmployésToolStripMenuItem,
            this.gestionDesAbonnementsToolStripMenuItem,
            this.miseÀJourDesAbonnésToolStripMenuItem,
            this.modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem,
            this.gestionDesRéabonnementsToolStripMenuItem,
            this.inscriptionDunePartieToolStripMenuItem,
            this.visualiserLesRapportsToolStripMenuItem,
            this.visualiserLesStatistiquesToolStripMenuItem});
         this.menuOption.Name = "menuOption";
         this.menuOption.Size = new System.Drawing.Size(50, 20);
         this.menuOption.Text = "Menu";
         // 
         // gestionDesEmployésToolStripMenuItem
         // 
         this.gestionDesEmployésToolStripMenuItem.Name = "gestionDesEmployésToolStripMenuItem";
         this.gestionDesEmployésToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
         this.gestionDesEmployésToolStripMenuItem.Text = "Gestion des employés";
         this.gestionDesEmployésToolStripMenuItem.Click += new System.EventHandler(this.gestionDesEmployésToolStripMenuItem_Click);
         // 
         // gestionDesAbonnementsToolStripMenuItem
         // 
         this.gestionDesAbonnementsToolStripMenuItem.Name = "gestionDesAbonnementsToolStripMenuItem";
         this.gestionDesAbonnementsToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
         this.gestionDesAbonnementsToolStripMenuItem.Text = "Gestion des abonnements";
         this.gestionDesAbonnementsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesAbonnementsToolStripMenuItem_Click);
         // 
         // miseÀJourDesAbonnésToolStripMenuItem
         // 
         this.miseÀJourDesAbonnésToolStripMenuItem.Name = "miseÀJourDesAbonnésToolStripMenuItem";
         this.miseÀJourDesAbonnésToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
         this.miseÀJourDesAbonnésToolStripMenuItem.Text = "Mise à jour des abonnés";
         this.miseÀJourDesAbonnésToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourDesAbonnésToolStripMenuItem_Click);
         // 
         // modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem
         // 
         this.modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem.Name = "modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem";
         this.modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
         this.modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem.Text = "Modification d’un prix et des dépenses obligatoires";
         this.modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem.Click += new System.EventHandler(this.modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem_Click);
         // 
         // gestionDesRéabonnementsToolStripMenuItem
         // 
         this.gestionDesRéabonnementsToolStripMenuItem.Name = "gestionDesRéabonnementsToolStripMenuItem";
         this.gestionDesRéabonnementsToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
         this.gestionDesRéabonnementsToolStripMenuItem.Text = "Gestion des réabonnements";
         this.gestionDesRéabonnementsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesRéabonnementsToolStripMenuItem_Click);
         // 
         // inscriptionDunePartieToolStripMenuItem
         // 
         this.inscriptionDunePartieToolStripMenuItem.Name = "inscriptionDunePartieToolStripMenuItem";
         this.inscriptionDunePartieToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
         this.inscriptionDunePartieToolStripMenuItem.Text = "Inscription d\'une partie";
         this.inscriptionDunePartieToolStripMenuItem.Click += new System.EventHandler(this.inscriptionDunePartieToolStripMenuItem_Click);
         // 
         // visualiserLesRapportsToolStripMenuItem
         // 
         this.visualiserLesRapportsToolStripMenuItem.Name = "visualiserLesRapportsToolStripMenuItem";
         this.visualiserLesRapportsToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
         this.visualiserLesRapportsToolStripMenuItem.Text = "Visualiser les rapports";
         this.visualiserLesRapportsToolStripMenuItem.Click += new System.EventHandler(this.visualiserLesRapportsToolStripMenuItem_Click);
         // 
         // déconnexionToolStripMenuItem
         // 
         this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
         this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
         this.déconnexionToolStripMenuItem.Text = "Déconnexion";
         this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
         // 
         // quitterToolStripMenuItem
         // 
         this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
         this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
         this.quitterToolStripMenuItem.Text = "Quitter";
         this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
         // 
         // visualiserLesStatistiquesToolStripMenuItem
         // 
         this.visualiserLesStatistiquesToolStripMenuItem.Name = "visualiserLesStatistiquesToolStripMenuItem";
         this.visualiserLesStatistiquesToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
         this.visualiserLesStatistiquesToolStripMenuItem.Text = "Visualiser les statistiques";
         this.visualiserLesStatistiquesToolStripMenuItem.Click += new System.EventHandler(this.visualiserLesStatistiquesToolStripMenuItem_Click);
         // 
         // BaseForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.menuBar);
         this.MainMenuStrip = this.menuBar;
         this.Name = "BaseForm";
         this.Text = "BaseForm";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confirmationClosing);
         this.Load += new System.EventHandler(this.BaseForm_Load);
         this.menuBar.ResumeLayout(false);
         this.menuBar.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuOption;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesAbonnementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourDesAbonnésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDunPrixEtDesDépensesObligatoiresToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem gestionDesRéabonnementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionDunePartieToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem visualiserLesRapportsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem visualiserLesStatistiquesToolStripMenuItem;
   }
}