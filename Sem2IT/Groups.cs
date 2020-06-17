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
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new Form1();
            main.ShowDialog();
            this.Close();
        }

        private void FillGroups()
        {
            foreach (var department in University.Departments)
            {
                foreach (var group in department.Groups)
                {
                    listView.Items.Add($"{group.Name} ({department.Name})");
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var groupInfo = listView.SelectedItems[0];
            var groupName = groupInfo.Text.Split(' ').First();
            this.Hide();
            var group = University.Departments.Where(x => x.Groups.Any(y => y.Name == groupName))
                .Select(x => x.Groups)
                .FirstOrDefault()
                .Where(x => x.Name == groupName)
                .FirstOrDefault();
            var studentsForm = new StudentsForm(group);
            studentsForm.ShowDialog();
            this.Close();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            FillGroups();
        }
    }
}
