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
            this.placeholderMenu = new System.Windows.Forms.MenuStrip();
            this.pLACEHOLDERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeholderMenu
            // 
            this.placeholderMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.placeholderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLACEHOLDERToolStripMenuItem1,
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.placeholderMenu.Location = new System.Drawing.Point(0, 0);
            this.placeholderMenu.Name = "placeholderMenu";
            this.placeholderMenu.Size = new System.Drawing.Size(800, 24);
            this.placeholderMenu.TabIndex = 0;
            this.placeholderMenu.Text = "PLACEHOLDER";
            // 
            // pLACEHOLDERToolStripMenuItem1
            // 
            this.pLACEHOLDERToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEmployésToolStripMenuItem});
            this.pLACEHOLDERToolStripMenuItem1.Name = "pLACEHOLDERToolStripMenuItem1";
            this.pLACEHOLDERToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.pLACEHOLDERToolStripMenuItem1.Text = "Menu";
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
            // gestionDesEmployésToolStripMenuItem
            // 
            this.gestionDesEmployésToolStripMenuItem.Name = "gestionDesEmployésToolStripMenuItem";
            this.gestionDesEmployésToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionDesEmployésToolStripMenuItem.Text = "Gestion des employés";
            this.gestionDesEmployésToolStripMenuItem.Click += new System.EventHandler(this.gestionDesEmployésToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.placeholderMenu);
            this.MainMenuStrip = this.placeholderMenu;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confirmationClosing);
            this.placeholderMenu.ResumeLayout(false);
            this.placeholderMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip placeholderMenu;
        private System.Windows.Forms.ToolStripMenuItem pLACEHOLDERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEmployésToolStripMenuItem;
    }
}