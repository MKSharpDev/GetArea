using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArea
{
    public class Triangle : IFigure
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("The side must be greater than zero");
            }
            if (a + b < c || b + c < a || c + a < b)
            {
                throw new ArgumentException("The sum of two sides of a triangle must always be greater than the third");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            double p =  (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * ( p - b) * (p - c));
        }

        public bool IsRightAngled()
        {
            return (Math.Pow(a, 2) == ((Math.Pow(b, 2) + Math.Pow(c, 2))) ||
                (Math.Pow(b, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2))) ||
                (Math.Pow(c, 2) == (Math.Pow(b, 2) + Math.Pow(a, 2))));
        }
    }
}
