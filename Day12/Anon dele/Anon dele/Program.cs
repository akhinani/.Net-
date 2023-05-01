using System;

class Test

{

    delegate string Cat(string[] s);

    public static void Main()

    {

        Cat c = delegate (string[] s)

        {

            string c1 = "";

            foreach (string s1 in s)

                c1 = c1 + s1;

            return c1;

        };

        string[] ss = { "C#", "IN", "ACTION" };

        Console.WriteLine(c(ss));

    }

}