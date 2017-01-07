using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Course
    {
        string courseName;
        int credits;
        int durationInWeeks;
        List<Student> students;
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

        internal List<Student> Students
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
            Students = new List<Student>(3);
            Teachers = new Teacher[3];
        }

        

        public bool addTeacher(Teacher teach)
        {
            if (Teachers.Length > 3)
            {
                return false;
            }
            else
            {
                Teachers[Teachers.Length - 1] = teach;
                return true;
            }

        }

        public void ListStudents()
        {
            foreach(Student stu in this.Students)
            {
                Console.WriteLine("Student : {0} {1}", stu.FirstName, stu.LastName);

            }
        }

    }
}
