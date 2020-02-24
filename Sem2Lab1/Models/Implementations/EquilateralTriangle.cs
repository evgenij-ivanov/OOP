using System;
using System.Collections.Generic;
using System.Text;
using Sem2Lab1.Implementations.Utility;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Implementations
{
    /// <summary>
    /// Равностронний треугольник
    /// </summary>
    public class EquilateralTriangle : Triangle, ITriangle
    {
        public EquilateralTriangle(double edgeLength, double angleA, double angleB) : base(edgeLength, angleA, angleB)
        {
        }

        public double Area
        {
            get
            {
                return EdgeLength * EdgeLength * Math.Sqrt(3.0) / 4.0;

            }
        }

        public double Perimeter
        {
            get
            {
                return 3 * EdgeLength;
            }
        }
    }
}
