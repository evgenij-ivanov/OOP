using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class Teacher : AbstractPerson
    {
        public Teacher(string lastName, string firstName, string secondName) : base(lastName, firstName, secondName)
        {
        }

        public Department Department
        {
            get;
            set;
        }
    }
}
