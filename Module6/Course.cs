using System;
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
            if (Students.Length > 3)
            {
                return false;
            }
            else
            {
                Students[Students.Length - 1] = stu;
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
                Teachers[Teachers.Length - 1] = teach;
                return true;
            }

        }
    }
}
