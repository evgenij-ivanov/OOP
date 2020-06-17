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
            var department2 = new Department("БИТ");
            var group = new Group(7, 2);
            var gradGroup = new Group(7, 4);
            var group3 = new Group(2, 1);
            var student = new Student("Иванов", "Евгений", "Александрович");
            var student2 = new Student("Тесленко", "Георгий", "Андреевич");
            var student3 = new Student("Лызь", "Владимир", "Александрович");
            var student4 = new Student("Стриженок", "Матвей", "Иванович");
            var student5 = new Student("Сёменов", "Семён", "Семёнович");
            var student6 = new Student("Поттер", "Гарри", "Дамблдорович");
            var student7 = new Student("Бэггинс", "Фродо", "Дрогович");
            var student8 = new Student("Уинстон", "Смит", "Большебратович");
            var student9 = new Student("Эйнштейн", "Альберт", "Германович");
            var teacher = new Teacher("Балабаева", "Ирина", "Юрьевна");
            var gradWork = new GraduateWork
            {
                Name = "Antigrade",
                Student = student2,
                IsSuccessfullyDefenced = true,
                Supervisor = teacher
            };
            var gradWork2 = new GraduateWork
            {
                Name = "Тема",
                Student = student5,
                IsSuccessfullyDefenced = false,
                Supervisor = teacher
            };
            var gradWork3 = new GraduateWork
            {
                Name = "Тема2",
                Student = student6,
                IsSuccessfullyDefenced = true,
                Supervisor = teacher
            };
            student2.GraduateWork = gradWork;
            student5.GraduateWork = gradWork2;
            student6.GraduateWork = gradWork3;
            group.AddStudent(student);
            group.AddStudent(student3);
            group.AddStudent(student4);
            gradGroup.AddStudent(student2);
            gradGroup.AddStudent(student5);
            gradGroup.AddStudent(student6);
            group3.AddStudent(student7);
            group3.AddStudent(student8);
            group3.AddStudent(student9);
            department.AddGroup(group);
            department.AddGroup(gradGroup);
            department2.AddGroup(group3);
            University.Departments.Add(department);
            University.Departments.Add(department2);
            student.Gradebook.Grades.Add(Grade.Good);
            student3.Gradebook.Grades.Add(Grade.Good);
            student4.Gradebook.Grades.Add(Grade.Excellent);
            student7.Gradebook.Grades.Add(Grade.Unsatisfactory);
            student8.Gradebook.Grades.Add(Grade.Satisfactory);
            student9.Gradebook.Grades.Add(Grade.Excellent);
        }
    }
}
