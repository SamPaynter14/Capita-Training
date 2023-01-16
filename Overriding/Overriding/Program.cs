using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaofSquare areaSquare = new AreaofShapes();

            double a = 10.00;
            double b = 10.00;
            double area = 0.0;
            area = areaSquare.Square(a, b);
            Console.WriteLine($"Area of square: {area}");
            Console.ReadLine();
        }
    }
}
