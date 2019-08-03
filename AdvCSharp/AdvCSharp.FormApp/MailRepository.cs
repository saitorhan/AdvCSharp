using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveUp.Net.Mail;

namespace AdvCSharp.FormApp
{
    class MailRepository
    {
        private Imap4Client Client;

        public MailRepository(string host, int port, bool ssl, string userName, string password)
        {
            Client = new Imap4Client();

            if (ssl)
            {
                Client.ConnectSsl(host, port);
            }
            else
            {
                Client.Connect(host, port);
            }

            Client.Login(userName, password);
        }

        private MessageCollection GetMail(string mailbox, string searchPhrase)
        {
            Mailbox Mailbox = Client.SelectMailbox(mailbox);
            MessageCollection messageCollection = Mailbox.SearchParse(searchPhrase);

            return messageCollection;
        }

        public List<Message> GetUnReadMessages(string mailbox)
        {
            return GetMail(mailbox, "UNSEEN").Cast<Message>().ToList();
        }
    }
}
