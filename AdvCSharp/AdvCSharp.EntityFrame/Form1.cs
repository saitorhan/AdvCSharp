using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvCSharp.EntityFrame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocsEntities docsEntities = new DocsEntities();
            List<Category> categories = docsEntities.Categories.ToList();
            categoryBindingSource.DataSource = categories;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocsEntities docsEntities = new DocsEntities();
            int i = Int32.Parse(textBox1.Text);
            Category category = docsEntities.Categories.FirstOrDefault(c => c.Id == i);

            categoryBindingSource.DataSource = category;
        }
    }
}
