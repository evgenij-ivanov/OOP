using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class ScholarshipOrder : Order
    {
        protected override void Follow(List<Student> students)
        {
            foreach (var student in students)
            {
                student.IsProvidedWithScholarship = true;
            }
        }

        protected override string GetMainContent(List<Student> students)
        {
            string result = "На основании решения Учёного совета прикаказываю:\n";
            result += "\tОбеспечить ежемесячную выплаты стипендию в период с 1 августа по 1 февраля следующим студентам:\n";
            foreach (var student in students)
            {
                result += $"\t\t{student.LastName} {student.FirstName} {student.SecondName}, гр.{student.Group.Name}\n";
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
                        if (CanHaveScholarship(student))
                        {
                            students.Add(student);
                        }
                    }
                }
            }
            return students;
        }

        private bool CanHaveScholarship(Student student)
        {
            if (student.PaymentForm == PaymentForm.Paid)
            {
                return false;
            }
            foreach (var grade in student.Gradebook.Grades)
            {
                if (grade == Grade.Unsatisfactory || grade == Grade.Satisfactory)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
