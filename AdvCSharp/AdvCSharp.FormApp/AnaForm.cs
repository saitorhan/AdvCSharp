using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginInterface;
using PropertyAttributes = System.Data.PropertyAttributes;

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

        List<IPlugin> plugins = new List<IPlugin>();

        private void AnaForm_Load(object sender, EventArgs e)
        {
            kullanıcıİşlemleriToolStripMenuItem.Text = Properties.Strings.S001;
            eklentilerToolStripMenuItem.Text = Properties.Strings.S002;

            string[] directories = Directory.GetDirectories(@"C:\CSharp");

            foreach (string directory in directories)
            {
                string[] dlls = Directory.GetFiles(directory, "*.dll");

                foreach (string dll in dlls)
                {
                    Assembly assembly = Assembly.LoadFrom(dll);
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.IsClass && typeof(IPlugin).IsAssignableFrom(type))
                        {
                            IPlugin instance = Activator.CreateInstance(type) as IPlugin;
                            plugins.Add(instance);

                            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
                            {
                                Name = instance.Guid,
                                Text = instance.Name,

                            };

                            toolStripMenuItem.Click += ToolStripMenuItemOnClick;
                            eklentilerToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
                        }
                    }
                }
            }
        }

        private void ToolStripMenuItemOnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;

            IPlugin plugin = plugins.FirstOrDefault(p => p.Guid == toolStripMenuItem.Name);
            if (plugin == null)
            {
                return;
            }

            Form form = plugin.Start();
            FormAc(ref form);
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "tr";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "en";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void servislerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormService();
            FormAc(ref form);
        }
    }
}
