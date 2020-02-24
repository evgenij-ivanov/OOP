using System;
using System.Collections.Generic;
using System.Text;
using Sem2Lab1.Implementations.Utility;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Implementations
{
    /// <summary>
    /// Произвольный треугольник
    /// </summary>
    class ArbitraryTriangle : Triangle, ITriangle
    {
        public ArbitraryTriangle(double edgeLength, double angleA, double angleB) : base(edgeLength, angleA, angleB)
        {
        }

        public double Area
        {
            get
            {

                double angleC = 180.0 - AngleA - AngleB;
                angleC = Geometry.DegreesToRadians(angleC);
                double angleB = Geometry.DegreesToRadians(AngleB);
                double edgeLengthB = EdgeLength * Math.Sin(angleB) / Math.Sin(angleC);
                double angleA = Geometry.DegreesToRadians(AngleA);
                double height = edgeLengthB * Math.Sin(angleA);
                return height * EdgeLength / 2.0;
            }
        }

        public double Perimeter
        {
            get
            {
                double angleC = 180.0 - AngleA - AngleB;
                angleC = Geometry.DegreesToRadians(angleC);
                double angleB = Geometry.DegreesToRadians(AngleB);
                double angleA = Geometry.DegreesToRadians(AngleA);
                double edgeLengthB = EdgeLength * Math.Sin(angleB) / Math.Sin(angleC);
                double edgeLengthA = EdgeLength * Math.Sin(angleA) / Math.Sin(angleC);
                return EdgeLength + edgeLengthA + edgeLengthB;
            }
        }
    }
}
