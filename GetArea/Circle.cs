using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArea
{
    public class Circle : IFigure
    {
        double radius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be greater than zero");
            }
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
