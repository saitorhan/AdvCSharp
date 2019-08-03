using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace AdvCSharp.FormApp
{
    public partial class MailForm : UserControl
    {
        public string ServerName { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RequireSsl { get; set; }
        public bool IsHtml { get; set; }

        public string Kime
        {
            get { return textBoxKime.Text; }
            set { textBoxKime.Text = value; }
        }
        public string Cc
        {
            get { return textBoxCc.Text; }
            set { textBoxCc.Text = value; }
        }
        public string Bcc
        {
            get { return textBoxBcc.Text; }
            set { textBoxBcc.Text = value; }
        }
        public string Konu
        {
            get { return textBoxKonu.Text; }
            set { textBoxKonu.Text = value; }
        }
        public string Mesaj
        {
            get { return textBoxMesaj.Text; }
            set { textBoxMesaj.Text = value; }
        }

        public MailForm()
        {
            InitializeComponent();
        }

        public bool MailGonder()
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = ServerName;
            smtpClient.Port = Port;
            smtpClient.EnableSsl = RequireSsl;
            smtpClient.Credentials = new NetworkCredential(Username, Password);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(Username);

            foreach (string s in textBoxKime.Text.Split(';'))
            {
                mailMessage.To.Add(s);
            }

            if (textBoxCc.Text.Length > 0)
            {
                foreach (string s in textBoxCc.Text.Split(';'))
                {
                    mailMessage.CC.Add(s);
                }
            }
            if (textBoxBcc.Text.Length > 0)
            {
                foreach (string s in textBoxBcc.Text.Split(';'))
                {
                    mailMessage.Bcc.Add(s);
                }
            }

            mailMessage.Subject = textBoxKonu.Text;
            mailMessage.Body = textBoxMesaj.Text;
            mailMessage.IsBodyHtml = IsHtml;

            //if (flowLayoutPanel1.Controls.Count > 0)
            //{
            //    foreach (Control control in flowLayoutPanel1.Controls)
            //    {
            //        Button button = control as Button;
            //        mailMessage.Attachments.Add(new Attachment(button.Tag.ToString()));
            //    }
            //}

            Attachment addFromSql = AddFromList(@"Data Source=.\egitim;Initial Catalog=Docs;Integrated Security=True",
                "select FullName, Email from Users");
            mailMessage.Attachments.Add(addFromSql);

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

        private void flowLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            foreach (string fileName in openFileDialog.FileNames)
            {
                Button button = new Button();
                button.Name = Guid.NewGuid().ToString("N");
                button.Tag = fileName;
                button.Text = (new FileInfo(fileName)).Name;

                button.Click += ButtonOnClick;
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Process.Start(button.Tag.ToString());
        }

        public Attachment AddFromSql(string connectionString, string command)
        {
            string dosyaAd = String.Empty;
            byte[] data = null;
            long uzunluk = 0;
            MemoryStream memoryStream;

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                dosyaAd = sqlDataReader.GetString(0);
                uzunluk = sqlDataReader.GetBytes(1, 0L, null, 0, 0);
                data = new byte[uzunluk];

                sqlDataReader.GetBytes(1, 0L, data, 0, (int)uzunluk);
            }

            sqlConnection.Close();
            memoryStream = new MemoryStream(data);
            return new Attachment(memoryStream, dosyaAd);
        }

        public Attachment AddFromList(string connString, string command)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            MemoryStream memoryStream = new MemoryStream();
            SpreadsheetDocument document = SpreadsheetDocument.Create(memoryStream, SpreadsheetDocumentType.Workbook);
            WorkbookPart workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet();

            Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
            Sheet sheet = new Sheet()
            {
                Id = workbookPart.GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Kullanıcılar"
            };

            sheets.Append(sheet);
            workbookPart.Workbook.Save();

            SheetData sheetData = worksheetPart.Worksheet.AppendChild(new SheetData());
            Row row = new Row();
            row.Append(getCell("Tam Adı", CellValues.String), getCell("Email", CellValues.String));
            sheetData.AppendChild(row);

            while (sqlDataReader.Read())
            {
                row = new Row();
                row.Append(getCell(sqlDataReader.GetString(0), CellValues.String),
                    getCell(sqlDataReader.GetString(1), CellValues.String));
                sheetData.AppendChild(row);
            }

            sqlConnection.Close();

            worksheetPart.Worksheet.Save();
            document.Save();
            document.Close();
            document.Dispose();

            memoryStream.Seek(0, SeekOrigin.Begin);
            Attachment attachment = new Attachment(memoryStream, "KullanıcıListesi.xlsx");
            return attachment;
        }

        Cell getCell(string value, CellValues dataType)
        {
            return new Cell
            {
                CellValue = new CellValue(value),
                DataType = dataType
            };
        }
    }
}
