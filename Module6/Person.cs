using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        private string adressLine1;
        private string adressLine2;
        private string city;
        private string stateProvince;
        private int zipPostal;
        private string Country;

        

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        public string AdressLine1
        {
            get
            {
                return adressLine1;
            }

            set
            {
                adressLine1 = value;
            }
        }

        public string AdressLine2
        {
            get
            {
                return adressLine2;
            }

            set
            {
                adressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string StateProvince
        {
            get
            {
                return stateProvince;
            }

            set
            {
                stateProvince = value;
            }
        }

        public int ZipPostal
        {
            get
            {
                return zipPostal;
            }

            set
            {
                zipPostal = value;
            }
        }

        public string Country1
        {
            get
            {
                return Country;
            }

            set
            {
                Country = value;
            }
        }

     
        
    }
}
