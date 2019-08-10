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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mailForm1.MailGonder();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double a, b;
            a = 4;
            b = 5;

            Tuple<double, string, double, double> dortIslem = DortIslem(a, b);

            double toplam = dortIslem.Item1;
            double carpim = dortIslem.Item3;

            circularProgressBar1.Text = textBox1.Text;
            int deger = Convert.ToInt32(textBox1.Text);
            circularProgressBar1.Value = deger;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public Tuple<double, string, double, double> DortIslem(double s1, double s2)
        {
            return new Tuple<double, string, double, double>(s1+s2, "Deneme String", s1*s2, s1/s2);
        }
    }
}
