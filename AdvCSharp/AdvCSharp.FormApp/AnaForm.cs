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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();

            FormAc(ref form1);
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form2();

            FormAc(ref form1);
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form3();

            FormAc(ref form1);
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form4();

            FormAc(ref form1);
        }

        void FormAc(ref Form form)
        {
            Form f = form;

            foreach (Form mdiChild in MdiChildren)
            {
                if (mdiChild.Text == f.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            f.MdiParent = this;
            f.Show();
        }

        private void üstÜsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
