using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Retangulo : Geometria
    {

        private double lado1;
        private double lado2;

        public Retangulo(double lado1, double lado2) : base(0,0)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public double GetPerimetro()
        {
            return 2 * lado1 + 2 * lado2;
        }

        public double GetArea()
        {
            return lado1 * lado2;
        }

    }
}
