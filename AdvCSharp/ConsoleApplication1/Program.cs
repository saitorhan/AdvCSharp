using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MailGonder();
        }

        public static bool MailGonder()
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
