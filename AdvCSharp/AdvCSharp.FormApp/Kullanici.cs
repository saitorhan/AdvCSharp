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
    public partial class Kullanici : Form
    {
        public int Id { get; set; }
        public string Ad
        {
            get { return textBoxAd.Text; }
            set { textBoxAd.Text = value; }
        }
        public string Soyad
        {
            get { return textBoxSoyad.Text; }
            set { textBoxSoyad.Text = value; }
        }

        public Kullanici()
        {
            InitializeComponent();
        }

        public Kullanici(int id, string ad, string soyad)
        {
            InitializeComponent();
            Id = id;
            Soyad = soyad;
            Ad = ad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Close();
        }
    }
}
