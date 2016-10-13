namespace EyeCT4Rails
{
    partial class Form3
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
            this.lbSchoonmaak = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbSchoonmaak
            // 
            this.lbSchoonmaak.FormattingEnabled = true;
            this.lbSchoonmaak.ItemHeight = 16;
            this.lbSchoonmaak.Location = new System.Drawing.Point(197, 59);
            this.lbSchoonmaak.Name = "lbSchoonmaak";
            this.lbSchoonmaak.Size = new System.Drawing.Size(168, 212);
            this.lbSchoonmaak.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 393);
            this.Controls.Add(this.lbSchoonmaak);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSchoonmaak;
    }
}