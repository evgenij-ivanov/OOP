using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class Gradebook
    {
        public string Number
        {
            get;
            set;
        }

        public List<Grade> Grades
        {
            get;
            private set;
        }

        public Gradebook()
        {
            Grades = new List<Grade>();
        }

        public Gradebook(string gradebookNumber) : this()
        {
            Number = gradebookNumber;
        }
    }
}
