using Sem2Lab1.Implementations;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Factories
{
    class RightTriangleFactory : TriangleFactory
    {
        public override ITriangle Create(double edgeLength, double angleA, double angleB)
        {
            return new RightTriangle(edgeLength, angleA, angleB);
        }
    }
}
