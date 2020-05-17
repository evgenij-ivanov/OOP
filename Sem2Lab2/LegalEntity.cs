using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab2
{
    public class LegalEntity : IPerson
    {
        public void AcceptApplication()
        {
            Console.WriteLine("Заявка юридического лица принята");
        }
    }
}
