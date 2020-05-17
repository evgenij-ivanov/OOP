using Sem2Lab1.Interfaces;

namespace Sem2Lab1.Factories
{
    public abstract class TriangleFactory
    {
        public abstract ITriangle Create(double edgeLength, double angleA, double angleB);
    }
}
