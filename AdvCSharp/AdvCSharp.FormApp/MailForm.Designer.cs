namespace AdvCSharp.FormApp
{
    partial class MailForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKime = new System.Windows.Forms.TextBox();
            this.textBoxCc = new System.Windows.Forms.TextBox();
            this.textBoxBcc = new System.Windows.Forms.TextBox();
            this.textBoxKonu = new System.Windows.Forms.TextBox();
            this.textBoxMesaj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "BCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Konu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mesaj";
            // 
            // textBoxKime
            // 
            this.textBoxKime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKime.Location = new System.Drawing.Point(57, 7);
            this.textBoxKime.Name = "textBoxKime";
            this.textBoxKime.Size = new System.Drawing.Size(587, 20);
            this.textBoxKime.TabIndex = 1;
            // 
            // textBoxCc
            // 
            this.textBoxCc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCc.Location = new System.Drawing.Point(57, 33);
            this.textBoxCc.Name = "textBoxCc";
            this.textBoxCc.Size = new System.Drawing.Size(587, 20);
            this.textBoxCc.TabIndex = 1;
            // 
            // textBoxBcc
            // 
            this.textBoxBcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBcc.Location = new System.Drawing.Point(57, 59);
            this.textBoxBcc.Name = "textBoxBcc";
            this.textBoxBcc.Size = new System.Drawing.Size(587, 20);
            this.textBoxBcc.TabIndex = 1;
            // 
            // textBoxKonu
            // 
            this.textBoxKonu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKonu.Location = new System.Drawing.Point(60, 85);
            this.textBoxKonu.Name = "textBoxKonu";
            this.textBoxKonu.Size = new System.Drawing.Size(587, 20);
            this.textBoxKonu.TabIndex = 1;
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMesaj.Location = new System.Drawing.Point(60, 111);
            this.textBoxMesaj.Multiline = true;
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(587, 252);
            this.textBoxMesaj.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ekler";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 369);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 93);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.DoubleClick += new System.EventHandler(this.flowLayoutPanel1_DoubleClick);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMesaj);
            this.Controls.Add(this.textBoxKonu);
            this.Controls.Add(this.textBoxBcc);
            this.Controls.Add(this.textBoxCc);
            this.Controls.Add(this.textBoxKime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MailForm";
            this.Size = new System.Drawing.Size(647, 475);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKime;
        private System.Windows.Forms.TextBox textBoxCc;
        private System.Windows.Forms.TextBox textBoxBcc;
        private System.Windows.Forms.TextBox textBoxKonu;
        private System.Windows.Forms.TextBox textBoxMesaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
