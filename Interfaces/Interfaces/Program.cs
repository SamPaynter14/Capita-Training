using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle tri = new Triangle();

            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;

            rec.height = a;
            rec.width = b;
            area = rec.Area();
            perimeter = rec.perimeter();

            Console.WriteLine($"Area of rectangle is: {area}");
            Console.WriteLine($"Perimeter of rectangleis : {perimeter}");
            Console.WriteLine("----------------------------------------");

            circle.radius = c;
            area = circle.Area();
            perimeter = circle.perimeter();

            Console.WriteLine($"Area of circle is: {area:F}");
            Console.WriteLine($"Perimeter of circle is: {perimeter:F}");
            Console.WriteLine("---------------------------------------");

            tri.height = a;
            tri.tBase = b;
            area = tri.Area();
            perimeter = tri.perimeter();

            Console.WriteLine($"Area of triangle is: {area}");
            Console.WriteLine($"Perimeter of triangle is : {perimeter:F}");
            Console.ReadLine();
            



        }
    }
}
