using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Emp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> list = new List<Emp>();
            list.Add(new Emp("Ram","hyd"));
            list.Add(new Emp("Sam", "mum"));
            list.Add(new Emp("Jam", "trv"));
            list.Add(new Emp("Kim", "trv"));
            list.Add(new Emp("Jim", "mum"));

            var eQuery =
                from Emp emp in list
                orderby emp.City
                group emp by emp.City;
            foreach (var e in eQuery)
            {
                Console.WriteLine(" Emp with " +e.Key+"city");
                foreach(var m in e)
                {
                    Console.WriteLine(" " + m.Name);
                }
            }
        }
    }
}
