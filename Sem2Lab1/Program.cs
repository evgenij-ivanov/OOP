using System;
using Sem2Lab1.Implementations.Utility;

namespace Sem2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new TriangleManager();
            manager.Create(10.0, 20.0, 30.0);
            manager.DisplayTypeOfLastElement();
        }
    }
}
