using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public static class Test
    {
        public static void Fill()
        {
            var department = new Department("МОП ЭВМ");
            var group = new Group(7, 2);
            var gradGroup = new Group(7, 4);
            var student = new Student("Иванов", "Евгений", "Александрович");
            var student2 = new Student("Тесленко", "Георгий", "Андреевич");
            var teacher = new Teacher("Балабаева", "Ирина", "Юрьевна");
            var gradWork = new GraduateWork
            {
                Name = "Antigrade",
                Student = student2,
                IsSuccessfullyDefenced = true,
                Supervisor = teacher
            };
            student2.GraduateWork = gradWork;
            group.AddStudent(student);
            gradGroup.AddStudent(student2);
            department.AddGroup(group);
            department.AddGroup(gradGroup);
            University.Departments.Add(department);
            student.Gradebook.Grades.Add(Grade.Good);
        }
    }
}
