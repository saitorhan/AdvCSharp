namespace AdvCSharp.FormApp
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
            this.mailForm1 = new AdvCSharp.FormApp.MailForm();
            this.numberOnly1 = new AdvCSharp.FormApp.NumberOnly();
            this.SuspendLayout();
            // 
            // mailForm1
            // 
            this.mailForm1.Bcc = "";
            this.mailForm1.Cc = "";
            this.mailForm1.Kime = "";
            this.mailForm1.Konu = "";
            this.mailForm1.Location = new System.Drawing.Point(12, 12);
            this.mailForm1.Mesaj = "";
            this.mailForm1.Name = "mailForm1";
            this.mailForm1.Password = null;
            this.mailForm1.Port = 0;
            this.mailForm1.RequireSsl = false;
            this.mailForm1.ServerName = null;
            this.mailForm1.Size = new System.Drawing.Size(474, 366);
            this.mailForm1.TabIndex = 0;
            this.mailForm1.Username = null;
            // 
            // numberOnly1
            // 
            this.numberOnly1.Location = new System.Drawing.Point(631, 12);
            this.numberOnly1.Name = "numberOnly1";
            this.numberOnly1.Size = new System.Drawing.Size(100, 20);
            this.numberOnly1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 633);
            this.Controls.Add(this.numberOnly1);
            this.Controls.Add(this.mailForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MailForm mailForm1;
        private NumberOnly numberOnly1;
    }
}