using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class Group
    {
        public string Name
        {
            get
            {
                return $"КТбо{YearNumber}-{Number}";
            }
        }

        public int Number
        {
            get;
            set;
        }

        public int YearNumber
        {
            get;
            set;
        }

        public List<Student> Students
        {
            get;
            private set;
        }

        public Department Department
        {
            get;
            set;
        }

        public Group()
        {
            Students = new List<Student>();
        }

        public Group(int number, int yearNumber) : this()
        {
            Number = number;
            YearNumber = yearNumber;
        }

        public void AddStudent(Student student)
        {
            student.Group = this;
            Students.Add(student);
        }
    }
}
