using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class ExpulsionOrder : Order
    {
        protected override void Follow(List<Student> students)
        {
            foreach (var student in students)
            {
                student.Group.Students.Remove(student);
            }
        }

        protected override string GetMainContent(List<Student> students)
        {
            string result = "На основании решения комиссии прикаказываю:\n";
            result += "\tОтчислисть студентов первого курса:\n";
            foreach (var student in students)
            {
                if (student.Group.YearNumber == 1)
                {
                    result += $"\t\t{student.LastName} {student.FirstName} {student.SecondName}, гр.{student.Group.Name}\n";
                }
            }
            result += "\tОтчислисть студентов второго курса:\n";
            foreach (var student in students)
            {
                if (student.Group.YearNumber == 2)
                {
                    result += $"\t\t{student.LastName} {student.FirstName} {student.SecondName}, гр.{student.Group.Name}\n";
                }
            }
            result += "\tОтчислисть студентов третьего курса:\n";
            foreach (var student in students)
            {
                if (student.Group.YearNumber == 3)
                {
                    result += $"\t\t{student.LastName} {student.FirstName} {student.SecondName}, гр.{student.Group.Name}\n";
                }
            }
            result += "\tОтчислисть студентов четвёртого курса:\n";
            foreach (var student in students)
            {
                if (student.Group.YearNumber == 4)
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
                    foreach (var student in group.Students)
                    {
                        if (CannotTransfer(student))
                        {
                            students.Add(student);
                        }
                    }
                }
            }
            return students;
        }

        private bool CannotTransfer(Student student)
        {
            if (student.Group.YearNumber == 4 && !student.GraduateWork.IsSuccessfullyDefenced)
            {
                return true;
            }
            foreach (var grade in student.Gradebook.Grades)
            {
                if (grade == Grade.Unsatisfactory)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
