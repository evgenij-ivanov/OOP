using System;
using System.Collections.Generic;
using System.Text;
using Sem2Lab1.Factories;
using Sem2Lab1.Implementations.Utility;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1
{
    class TriangleManager
    {
        public List<ITriangle> Triangles
        {
            get;
            private set;
        }

        public ITriangle Create(double edgeLength, double angleA, double angleB)
        {
            TriangleFactory factory;
            if (IsTriangleEquilateral(edgeLength, angleA, angleB))
            {
                factory = new EquilateralTriangleFactory();
            }
            else if (IsTriangleIsosceles(edgeLength, angleA, angleB))
            {
                factory = new IsoscelesTriangleFactory();
            }
            else if (IsTriangleRight(edgeLength, angleA, angleB))
            {
                factory = new RightTriangleFactory();
            }
            else
            {
                factory = new ArbitraryTriangleFactory();
            }
            ITriangle triangle = factory.Create(edgeLength, angleA, angleB);
            Triangles ??= new List<ITriangle>();
            Triangles.Add(triangle);
            return triangle;
        }

        public void DisplayTypeOfLastElement()
        {
            if (Triangles.Count == 0)
            {
                Console.WriteLine("There is no elements");
                return;
            }
            Console.WriteLine($"Last item is {Triangles[Triangles.Count - 1].GetType()}");
        }

        public void DisplayAllElementTypes()
        {
            for (byte i = 0; i < Triangles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Item is {Triangles[i].GetType()}");
            }
        }

        private bool IsTriangleEquilateral(double edgeLength, double angleA, double angleB)
        {
            return Geometry.AreAnglesEqual(angleA, angleB) && Geometry.AreAnglesEqual(angleA, 60);
        }

        private bool IsTriangleIsosceles(double edgeLength, double angleA, double angleB)
        {
            double angleC = 180.0 - angleA - angleB;
            return Geometry.AreAnglesEqual(angleA, angleB) || Geometry.AreAnglesEqual(angleA, angleC) || Geometry.AreAnglesEqual(angleB, angleC);
        }

        private const double eps = 1e-4;

        private bool IsTriangleRight(double edgeLength, double angleA, double angleB)
        {
            double angleC = 180.0 - angleA - angleB;
            return Geometry.AreAnglesEqual(angleA, 90.0) || Geometry.AreAnglesEqual(angleB, 90.0) || Geometry.AreAnglesEqual(angleC, 90.0);
        }
    }
}
