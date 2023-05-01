using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruirement_5
{

    internal class member
    {
        private long _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _contactNumber;
        private string _licenseNumber;
        private DateTime _licenseStartDate;
        private DateTime _licenseExpiryDate;
        public long Id
        {
            get
            { return _id; }
            set
            {
                _id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
            }
        }
        public string LicenseNumber
        {
            get
            {
                return _licenseNumber;
            }
            set
            {
                _licenseNumber = value;
            }

        }
        public DateTime LicenseStartDate
        {
            get
            {
                return _licenseExpiryDate;
            }
            set
            {
                _licenseExpiryDate = value;
            }
        }
        public DateTime LicenseExpiryDate
        {
            get
            {
                return _licenseExpiryDate;
            }
            set

            {
                _licenseExpiryDate = value;
            }

        }
        public member()
        {

        }
        public member(long id, string firstName, string lastName, string email, string contactNumber, string licenseNumber, DateTime licenseStartDate, DateTime licenseExpiryDate)
        {

            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _contactNumber = contactNumber;
            _licenseNumber = licenseNumber;
            _licenseStartDate = licenseStartDate;
            _licenseExpiryDate = licenseExpiryDate;
        }
        public override string ToString()
        {
            return string.Format("Id {0}\n,Firstname{1}\n,Lastname{2}\n,Email{3}\n,ContactNumber{4}\n,LicenseNumber{5}\n,LicenseStartdate{6}\n,LicenseEnddate{7}\n", _id, _firstName, _lastName, _email, _contactNumber, _licenseNumber, _licenseStartDate.ToString("dd-mm-yyy", null), _licenseExpiryDate.ToString("dd-mm-yyy", null));
        }
        public void checking(string email)
        {
            if (email.Contains("@") && ((email.EndsWith(".com")) || (email.EndsWith(".org"))))
            {
                Console.WriteLine("valid mail");
            }
            else
            {
                throw new InvalidEmailException(email);
            }
        }
    }
}

