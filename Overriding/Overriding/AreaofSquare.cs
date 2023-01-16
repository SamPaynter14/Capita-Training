using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class AreaofSquare
    {
        public virtual double Square(double a, double b)
        {
            Console.WriteLine("Calculate are of square power a^b");
            return Math.Pow(a, 2);
        }
    }
}
