using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskaras
{
    public class Equacao2Grau
    {
        private double a;
        private double b;
        private double c;

        public Equacao2Grau(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public double GetDelta()
        {
            return Math.Pow(this.b, 2) - 4 * this.a * this.c;
        }

        
        public double GetX1()
        {
            double delta = this.GetDelta();
            double x1 = 0;

            if (delta >= 0)
            {
                x1 = (-this.b + Math.Sqrt(delta)) / (this.a * 2);
            }

            return x1;
        }


        public double GetX2()
        {
            double delta = this.GetDelta();
            double x2 = 0;

            if (delta >= 0)
            {
                x2 = (-this.b - Math.Sqrt(this.GetDelta())) / (2 * a);
            }

            return x2;
        }
    }
}
