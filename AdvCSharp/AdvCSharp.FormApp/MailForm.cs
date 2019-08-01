using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvCSharp.FormApp
{
    public partial class MailForm : UserControl
    {
        public string ServerName { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RequireSsl { get; set; }

        public string Kime
        {
            get { return textBoxKime.Text; }
            set { textBoxKime.Text = value; }
        }
        public string Cc
        {
            get { return textBoxCc.Text; }
            set { textBoxCc.Text = value; }
        }
        public string Bcc
        {
            get { return textBoxBcc.Text; }
            set { textBoxBcc.Text = value; }
        }
        public string Konu
        {
            get { return textBoxKonu.Text; }
            set { textBoxKonu.Text = value; }
        }
        public string Mesaj
        {
            get { return textBoxMesaj.Text; }
            set { textBoxMesaj.Text = value; }
        }

        public MailForm()
        {
            InitializeComponent();
        }

        public bool MailGonder()
        {
            return true;
        }
    }
}
