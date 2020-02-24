using System;
using System.Collections.Generic;
using System.Text;
using Sem2Lab1.Implementations.Utility;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Implementations
{
    /// <summary>
    /// Прямоугольный треугольник
    /// </summary>
    class RightTriangle : Triangle, ITriangle
    {
        public RightTriangle(double edgeLength, double angleA, double angleB) : base(edgeLength, angleA, angleB)
        {
        }

        public double Area
        {
            get
            {
                double angleC = 180.0 - AngleA - AngleB;
                if (Geometry.AreAnglesEqual(AngleA, 90.0))
                {
                    double angleB = Geometry.DegreesToRadians(AngleB);
                    double height = Math.Tan(angleB) * EdgeLength / 2.0;
                    return EdgeLength * height;
                }
                else if(Geometry.AreAnglesEqual(AngleB, 90.0))
                {
                    double angleA = Geometry.DegreesToRadians(AngleA);
                    double height = Math.Tan(angleA) * EdgeLength / 2.0;
                    return EdgeLength * height;
                }
                else
                {
                    double angleA = Geometry.DegreesToRadians(AngleA);
                    double edgeA = Math.Sin(angleA) * EdgeLength;
                    double edgeB = Math.Sqrt(EdgeLength * EdgeLength - edgeA * edgeA);
                    return edgeA * edgeB / 2.0;
                }
            }
        }

        public double Perimeter => throw new NotImplementedException();
    }
}
