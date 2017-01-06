using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Student
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

        private static int studentsCount = 0;

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

        public static int StudentsCount
        {
            get
            {
                return studentsCount;
            }

            
        }


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
            Country = country;

            studentsCount++;

        }




    }

    class Teacher
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
            Country = country;
        }

        }


   class UProgram
    {
        string name;
        string departementHead;
        Degree degree;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string DepartementHead
        {
            get
            {
                return departementHead;
            }

            set
            {
                departementHead = value;
            }
        }

        internal Degree Degree
        {
            get
            {
                return degree;
            }

            set
            {
                degree = value;
            }
        }

        public UProgram(string name, string departementHead, Degree degree=null)
        {
            Name = name;
            DepartementHead = departementHead;
            Degree = degree;


        }

    }

    class Course
    {

        string courseName;
        int credits;
        int durationInWeeks;
        Student[] students;
        Teacher[] teachers;

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public int DurationInWeeks
        {
            get
            {
                return durationInWeeks;
            }

            set
            {
                durationInWeeks = value;
            }
        }

        internal Student[] Students
        {
            get
            {
                return students;
            }

            set
            {
                students = value;
            }
        }

        internal Teacher[] Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
            }
        }

        public Course(string name, int credits, int duration)
        {
            CourseName = name;
            Credits = credits;
            DurationInWeeks = duration;
            Students = new Student[3];
            Teachers = new Teacher[3];
        }

        public bool addStudent(Student stu)
        {
            if(Students.Length > 3)
            {
                return false;
            }
            else
            {
                Students[Students.Length-1] = stu;
                return true;
            }

        }

        public bool addTeacher(Teacher teach)
        {
            if (Teachers.Length > 3)
            {
                return false;
            }
            else
            {
                Teachers[Teachers.Length-1] = teach;
                return true;
            }

        }

    }

    class Degree
    {
        public string Name { get; set; }
        public int CreditsRequired { get; set; }
        internal Course Course { get; set; }

        public Degree(string name, int creditsRequired, Course course=null)
        {
            Name = name;
            CreditsRequired = creditsRequired;
            Course = course;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Firstname1", "lastname1", "01-01-0001", "adress1", "adress21", "city1", "state1", 1, "country1");
            Student stu2 = new Student("Firstname2", "lastname2", "02-02-0002", "adress2", "adress22", "city2", "state2", 2, "country2");
            Student stu3 = new Student("Firstname3", "lastname3", "03-03-0003", "adress3", "adress23", "city3", "state3", 3, "country3");


            Course csharp = new Course("Programming with C#", 4, 6);
            csharp.addStudent(stu1);
            csharp.addStudent(stu2);
            csharp.addStudent(stu3);

            Teacher teach = new Teacher("Teacher1", "Teacherlastname", "01-01-0001", "teachadress", "teachadress2", "teachcity", "teachstate", 55, "teacountry");

            csharp.addTeacher(teach);

            Degree bachelor = new Degree("Bachelor", 8);

            bachelor.Course = csharp;

            UProgram IT = new UProgram("Information Technology", "dptHead");
            IT.Degree = bachelor;


            // Displaying infos

            Console.WriteLine("Program : {0}, Degree : {1}", IT.Name, IT.Degree.Name);
            Console.WriteLine("Course in the degree : {0}", bachelor.Course.CourseName);
            Console.WriteLine("Number of students in course : {0}", Student.StudentsCount);

        }
    }
}
