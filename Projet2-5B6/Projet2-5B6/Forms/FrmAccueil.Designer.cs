namespace Projet2_5B6.Forms
{
    partial class FrmAccueil
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
            this.lblAcceuil = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lblAcceuil
            // 
            this.lblAcceuil.AutoSize = true;
            this.lblAcceuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceuil.Location = new System.Drawing.Point(23, 73);
            this.lblAcceuil.Name = "lblAcceuil";
            this.lblAcceuil.Size = new System.Drawing.Size(260, 29);
            this.lblAcceuil.TabIndex = 1;
            this.lblAcceuil.Text = "TEXT PLACEHOLDER";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(426, 98);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // FrmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 395);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblAcceuil);
            this.Name = "FrmAcceuil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FrmAcceuil_Load);
            this.Controls.SetChildIndex(this.lblAcceuil, 0);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcceuil;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}