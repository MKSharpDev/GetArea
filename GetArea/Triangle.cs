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
                throw new ArgumentException("Сторона должна быть больше нуля");
            }
            if (a + b < c || b + c < a || c + a < b)
            {
                throw new ArgumentException("Сумма двух сторон треугольника всегда должна быть больше третьей");
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
