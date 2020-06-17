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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string expulsionOrder = University.Deanery.CreateOrder(new ExpulsionOrder());
            PrintInFile("expulsionOrder.txt", expulsionOrder);
            string scholarshipOrder = University.Deanery.CreateOrder(new ScholarshipOrder());
            PrintInFile("scholarshipOrder.txt", scholarshipOrder);
            string graduateOrder = University.Deanery.CreateOrder(new GraduateOrder());
            PrintInFile("graduateOrder.txt", graduateOrder);
            string transferOrder = University.Deanery.CreateOrder(new TransferOrder());
            PrintInFile("transferOrder.txt", transferOrder);
            printButton.Enabled = false;
        }

        private void PrintInFile(string filename, string content)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter($@"{filename}"))
            {
                file.WriteLine(content);
            }
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var groups = new Groups();
            groups.ShowDialog();
            this.Close();
        }
    }
}
