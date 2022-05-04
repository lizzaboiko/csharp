using System;
namespace ClassLibraryCone
{
    public class ConeSq
    {
        public double r;
        public double h;
        public ConeSq(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
        public double SquareBase()
        {
            double basesq = Math.PI * r * r;
            return basesq;
        }
        public double SquareCone()
        {
            double fullsq = Math.PI * r * (r + Math.Sqrt(r*r + h*h));
            return fullsq;
        }
    }
}
