using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab2
{
    public class Deposit : Application
    {
        public Deposit(IPerson person) : base(person)
        { }

        public override void AcceptApplication()
        {
            Console.WriteLine("Завяка на депозит отправлена");
            Person.AcceptApplication();
        }
    }
}
