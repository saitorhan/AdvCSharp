using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvCSharp.FormApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            dataGridView1.DataSource = processes;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(textBox1.Text);
            //Process processById = Process.GetProcessById(id);
            //processById.Kill();

            Process[] processesByName = Process.GetProcessesByName(textBox1.Text);

            foreach (Process process in processesByName)
            {
                process.Kill();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            Process.Start(openFileDialog.FileName);
        }
    }
}
