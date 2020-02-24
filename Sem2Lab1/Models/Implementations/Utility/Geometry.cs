using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab1.Implementations.Utility
{
    public class Geometry
    {
        private static double eps = 1e-6;

        public static double DegreesToRadians(double a)
        {
            return a * Math.PI / 180.0;
        }

        public static bool AreAnglesEqual(double a, double b)
        {
            return Math.Abs(a - b) < eps;
        }
    }
}
