using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvCSharp.FormApp
{
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButunServisler();
        }

        void ButunServisler()
        {
            ServiceController[] serviceControllers = ServiceController.GetServices();

            dataGridView1.DataSource = serviceControllers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.SelectedRows[0].Cells["ServiceName"].Value.ToString();
            ServiceController serviceController = new ServiceController(s);

            if (serviceController.CanStop && serviceController.Status != ServiceControllerStatus.Stopped)
            {
                serviceController.Stop();
                ButunServisler();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.SelectedRows[0].Cells["ServiceName"].Value.ToString();
            ServiceController serviceController = new ServiceController(s);

            if (serviceController.Status != ServiceControllerStatus.Running)
            {
                serviceController.Start();
                ButunServisler();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<ServiceController> serviceControllers = new List<ServiceController>();
            foreach (ServiceController controller in ServiceController.GetServices())
            {
                if (controller.ServiceName.Contains(textBoxServiceAd.Text))
                {
                    serviceControllers.Add(controller);
                }
            }

            dataGridView1.DataSource = serviceControllers;

        }
        
    }
}
