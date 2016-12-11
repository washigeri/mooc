using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mooc
{
    class Program
    {
        static void Main(string[] args)
        {
            #region module1Student
            string studentFirstName = "";
            string studentLastName = "";
            DateTime studentBirthDate = new DateTime(0001, 01, 01);
            string studentAdressLine1 = "";
            string studentAdressLine2 = "";
            string studentCity = "";
            string studentState = "";
            int studentZipCode = 0;
            string studentCountry = "";
            //====================================================================
            Console.Clear();
            Console.WriteLine("First Name?");
            studentFirstName = Console.ReadLine();
            Console.WriteLine("Last Name?");
            studentLastName = Console.ReadLine();
            Console.WriteLine("Birth Date? (ex: 1996-08-08)");
            try
            {
                studentBirthDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            Console.WriteLine("Adress Line 1?");
            studentAdressLine1 = Console.ReadLine();
            Console.WriteLine("Adress Line 2?");
            studentAdressLine2 = Console.ReadLine();
            Console.WriteLine("City?");
            studentCity = Console.ReadLine();
            Console.WriteLine("State/Province?");
            studentState = Console.ReadLine();
            Console.WriteLine("Zip Code?");
            try
            {
                studentZipCode = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            Console.WriteLine("Country?");
            studentCountry = Console.ReadLine();

            //=====================================================================
            Console.Clear();
            Console.WriteLine("First Name: {0}\nLast Name: {1}\nBirth Date: {2}\nAdresse Line 1: {3}\nAdress Line 2:{4}\nCity: {5}\nState/Province: {6}\nZip Code: {7}\nCountry: {8}", studentFirstName, studentLastName, studentBirthDate.ToString(), studentAdressLine1, studentAdressLine2, studentCity, studentState, studentZipCode.ToString(), studentCountry);
            #endregion
        }
    }
}