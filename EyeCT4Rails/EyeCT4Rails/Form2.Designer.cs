namespace EyeCT4Rails
{
    partial class Form2
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
            this.btnSchoonmaak = new System.Windows.Forms.Button();
            this.btnMonteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSchoonmaak
            // 
            this.btnSchoonmaak.Location = new System.Drawing.Point(43, 61);
            this.btnSchoonmaak.Name = "btnSchoonmaak";
            this.btnSchoonmaak.Size = new System.Drawing.Size(179, 37);
            this.btnSchoonmaak.TabIndex = 1;
            this.btnSchoonmaak.Text = "Schoonmaak rooster";
            this.btnSchoonmaak.UseVisualStyleBackColor = true;
            this.btnSchoonmaak.Click += new System.EventHandler(this.btnSchoonmaak_Click);
            // 
            // btnMonteur
            // 
            this.btnMonteur.Location = new System.Drawing.Point(43, 124);
            this.btnMonteur.Name = "btnMonteur";
            this.btnMonteur.Size = new System.Drawing.Size(179, 37);
            this.btnMonteur.TabIndex = 2;
            this.btnMonteur.Text = "Monteur rooster";
            this.btnMonteur.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 391);
            this.Controls.Add(this.btnMonteur);
            this.Controls.Add(this.btnSchoonmaak);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSchoonmaak;
        private System.Windows.Forms.Button btnMonteur;
    }
}