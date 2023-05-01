
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Mail_22
{
     internal class MailFolder
    {
        private string _name;
        private List<Mail> _mailList;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Mail> MailList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }
        private List<Mail> _mailLis = new List<Mail>();
        public MailFolder() { }

        public MailFolder(string name, List<Mail> mailList)
        {
            _name = name;
            _mailList = null;
        }
        public void AddMailToFolder(Mail mail)
        {
           _mailLis.Add(mail);
        }
        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (Mail items in _mailLis)
            {
                if (items.Id == id)
                {
                    _mailLis.Remove(items);
                    break;
                }
            }
                
            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }            
        public void DisplayMails()
        {
            if (_mailLis.Count != 0)
            {
                Console.WriteLine("Mails in inbox");
                
                Console.WriteLine($"Id \tFrom\tTo\tSubject\tContent\tReceived Date\tSize\n");
                foreach(var items in _mailLis)
                {
                    Console.WriteLine(items.ToString());
                }
            }
            else
            {
                Console.WriteLine("No mails to Show");
            }
            
        }
    }
}