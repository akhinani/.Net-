using System;
using System.Text; 

namespace Base64Ex
{

    class Program
    {
        static void Main()
        {
            string msg = "one 🐘 and three 🐋";
            string base64 = msg.EncodeBase64();
            string msg2 = base64.DecodeBase64();

            Console.WriteLine(msg);
            Console.WriteLine(base64);
            Console.WriteLine(msg2);
        }
    }

    static class ExtensionMethods
    {
        public static string EncodeBase64(this string value)
        {
            byte[] data = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(data);
        }

        public static string DecodeBase64(this string value)
        {
            byte[] data = System.Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(data);
        }
    }
}