namespace EyeCT4Rails
{
    partial class Form4
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
            this.lbMonteur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMonteur
            // 
            this.lbMonteur.FormattingEnabled = true;
            this.lbMonteur.ItemHeight = 16;
            this.lbMonteur.Location = new System.Drawing.Point(194, 57);
            this.lbMonteur.Name = "lbMonteur";
            this.lbMonteur.Size = new System.Drawing.Size(168, 212);
            this.lbMonteur.TabIndex = 1;
            this.lbMonteur.SelectedIndexChanged += new System.EventHandler(this.lbMonteur_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 356);
            this.Controls.Add(this.lbMonteur);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMonteur;
    }
}