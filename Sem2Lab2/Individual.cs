using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab2
{
    public class Individual : IPerson
    {
        public void AcceptApplication()
        {
            Console.WriteLine("Заявка физического лица принята");
        }
    }
}
