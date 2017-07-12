using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskaraa
{
    public class Class1
    {
        public double a, b, c, delta, x1, x2;

        public double CalcularDelta()
        {
            return (b * b) - 4 * a * c;
        }

        public double CalcularX1()
        {
            return (b + delta) / a;
        }

        public double CalcularX2()
        {
            return (b - delta) / a;
        }
    }
}
