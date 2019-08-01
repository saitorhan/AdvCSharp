using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        public bool IsHtml { get; set; }

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
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = ServerName;
            smtpClient.Port = Port;
            smtpClient.EnableSsl = RequireSsl;
            smtpClient.Credentials = new NetworkCredential(Username, Password);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(Username);
            
            foreach (string s in textBoxKime.Text.Split(';'))
            {
                mailMessage.To.Add(s);
            }

            if (textBoxCc.Text.Length > 0)
            {
                foreach (string s in textBoxCc.Text.Split(';'))
                {
                    mailMessage.CC.Add(s);
                }
            }
            if (textBoxBcc.Text.Length > 0)
            {
                foreach (string s in textBoxBcc.Text.Split(';'))
                {
                    mailMessage.Bcc.Add(s);
                }
            }

            mailMessage.Subject = textBoxKonu.Text;
            mailMessage.Body = textBoxMesaj.Text;
            mailMessage.IsBodyHtml = IsHtml;

            try
            {
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
