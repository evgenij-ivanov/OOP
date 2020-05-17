using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab2
{
    public abstract class Application
    {
        public IPerson Person
        {
            get;
            set;
        }

        public Application(IPerson person)
        {
            Person = person;
        }

        public abstract void AcceptApplication();
    }
}
