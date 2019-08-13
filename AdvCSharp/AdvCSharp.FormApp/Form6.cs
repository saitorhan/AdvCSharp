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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            listBox1.Items.Add($"Dosya değiştirildi ({e.Name})({e.FullPath}) - {DateTime.Now}");
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            listBox1.Items.Add($"Dosya eklendi ({e.Name})({e.FullPath}) - {DateTime.Now}");
        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            listBox1.Items.Add($"Dosya silindi ({e.Name})({e.FullPath}) - {DateTime.Now}");
        }

        private void fileSystemWatcher1_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            listBox1.Items.Add($"Dosya yeniden adlandırıldı ({e.OldName} => {e.Name})({e.OldFullPath} => {e.FullPath}) - {DateTime.Now}");
        }
    }
}
