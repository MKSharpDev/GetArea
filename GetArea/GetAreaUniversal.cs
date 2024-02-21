using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArea
{
    public class GetAreaUniversal
    {
        IFigure figure;
        public GetAreaUniversal(IFigure figure)
        {
            this.figure = figure;
        }
        public double Result() => figure.GetArea();
    }
}
