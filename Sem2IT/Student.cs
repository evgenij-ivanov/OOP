using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class Student : AbstractPerson
    {
        private Gradebook gradebook;

        public Student(string lastName, string firstName, string secondName, PaymentForm paymentForm) : base(lastName, firstName, secondName)
        {
            IsProvidedWithScholarship = false;
            PaymentForm = paymentForm;
            int gradebookNumber = 1;
            foreach (var department in University.Departments)
            {
                foreach (var group in department.Groups)
                {
                    gradebookNumber += group.Students.Count;
                }
            }
            Gradebook.Number = gradebookNumber.ToString();
        }

        public Student(string lastName, string firstName, string secondName) : this(lastName, firstName, secondName, PaymentForm.Budget)
        { }

        public PaymentForm PaymentForm
        {
            get;
            set;
        }

        public Gradebook Gradebook
        {
            get
            {
                if (gradebook == null)
                {
                    gradebook = new Gradebook();
                }
                return gradebook;
            }
        }

        public Group Group
        {
            get;
            set;
        }

        public GraduateWork GraduateWork
        {
            get;
            set;
        }

        public bool IsProvidedWithScholarship
        {
            get;
            set;
        }
    }
}
