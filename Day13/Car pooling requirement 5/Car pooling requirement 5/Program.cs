using System;
using System.Collections.Generic;
namespace Recruirement_5
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //List<member> li = new List <member>();

            //int num = 0;

            //Console.WriteLine("Enter the no.of members");

            //num=int.Parse(Console.ReadLine());

            //ArrayList al=new ArrayList();

            //for( int i=0;i<num;i++)

            //{

            // Console.WriteLine("Enter the members {0}", i + 1);

            // string[]s=Console.ReadLine().Split(',');

            // member m1 = new member(long.Parse(s[0]), s[1], s[2], s[3], s[4], s[5], DateTime.ParseExact(s[6], "dd-mm-yyyy", null), DateTime.ParseExact(s[7], "dd-mm-yyyy", null));

            // al.Add(m1);

            //}

            //Console.WriteLine();

            //int j = 1;

            //foreach(var i in al)

            //{

            // Console.WriteLine(" members {1}", j);

            // Console.WriteLine(i.ToString());

            // j++;

            //}

            List<member> list1 = new List<member>();
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Member {0}", i + 1);
                    Console.WriteLine("Id:");
                    long id = long.Parse(Console.ReadLine());
                    Console.WriteLine("first name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("last name:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("email:");
                    string email = Console.ReadLine();
                    Console.WriteLine("contact number:");
                    string contactNumber = Console.ReadLine();
                    Console.WriteLine("license number:");
                    string licenseNumber = Console.ReadLine();
                    Console.WriteLine("license start date:");
                    DateTime licenseStartDate = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);
                    Console.WriteLine("license expiry date:");
                    DateTime licenseExpiryDate = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);
                    member m1 = new member(id, firstName, lastName, email, contactNumber, licenseNumber, licenseStartDate, licenseExpiryDate);
                    list1.Add(m1);

                }
            }
            foreach (member member in list1)
            {
                Console.WriteLine(member.ToString());
            }
            if (list1[0].Equals(list1[1]))
            {
                Console.WriteLine("both member same");
            }
            else
            {
                Console.WriteLine("different");
            }
        }

    }

}