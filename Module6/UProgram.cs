using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
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

        public UProgram(string name, string departementHead, Degree degree = null)
        {
            Name = name;
            DepartementHead = departementHead;
            Degree = degree;


        }
    }
}
