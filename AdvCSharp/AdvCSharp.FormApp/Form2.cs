using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace AdvCSharp.FormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mailForm1.ServerName = "smtp.gmail.com";
            mailForm1.Port = 587;
            mailForm1.RequireSsl = true;
            mailForm1.Username = "saitorhan@gmail.com";
            mailForm1.Password = "ashbftidzwtwkere";
            mailForm1.IsHtml = true;

            bool mailGonder = mailForm1.MailGonder();
            MessageBox.Show(mailGonder.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData data = qrCodeGenerator.CreateQrCode("Bu ilk QR code denemesidir.", QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(data);
            Bitmap bitmap = qrCode.GetGraphic(20);

            pictureBox1.Image = bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PayloadGenerator.Bookmark bookmark = new PayloadGenerator.Bookmark("http://saitorhan.com", "Sait ORHAN Web Sayfası");
            string s = bookmark.ToString();

            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData data = qrCodeGenerator.CreateQrCode(s, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(data);

            pictureBox1.Image = qrCode.GetGraphic(20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PayloadGenerator.CalendarEvent gCalendarEvent = new PayloadGenerator.CalendarEvent("Site Yayına alınma tarihi", "Deneme takvim qr", start:new DateTime(2019, 12,12), end:new DateTime(2019, 12 ,21), allDayEvent:true, location:null);

            string s = gCalendarEvent.ToString();

            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData data = qrCodeGenerator.CreateQrCode(s, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(data);

            pictureBox1.Image = qrCode.GetGraphic(20);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PayloadGenerator.ContactData contactData = new PayloadGenerator.ContactData(PayloadGenerator.ContactData.ContactOutputType.VCard3, "Sait", "ORHAN", phone:"123456789");

            string s = contactData.ToString();

            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData data = qrCodeGenerator.CreateQrCode(s, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(data);

            pictureBox1.Image = qrCode.GetGraphic(20);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PayloadGenerator.WiFi wiFi = new PayloadGenerator.WiFi("denemeSSID", "1234567", PayloadGenerator.WiFi.Authentication.WPA);
            string s = wiFi.ToString();

            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            QRCodeData data = qrCodeGenerator.CreateQrCode(s, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(data);

            pictureBox1.Image = qrCode.GetGraphic(20);
        }
    }
}
