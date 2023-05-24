using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentdetailsfee
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student type:");
            string studentType = Console.ReadLine();
            Console.WriteLine("Enter tuition fee:");
            float tuitionFee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter bus fee:");
            float busFee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hostel fee:");
            float hostelFee = float.Parse(Console.ReadLine());
            float feeAmount = 0;
            if (studentType == "MSDS")
            {
                feeAmount = tuitionFee + busFee;
            }
            else if (studentType == "MSH")
            {
                feeAmount = tuitionFee + hostelFee;
            }
            else if (studentType == "MGSDS")
            {
                feeAmount = 1.5f * tuitionFee + busFee;
            }
            else if (studentType == "MGSH")
            {
                feeAmount = 1.5f * tuitionFee + hostelFee;
            }

            Console.WriteLine("The fees to be paid by the student is Rs.{0}", feeAmount);

        }
    }
}
