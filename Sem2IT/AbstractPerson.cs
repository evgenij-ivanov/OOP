using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public abstract class AbstractPerson
    {
        public string FirstName
        {
            get;
            set;
        }
        public string SecondName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }

        public AbstractPerson(string lastName, string firstName, string secondName)
        {
            LastName = lastName;
            FirstName = firstName;
            SecondName = secondName;
        }
    }
}
