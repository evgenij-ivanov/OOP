using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class TransferOrder : Order
    {
        protected override void Follow(List<Student> students)
        {
            HashSet<Group> groups = new HashSet<Group>();
            foreach (var student in students)
            {
                if (!groups.Contains(student.Group))
                {
                    student.Group.YearNumber++;
                    groups.Add(student.Group);
                }
            }
        }

        protected override string GetMainContent(List<Student> students)
        {
            string result = "На основании решения Учёного совета прикаказываю:\n";
            result += "\tОсуществить перевод следующих студентов на второй курс:\n";
            foreach (var student in students)
            {
                if (student.Group.YearNumber == 1)
                {
                    result += $"\t\t{student.LastName} {student.FirstName} {student.SecondName}, гр.{student.Group.Name}\n";
                }
            }
            result += "\tОсуществить перевод следующих студентов на третий курс:\n";
            foreach (var student in students)
            {
                if (student.Group.YearNumber == 2)
                {
                    result += $"\t\t{student.LastName} {student.FirstName} {student.SecondName}, гр.{student.Group.Name}\n";
                }
            }
            result += "\tОсуществить перевод следующих студентов на четвёртый курс:\n";
            foreach (var student in students)
            {
                if (student.Group.YearNumber == 3)
                {
                    result += $"\t\t{student.LastName} {student.FirstName} {student.SecondName}, гр.{student.Group.Name}\n";
                }
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
                    if (group.YearNumber == 4)
                    {
                        continue;
                    }
                    foreach (var student in group.Students)
                    {
                        if (CanTransfer(student))
                        {
                            students.Add(student);
                        }
                    }
                }    
            }
            return students;
        }



        private bool CanTransfer(Student student)
        {
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
