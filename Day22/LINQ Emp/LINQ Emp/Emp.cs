using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LINQ_Emp
{
    internal class Emp
    {
        public string _name;
        public string _city;


        public string Name
        { 
            get { return _name; }
      
        }
        public string City
        { 
            get { return _city; } 
          
        }
        public Emp(string name, string city)
        {
            _name = name;
            _city = city;
        }




    }
}
  

