using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class GraduateWork
    {
        public string Name
        {
            get;
            set;
        }

        public Student Student
        {
            get;
            set;
        }

        public Teacher Supervisor
        {
            get;
            set;
        }

        public bool IsSuccessfullyDefenced
        {
            get;
            set;
        }
    }
}
