using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = ActiveUp.Net.Mail.Message;

namespace AdvCSharp.FormApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MailRepository mailRepository = new MailRepository("imap.gmail.com", 993, true, "saitorhan@gmail.com", "rxeohxsfqnrtxxbj");
            List<Message> unReadMessages = mailRepository.GetUnReadMessages("INBOX");
            dataGridView1.DataSource = unReadMessages;
        }
    }
}
