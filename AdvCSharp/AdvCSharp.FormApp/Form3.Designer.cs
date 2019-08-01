namespace AdvCSharp.FormApp
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
            this.mailForm1 = new AdvCSharp.FormApp.MailForm();
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mail Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailForm1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private MailForm mailForm1;
        private System.Windows.Forms.Button button1;
    }
}