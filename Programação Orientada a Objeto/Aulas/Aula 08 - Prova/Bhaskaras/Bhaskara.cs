using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskaras
{
    public class Bhaskara
    {
        private double a;
        private double b;
        private double c;
        
        public Bhaskara(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetDelta()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public double GetX1()
        {
            return (-b + Math.Sqrt(GetDelta())) / (2 * a);
        }

        public double GetX2()
        {
            return (-b - Math.Sqrt(GetDelta())) / (2 * a);
        }
    }
}
