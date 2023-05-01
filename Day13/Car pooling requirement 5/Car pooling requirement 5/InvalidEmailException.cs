using System;

namespace Recruirement_5
{
    public class InvalidEmailException : Exception
    {
        string _email;
        public InvalidEmailException()
        {

        }
        public InvalidEmailException(string email)
        {
            _email = email;
        }
        public void inform()
        {
            Console.WriteLine("Invalid mailid");
        }
    }
}

