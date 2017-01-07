using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    public struct Student
        {
            public string firstName;
            public string lastName;
            public DateTime birthdate;
            public string adressLine1;
            public string adressLine2;
            public string city;
            public string stateProvince;
            public int zipPostal;
            public string Country;

        }
    public struct Teacher
    {
        public string firstName;
        public string lastName;
        public DateTime birthdate;
        public string adressLine1;
        public string adressLine2;
        public string city;
        public string stateProvince;
        public int zipPostal;
        public string Country;

    }
    public struct UProgram
    {
        string name;
        string departementHead;
        string degrees;

    }

    public struct Course
    {
        string courseName;
        int credits;
        int durationInWeeks;
        Teacher teacher;
    }

    class Program
    {
        static void displayStudent(Student stu)
        {
            Console.Write("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", stu.firstName, stu.lastName, stu.birthdate.Day.ToString() + '-' + stu.birthdate.Month.ToString() + '-' + stu.birthdate.Year.ToString(), stu.adressLine1, stu.adressLine2, stu.city, stu.stateProvince, stu.zipPostal, stu.Country);
        }

        static void Main(string[] args)
        {
            Student[] arrStudent = new Student[5];
            
            for(int i = 0; i< arrStudent.Length; i++)
            {
                arrStudent[i].firstName = "First Name";
                arrStudent[i].lastName = "Last Name";
                arrStudent[i].birthdate = new DateTime(year: 2017, month: 01, day: 01);
                arrStudent[i].adressLine1 = "Adress 1";
                arrStudent[i].adressLine2 = "Adress 2";
                arrStudent[i].city = "City";
                arrStudent[i].stateProvince = "State";
                arrStudent[i].zipPostal = 1;
                arrStudent[i].Country = "Country";
            }

            //=== Displaying students info

            int k = 0;
            while (k < arrStudent.Length)
            {
                Console.WriteLine("--------------------------------\nStudent {0} : \n", k + 1);
                displayStudent(arrStudent[k]);
                Console.WriteLine("\n");
                k++;

            }

        }
    }
}
