using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public static class University
    {
        private static List<Department> departments;
        private static Deanery deanery;

        public static List<Department> Departments
        {
            get
            {
                if (departments == null)
                {
                    departments = new List<Department>();
                }
                return departments;
            }
        }

        public static Deanery Deanery
        {
            get
            {
                if (deanery == null)
                {
                    deanery = new Deanery();
                }
                return deanery;
            }
        }
    }
}
