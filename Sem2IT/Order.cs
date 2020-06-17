using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public abstract class Order
    {
        protected string content;

        protected string GetContent()
        {
            List<Student> students = GetStudentsInOrder();
            string result = $"{GetHeader()}\n{GetMainContent(students)}\n{GetFooter()}";
            Follow(students);
            return result;
        }

        protected abstract void Follow(List<Student> students);

        protected abstract List<Student> GetStudentsInOrder();

        protected string GetHeader()
        {
            string result = "МИНОБРНАУКИ РОССИИ\n";
            result += "Федеральное государственное автономное образовательное учреждение высшего образования ";
            result += "\"Южный федеральный университет\"\n";
            result += "(ЮЖНЫЙ ФЕДЕРАЛЬНЫЙ УНИВЕРСИТЕТ)\n";
            result += $"ПРИКАЗ № {Number}\n";
            result += $"{DateTime.Now.ToString("dd.MM.yyyy")}";
            return result;
        }

        protected abstract string GetMainContent(List<Student> students);

        protected string GetFooter()
        {
            string result = "____________ Иванов И.И.\n";
            result += "____________ Петров П.П.\n";
            result += "____________ Лызь Л.Л.\n";
            result += "____________ Сидоров С.С.";
            return result;
        }

        public int Number
        {
            get;
            private set;
        }



        public string Content
        {
            get
            {
                if (String.IsNullOrEmpty(content))
                {
                    Number = University.Deanery.Orders.Count;
                    content = GetContent();

                }
                return content;
            }
        }
    }
}
