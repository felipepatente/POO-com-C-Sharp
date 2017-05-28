using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacao2Grau
{
    class Equacao
    {
        public double a, b, c;

        public Equacao(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetRaiz()
        {
            return Math.Pow(this.b, 2) - 4 * a * c;
        }

        public bool temRaiz()
        {
            return this.GetRaiz() >= 0;
        }

        public double GetX1()
        {
            return (-this.b + Math.Sqrt(this.GetRaiz())) / (2 * a);
        }

        public double GetX2()
        {
            return (-this.b - Math.Sqrt(this.GetRaiz())) / (2 * a);
        }
    }
}
