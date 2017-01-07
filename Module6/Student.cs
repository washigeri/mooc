using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Student : Person
    {
        private static int studentsCount = 0;
        private Stack<Int32> grades;

        

        public Student(string firstName, string lastName, string birthdate, string adressLine1, string adressLine2, string city, string stateProvince, int zipPostal, string country)
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
            studentsCount++;

            Grades = new Stack<Int32>();

        }

        public static int StudentsCount
        {
            get
            {
                return studentsCount;
            }

            
        }

        public Stack<Int32> Grades
        {
            get
            {
                return grades;
            }

            set
            {
                grades = value;
            }
        }

        public void TakeTest()
        {
            Console.WriteLine("Student's TakeTest method !");
        }
    }
}
