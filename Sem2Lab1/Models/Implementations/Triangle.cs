namespace Sem2Lab1.Implementations
{
    public abstract class Triangle
    {
        protected double EdgeLength
        {
            get;
            set;
        }

        protected double AngleA
        {
            get;
            set;
        }

        protected double AngleB
        {
            get;
            set;
        }

        public Triangle(double edgeLength, double angleA, double angleB)
        {
            EdgeLength = edgeLength;
            AngleA = angleA;
            AngleB = angleB;
        }
    }
}
