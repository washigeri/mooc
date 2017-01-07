using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string birthdate, string adressLine1, string adressLine2, string city, string stateProvince, int zipPostal, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = DateTime.ParseExact(birthdate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            AdressLine1 = adressLine1;
            AdressLine2 = adressLine2;
            City = city;
            StateProvince = stateProvince;
            ZipPostal = zipPostal;
            Country1 = country;
        }

        public void GradeTest()
        {
            Console.WriteLine("Teacher's GradeTest method !");
        }
    }
}
