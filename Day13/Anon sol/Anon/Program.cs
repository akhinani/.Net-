using System;


delegate void CountIt();

class AnonMethDemo

{

    static void Main()

    {

        CountIt count = delegate

        {

            for (int i = 1; i <= 10; i++)

                Console.WriteLine(i);

        };

        count();

    }

}