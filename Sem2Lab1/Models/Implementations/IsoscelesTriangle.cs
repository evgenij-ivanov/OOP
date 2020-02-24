using System;
using System.Collections.Generic;
using System.Text;
using Sem2Lab1.Implementations.Utility;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Implementations
{
    /// <summary>
    /// Равнобедренный треугольник
    /// </summary>
    class IsoscelesTriangle : Triangle, ITriangle
    {
        public IsoscelesTriangle(double edgeLength, double angleA, double angleB) : base(edgeLength, angleA, angleB)
        {
        }

        public double Area
        {
            get
            {
                double angleCInDegrees = 180.0 - AngleA - AngleB;
                double angleB = Geometry.DegreesToRadians(AngleB);
                double angleA = Geometry.DegreesToRadians(AngleA);
                if (Geometry.AreAnglesEqual(AngleA, AngleB))
                {
                    double halfEdge = EdgeLength / 2.0;
                    double height = Math.Tan(angleA) * halfEdge;
                    return halfEdge * height;
                }
                else if (Geometry.AreAnglesEqual(AngleA, angleCInDegrees))
                {
                    return EdgeLength * EdgeLength * Math.Sin(angleB) / 2.0;
                }
                else
                {
                    return EdgeLength * EdgeLength * Math.Sin(angleA) / 2.0;
                }
            }
        }

        public double Perimeter
        {
            get
            {
                double angleCInDegrees = 180.0 - AngleA - AngleB;
                double angleB = Geometry.DegreesToRadians(AngleB);
                double angleA = Geometry.DegreesToRadians(AngleA);
                double angleC = Geometry.DegreesToRadians(angleCInDegrees);
                if (Geometry.AreAnglesEqual(AngleA, AngleB))
                {
                    double halfEdge = EdgeLength / 2.0;
                    double secondEdge = halfEdge / Math.Cos(angleA);
                    return EdgeLength + 2 * secondEdge;
                }
                else if (Geometry.AreAnglesEqual(AngleA, angleCInDegrees))
                {
                    double tBase = EdgeLength * Math.Sin(angleB) / Math.Sin(angleC);
                    return tBase + 2 * EdgeLength;
                }
                else
                {
                    double tBase = EdgeLength * Math.Sin(angleA) / Math.Sin(angleC);
                    return tBase + 2 * EdgeLength;
                }
            }
        }
    }
}
