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
    public partial class Form1 : Form
    {
        public int Id { get; set; }

        public Form1()
        {
            InitializeComponent();
            Id = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();
            DialogResult result = yeniKullanici.ShowDialog();

            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Add(Id++, yeniKullanici.Ad, yeniKullanici.Soyad);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];

            Kullanici kullaniciGuncelleme = new Kullanici();
            kullaniciGuncelleme.Ad = dataGridViewRow.Cells[1].Value.ToString();
            kullaniciGuncelleme.Soyad = dataGridViewRow.Cells[2].Value.ToString();
            kullaniciGuncelleme.Id = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

            DialogResult result = kullaniciGuncelleme.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            dataGridViewRow.Cells[1].Value = kullaniciGuncelleme.textBoxAd.Text;
            dataGridViewRow.Cells[2].Value = kullaniciGuncelleme.Soyad;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Kayıt silinecek, onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                button1_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.U)
            {
                button2_Click(null, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button3_Click(null, null);
            }
            
        }
    }
}
