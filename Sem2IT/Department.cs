using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class Department
    {
        public string Name
        {
            get;
            set;
        }

        public List<Group> Groups
        {
            get;
            private set;
        }

        public List<Teacher> Teachers
        {
            get;
            private set;
        }

        public Department()
        {
            Groups = new List<Group>();
            Teachers = new List<Teacher>();
        }

        public Department(string name) : this()
        {
            Name = name;
        }

        public void AddGroup(Group group)
        {
            group.Department = this;
            Groups.Add(group);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
    }
}
