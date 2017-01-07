using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Degree
    {
        public string Name { get; set; }
        public int CreditsRequired { get; set; }
        internal Course Course { get; set; }

        public Degree(string name, int creditsRequired, Course course = null)
        {
            Name = name;
            CreditsRequired = creditsRequired;
            Course = course;
        }
    }
}
