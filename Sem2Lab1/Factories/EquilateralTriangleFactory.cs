using Sem2Lab1.Implementations;
using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Factories
{
    public class EquilateralTriangleFactory : TriangleFactory
    {
        public override ITriangle Create(double edgeLength, double angleA, double angleB)
        {
            return new EquilateralTriangle(edgeLength, angleA, angleB);
        }
    }
}
