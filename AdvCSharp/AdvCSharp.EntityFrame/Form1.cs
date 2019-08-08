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
            List<Category> categories = docsEntities.Categories.Include(c => c.Files).Include(f => f.Sequences).ToList();
            categoryBindingSource.DataSource = categories;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int id = Int32.Parse(textBox1.Text);
            // where metodu
            DocsEntities docsEntities = new DocsEntities();

            User user = docsEntities.Users.SingleOrDefault(u => u.Id == 12);

            // List<User> users = docsEntities.Users.Where(u => u.UserName.StartsWith(textBox1.Text) && u.Login == true).ToList();
            //List<User> users = docsEntities.Users.Where(u => u.Login == true).OrderByDescending(u1 => u1.FullName).ThenByDescending(u2 => u2.IpAddress).ToList();
            //var users = docsEntities.Users.Where(u => u.Login == true).Select(u => new
            //{
            //    u.FullName,
            //    u.UserName
            //}).ToList();

            //   categoryBindingSource.DataSource = users;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DocsEntities docsEntities = new DocsEntities();
            //List<IGrouping<string, User>> list = docsEntities.Users.GroupBy(u => u.IpAddress).ToList();

            //foreach (IGrouping<string, User> grouping in list)
            //{
            //    string groupingKey = grouping.Key;
            //    foreach (User user in grouping)
            //    {
                    
            //    }
            //}

            bool all = docsEntities.Users.Any(u => u.ReadOnlyUser == true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> idInts = new List<int>() {3,4,87,4,12,54};

            DocsEntities docsEntities = new DocsEntities();
            List<User> users = docsEntities.Users.Where(f => idInts.Contains(f.Id)).ToList();

            categoryBindingSource.DataSource = users;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DocsEntities docsEntities = new DocsEntities();

            //avarage
           // double result = docsEntities.FileVersions.AverageAsync(f => f.FileSize).Result;

           //int result = docsEntities.FileVersions.Count(f => f.Extension == ".docx");
           int result = docsEntities.FileVersions.Sum(f => f.FileSize);

           label1.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                Code = "DD2",
                DelFlag = false,
                Name = "Deneme Kategori"
            };

            DocsEntities docsEntities = new DocsEntities();
            //Category add = docsEntities.Categories.Add(category);
            docsEntities.Entry(category).State = EntityState.Added;

            docsEntities.SaveChanges();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DocsEntities docsEntities = new DocsEntities();
            //Category category = docsEntities.Categories.FirstOrDefault(c => c.Id == 1003);

            //category.Name = "Bilgi Güvenliği";
            //category.Code = "BG";

            Category category = new Category
            {
                Id = 1003,
                Code = "BG2",
                DelFlag = false,
                Name = "Blgi Yönetim Sistemi"
            };

            docsEntities.Entry(category).State = EntityState.Modified;

            docsEntities.SaveChanges();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DocsEntities docsEntities = new DocsEntities();

            Category category = new Category
            {
                Id = 1004,
                Code = "BG2",
                DelFlag = false,
                Name = "Blgi Yönetim Sistemi"
            };

            //Category category = docsEntities.Categories.FirstOrDefault(c => c.Id == 1003);

            docsEntities.Entry(category).State = EntityState.Deleted;
            docsEntities.SaveChanges();
        }
    }
}
