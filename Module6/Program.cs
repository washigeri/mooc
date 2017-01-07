using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Firstname1", "lastname1", "01-01-0001", "adress1", "adress21", "city1", "state1", 1, "country1");
            Student stu2 = new Student("Firstname2", "lastname2", "02-02-0002", "adress2", "adress22", "city2", "state2", 2, "country2");
            Student stu3 = new Student("Firstname3", "lastname3", "03-03-0003", "adress3", "adress23", "city3", "state3", 3, "country3");

            //adding grades

            for(int i = 0; i< 5; i++)
            {
                stu1.Grades.Push((i * 4));

            }
            for (int i = 0; i < 5; i++)
            {
                stu2.Grades.Push((i * 4));

            }
            for (int i = 0; i < 5; i++)
            {
                stu3.Grades.Push((i * 4));

            }

            //adding students to the course arraylist

            Course csharp = new Course("Programming with C#", 4, 6);
            csharp.Students.Add(stu1);
            csharp.Students.Add(stu2);
            csharp.Students.Add(stu3);

            //Displaying student names

            csharp.ListStudents();


            //Teacher teach = new Teacher("Teacher1", "Teacherlastname", "01-01-0001", "teachadress", "teachadress2", "teachcity", "teachstate", 55, "teacountry");

            //csharp.addTeacher(teach);

            //Degree bachelor = new Degree("Bachelor", 8);

            //bachelor.Course = csharp;

            //UProgram IT = new UProgram("Information Technology", "dptHead");
            //IT.Degree = bachelor;


            //// Displaying infos

            //Console.WriteLine("Program : {0}, Degree : {1}", IT.Name, IT.Degree.Name);
            //Console.WriteLine("Course in the degree : {0}", bachelor.Course.CourseName);
            //Console.WriteLine("Number of students in course : {0}", Student.StudentsCount);


            ////Challenge

            //Person person = new Person("name", "lastname", "01-01-0001", " ", ".", ".", ".", 14654, ".");

            


        }
    }
}
