using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab2
{
    public class Credit : Application
    {
        public Credit(IPerson person) : base(person)
        { }

        public override void AcceptApplication()
        {
            Console.WriteLine("Завяка на кредит отправлена");
            Person.AcceptApplication();
        }
    }
}
