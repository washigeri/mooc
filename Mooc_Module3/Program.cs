using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooc_Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            //===Students variables===
            string firstname, lastname, adress1, adress2, city, stateProvince, country;
            DateTime birthdate;
            int zipcode;


            GetStudentInformation(out firstname, out lastname,out birthdate, out adress1, out adress2, out city, out stateProvince, out zipcode, out country);
            PrintStudentDetails(firstname, lastname, birthdate, adress1, adress2, city, stateProvince, zipcode, country);

            //==Teacher variables
            string tfirstname, tlastname, tadress1, tadress2, tcity, tstateProvince, tcountry;
            DateTime tbirthdate;
            int tzipcode;

            GetTeacherInformation(out tfirstname, out tlastname, out tbirthdate, out tadress1, out tadress2, out tcity, out tstateProvince, out tzipcode, out tcountry) ;
            PrintTeachertDetails(tfirstname, tlastname, tbirthdate, tadress1, tadress2, tcity, stateProvince, tzipcode, tcountry);

            //Course variables
            string name, teacher;
            int credits, duration;

            GetCourseInformation(out name, out credits, out duration, out teacher);
            PrintCourseDetails(name, credits, duration, teacher);

            //Degree variables
            string dname; int creditsRequired;
            
            GetDegreeInformation(out dname, out creditsRequired);
            PrintDegreeDetails(dname, creditsRequired);


            //UProgram variables

            string pname, departmentHead, degrees;

            GetUPgromInformation(out pname, out departmentHead, out degrees);
            PrintUProgrammDetails(pname, departmentHead, degrees);


            //Exception throw test

            ValidateStudentBirthday(birthdate);
        }


        #region methods

            #region Getting Informations

            static void GetStudentInformation(out string firstName, out string lastName, out DateTime birthdate, out string adress1, out string adress2,out string city, out string state, out int zipcode, out string country )
            {
                Console.WriteLine("Enter the student's first name: ");
                 firstName = Console.ReadLine();
                Console.WriteLine("Enter the student's last name");
                 lastName = Console.ReadLine();
                Console.WriteLine("Enter the student's birthdate (DD-MM-YYYY)");
                try
                {
                     birthdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
                finally
                {
                    birthdate = new DateTime(0);
                }
                Console.WriteLine("Enter the student's adress line 1: ");
                 adress1 = Console.ReadLine();
                Console.WriteLine("Enter the student's adress line 2: ");
                 adress2 = Console.ReadLine();
                Console.WriteLine("Enter the student's City: ");
                 city = Console.ReadLine();
                Console.WriteLine("Enter the student's state/province: ");
                 state = Console.ReadLine();
                Console.WriteLine("Enter the student's zip code: ");
                try
                {
                     zipcode = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                finally
                {
                    zipcode = 0;
                }
                Console.WriteLine("Enter the student's Country: ");
                 country = Console.ReadLine();
            }


            static void GetTeacherInformation(out string firstName, out string lastName, out DateTime birthdate, out string adress1, out string adress2, out string city, out string state, out int zipcode, out string country)
            {
                Console.WriteLine("Enter the teacher's first name: ");
                 firstName = Console.ReadLine();
                Console.WriteLine("Enter the teacher's last name");
                 lastName = Console.ReadLine();
                Console.WriteLine("Enter the teacher's birthdate (DD-MM-YYYY)");
                try
                {
                     birthdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
                finally
                {
                    birthdate = new DateTime(0);
                }
                Console.WriteLine("Enter the teacher's adress line 1: ");
                 adress1 = Console.ReadLine();
                Console.WriteLine("Enter the teacher's adress line 2: ");
                 adress2 = Console.ReadLine();
                Console.WriteLine("Enter the teacher's City: ");
                 city = Console.ReadLine();
                Console.WriteLine("Enter the teacher's state/province: ");
                 state = Console.ReadLine();
                Console.WriteLine("Enter the teacher's zip code: ");
                try
                {
                     zipcode = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                finally
                {
                    zipcode = 0;
                }
                Console.WriteLine("Enter the teacher's Country: ");
                 country = Console.ReadLine();
            }

            static void GetCourseInformation(out string name, out int credits, out int duration, out string teacher)
            {
                Console.WriteLine("Enter Course Name:");
                 name = Console.ReadLine();
                Console.WriteLine("Enter course credits:");
                try
                {
                     credits = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    credits = 0;
                }
                Console.WriteLine("Enter course duration in weeks:");
                try
                {
                     duration = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    duration = 0;
                }
                Console.WriteLine("Enter teacher for this course :");
                 teacher = Console.ReadLine();

            }

            static void GetUPgromInformation(out string name, out string departmentHead, out string degrees)
            {
                Console.WriteLine("Enter program's name:");
                 name = Console.ReadLine();
                Console.WriteLine("Enter program's department head:");
                 departmentHead = Console.ReadLine();
                Console.WriteLine("Enter program's degrees:");
                 degrees = Console.ReadLine();
            }

            static void GetDegreeInformation(out string name, out int creditsRequired)
            {
                Console.WriteLine("Enter the degree's name:");
                 name = Console.ReadLine();
                Console.WriteLine("Enter the degree's required credits:");
                try
                {
                     creditsRequired = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    creditsRequired = 0;
                }
            }

            #endregion

            #region Printing Informations
            
            static void PrintStudentDetails(string firstName, string lastName, DateTime birthdate, string adress1, string adress2, string city, string stateProvince, int zipCode, string Country)
            {
            Console.Clear();
                Console.WriteLine("Student :");
                Console.WriteLine("First Name: {0}", firstName);
                Console.WriteLine("Last Name: {0}", lastName);
                Console.WriteLine("Birthdate : {0}", birthdate.Day + birthdate.Month + birthdate.Year);
                Console.WriteLine("Adress Line 1 : {0}", adress1);
                Console.WriteLine("Adress Line 2 : {0}", adress2);
                Console.WriteLine("City : {0}", city);
                Console.WriteLine("State/Province : {0}", stateProvince);
                Console.WriteLine("Zip/Postal : {0}", zipCode.ToString());
                Console.WriteLine("Country : {0}", Country);
             }

            static void PrintTeachertDetails(string firstName, string lastName, DateTime birthdate, string adress1, string adress2, string city, string stateProvince, int zipCode, string Country)
            {
            Console.Clear();
                Console.WriteLine("Teacher :");
                Console.WriteLine("First Name: {0}", firstName);
                Console.WriteLine("Last Name: {0}", lastName);
                Console.WriteLine("Birthdate : {0}", birthdate.Day + birthdate.Month + birthdate.Year);
                Console.WriteLine("Adress Line 1 : {0}", adress1);
                Console.WriteLine("Adress Line 2 : {0}", adress2);
                Console.WriteLine("City : {0}", city);
                Console.WriteLine("State/Province : {0}", stateProvince);
                Console.WriteLine("Zip/Postal : {0}", zipCode.ToString());
                Console.WriteLine("Country : {0}", Country);
            }
            
            static void PrintCourseDetails(string name, int credits, int duration, string teacher)
            {
            Console.Clear();
            Console.WriteLine("Course : {0}", name);
                Console.WriteLine("Credits : {0}", credits.ToString());
                Console.WriteLine("Duration (in weeks) : {0}", duration);
                Console.WriteLine("Teacher : {0}", teacher);
            }

            static void PrintUProgrammDetails(string name, string departementHead, string degrees)
            {
            Console.Clear();
            Console.WriteLine("UProgram : {0}", name);
                Console.WriteLine("Departement Head : {0}", departementHead);
                Console.WriteLine("Degrees : {0}", degrees);
            }

            static void PrintDegreeDetails(string name, int creditsRequired)
            {
            Console.Clear();
            Console.WriteLine("Degree :{0}", name);
                Console.WriteLine("Credits Required : {0}", creditsRequired.ToString());
            }


            #endregion


        static bool ValidateStudentBirthday(DateTime birthday)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
