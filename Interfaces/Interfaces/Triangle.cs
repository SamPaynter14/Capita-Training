using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle : IShape
    {
        public double height { get; set; }
        public double tBase { get; set; }

        public double Area()
        {
            return (height * tBase) / 2;
        }

        public double perimeter()
        {
            double aSquare = height * height;
            double bSquare = tBase * tBase;

            double cSquare = aSquare + bSquare;

            double c = Math.Sqrt(cSquare);

            return height + tBase + c;
        }
    }
}
