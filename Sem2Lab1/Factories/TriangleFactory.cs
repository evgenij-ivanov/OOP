using System;
using System.Collections.Generic;
using System.Text;
using Sem2Lab1.Implementations.Utility;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Factories
{
    public abstract class TriangleFactory
    {
        public abstract ITriangle Create(double edgeLength, double angleA, double angleB);
    }
}
