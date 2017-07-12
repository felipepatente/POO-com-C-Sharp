using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutarTriangulo
{
    public class Triangulo
    {
        public double l1, l2, l3;

        public Triangulo(double l1, double l2, double l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public bool EhIgual(Triangulo other)
        {

            bool igual1 = l1 == other.l1 && l2 == other.l2 && l3 == other.l3;
            bool igual2 = l1 == other.l2 && l2 == other.l3 && l3 == other.l1;
            bool igual3 = l1 == other.l3 && l2 == other.l1 && l3 == other.l2;

            return igual1 || igual2 || igual3;

        }

    }
}
