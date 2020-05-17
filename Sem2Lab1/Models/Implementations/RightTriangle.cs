using Sem2Lab1.Implementations.Utility;
using Sem2Lab1.Interfaces;
using System;

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
                if (Geometry.AreAnglesEqual(AngleA, 90.0))
                {
                    double angleB = Geometry.DegreesToRadians(AngleB);
                    double height = Math.Tan(angleB) * EdgeLength / 2.0;
                    return EdgeLength * height;
                }
                else if (Geometry.AreAnglesEqual(AngleB, 90.0))
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

        public double Perimeter
        {
            get
            {
                if (Geometry.AreAnglesEqual(AngleA, 90.0))
                {
                    double angleB = Geometry.DegreesToRadians(AngleB);
                    double height = Math.Tan(angleB) * EdgeLength;
                    double hypotenuse = Math.Sqrt(EdgeLength * EdgeLength + height * height);
                    return hypotenuse + EdgeLength + height;
                }
                else if (Geometry.AreAnglesEqual(AngleB, 90.0))
                {
                    double angleA = Geometry.DegreesToRadians(AngleA);
                    double height = Math.Tan(angleA) * EdgeLength;
                    double hypotenuse = Math.Sqrt(EdgeLength * EdgeLength + height * height);
                    return hypotenuse + EdgeLength + height;
                }
                else
                {
                    double angleA = Geometry.DegreesToRadians(AngleA);
                    double edgeA = Math.Sin(angleA) * EdgeLength;
                    double edgeB = Math.Sqrt(EdgeLength * EdgeLength - edgeA * edgeA);
                    return edgeA + edgeB + EdgeLength;
                }
            }
        }
    }
}
