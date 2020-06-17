using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2IT
{
    public partial class StudentsForm : Form
    {
        private Group Group
        {
            get;
            set;
        }

        public StudentsForm(Group group)
        {
            Group = group;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var groups = new Groups();
            groups.ShowDialog();
            this.Close();
        }

        private void FillStudents()
        {
            foreach (var student in Group.Students)
            {
                string result = $"{student.LastName} {student.FirstName} {student.SecondName}; {student.Group.Name}; ";
                Dictionary<Grade, int> gradesNumber = new Dictionary<Grade, int>();
                gradesNumber.Add(Grade.Excellent, 0);
                gradesNumber.Add(Grade.Good, 0);
                gradesNumber.Add(Grade.Satisfactory, 0);
                gradesNumber.Add(Grade.Unsatisfactory, 0);
                foreach (var grade in student.Gradebook.Grades)
                {
                    gradesNumber[grade]++;
                }
                result += $"{Grade.Unsatisfactory.ToString()} - {gradesNumber[Grade.Unsatisfactory]}; ";
                result += $"{Grade.Satisfactory.ToString()} - {gradesNumber[Grade.Satisfactory]}; ";
                result += $"{Grade.Good.ToString()} - {gradesNumber[Grade.Good]}; ";
                result += $"{Grade.Excellent.ToString()} - {gradesNumber[Grade.Excellent]}; ";
                if (Group.YearNumber == 4)
                {
                    result += $"\nТема дипломной работы: {student.GraduateWork.Name}; ";
                    var teacher = student.GraduateWork.Supervisor;
                    result += $"руководитель {teacher.LastName} {teacher.FirstName} {teacher.SecondName}";
                }
                listView.Items.Add(result);
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            FillStudents();
        }
    }
}
