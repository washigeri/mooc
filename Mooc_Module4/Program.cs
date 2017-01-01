using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooc_Module4
{
    class Program
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

        public enum Day { Monday, Tuesday,  Wednesday, Thursday, Friday, Saturday, Sunday, };
        public enum Month { January, February, March, April, May, June, July, August, September, October, November, December };
        

        static void Main(string[] args)
        {
            string[] array = new string[10];
            for (int i=0; i< array.Length; i++)
            {
                array[i] = ("arrValue" + i.ToString());
            }
            int k = 0;
            while (k < array.Length)
            {
                Console.WriteLine("Array Value {0}: {1}", k, array[k]);
                k++;
            }

            Day[] array2 = { Day.Monday, Day.Tuesday, Day.Thursday, Day.Wednesday, Day.Friday, Day.Saturday, Day.Sunday };
            Console.WriteLine("Day : {0}", array2[4]);

        }
    }
}
