using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServiceSendMail
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (timer == null)
            {
                timer = new Timer();
            }

            timer.Interval = 30000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            MailGonder();
            timer.Start();


        }

        protected override void OnStop()
        {
        }

        public bool MailGonder()
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com"; 
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("saitorhan@gmail.com", "ashbftidzwtwkere");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("saitorhan@gmail.com");

            
                mailMessage.To.Add("saitorhan@yandex.com");


                mailMessage.Subject = "Windows Servis Testi";
                mailMessage.Body = $"{DateTime.Now.ToString("F")} zamanında çalıştı";
            

            try
            {
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }
    }
}
