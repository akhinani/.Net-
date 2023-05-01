using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Mail_22
{
    public class Mail
    {
        private long _id;
        private string _from;
        private string _to;
        private string _subject;
        private string _content;
        private DateTime _recivedDate;
        private double _size;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime RecivedDate
        {
            get { return _recivedDate; }
            set { _recivedDate = value; }
        }
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Mail() { }
        public Mail(long id, string from, string to, string subject, string content, DateTime reciveddate, double size)

        {
            _id = id;
            _from = from;
            _to = to;
            _subject = subject;
            _content = content;
            _recivedDate = reciveddate;
            _size = size;
        }
        public override string ToString()
        {
            return string.Format($"{_id}\t{_from}\t {_to}\t {_subject}\t{_content}\t {_recivedDate}\t {_size}\t");
        }
        public static Mail CreateMail(string detail)
        {
            string[] de = detail.Split(',');
            DateTime dateTime = DateTime.ParseExact(de[5], "dd-MM-yyyy", null);
            Mail m1= new Mail(long.Parse(de[0]), de[1], de[2], de[3], de[4], dateTime, double.Parse(de[6]));
            return m1;
          
        }
    }
}

