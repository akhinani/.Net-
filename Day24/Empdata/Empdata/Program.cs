using Empdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HRSCHEMEEntities hRSCHEME = new HRSCHEMEEntities();
            foreach (var entity in hRSCHEME.DEPARTMENTS)
            {
                Console.WriteLine(entity);
            }
            using (var context = new HRSCHEMEEntities())
            {
                var std = new DEPARTMENTS()
                {
                    department_id = 1,
                    department_name ="BHUSBH",
                    manager_id = 1,
                    location_id = 1,
                    
                    //employee_id = 1,
                    //first_name = "Bill",
                    //last_name = "Gates",
                    //email = "akhil",
                    //phone_number =9959509,
                    //hire_date = DateTime.Now,
                    //job_id = 1,
                    //salary =2344,
                    //commission_pct = 0,
                    //manager_id = 1,
                    //department_id = 1,
                };
                context.DEPARTMENTS.Add(std);
                context.SaveChanges();
            }
        }
    }
}

