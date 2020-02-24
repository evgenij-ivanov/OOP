using System;
using System.Collections.Generic;
using System.Text;
using Sem2Lab1.Implementations;
using Sem2Lab1.Implementations.Utility;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Factories
{
    class ArbitraryTriangleFactory : TriangleFactory
    {
        public override ITriangle Create(double edgeLength, double angleA, double angleB)
        {
            return new ArbitraryTriangle(edgeLength, angleA, angleB);
        }
    }
}
