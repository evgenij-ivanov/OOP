using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class GraduateOrder : Order
    {
        protected override void Follow(List<Student> students)
        {
            HashSet<Group> groups = new HashSet<Group>();
            foreach (var student in students)
            {
                if (!groups.Contains(student.Group))
                {
                    groups.Add(student.Group);
                }
                student.Group.Students.Remove(student);
            }
            foreach (var group in groups)
            {
                group.Department.Groups.Remove(group);
            }
        }

        protected override string GetMainContent(List<Student> students)
        {
            string result = "На основании решения Учёного совета прикаказываю:\n";
            result += "\tПрисвоить следующим студентам, успешно защитившим свои квалификационные работы, звание бакалавра:\n";
            foreach (var student in students)
            {
                result += $"\t\t{student.LastName} {student.FirstName} {student.SecondName}, гр.{student.Group.Name}";
                var teacher = student.GraduateWork.Supervisor;
                result += $" ({student.GraduateWork.Name}; рук.{teacher.LastName} {teacher.FirstName} {teacher.LastName})\n";
            }
            return result;
        }

        protected override List<Student> GetStudentsInOrder()
        {
            List<Student> students = new List<Student>();
            foreach (var department in University.Departments)
            {
                foreach (var group in department.Groups)
                {
                    if (group.YearNumber != 4)
                    {
                        continue;
                    }
                    foreach (var student in group.Students)
                    {
                        if (CanGraduate(student))
                        {
                            students.Add(student);
                        }
                    }
                }
            }
            return students;
        }

        private bool CanGraduate(Student student)
        {
            if (!student.GraduateWork.IsSuccessfullyDefenced)
            {
                return false;
            }
            foreach (var grade in student.Gradebook.Grades)
            {
                if (grade == Grade.Unsatisfactory)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
