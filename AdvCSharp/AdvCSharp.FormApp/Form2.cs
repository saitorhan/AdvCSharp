using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvCSharp.FormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mailForm1.ServerName = "smtp.gmail.com";
            mailForm1.Port = 587;
            mailForm1.RequireSsl = true;
            mailForm1.Username = "saitorhan@gmail.com";
            mailForm1.Password = "ashbftidzwtwkere";
            mailForm1.IsHtml = true;

            bool mailGonder = mailForm1.MailGonder();
            MessageBox.Show(mailGonder.ToString());
        }
    }
}
