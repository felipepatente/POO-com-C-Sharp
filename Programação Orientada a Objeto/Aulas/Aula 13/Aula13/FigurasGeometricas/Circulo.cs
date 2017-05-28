using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Circulo : Geometria
    {
        private double raio;

        public Circulo(double raio) : base(0, 0)
        {
            this.raio = raio;
        }

        public override double GetPerimetro()
        {
            return 2 * 3.14 * raio;
        }

        public override double GetArea()
        {
            return 3.14 * (raio * raio);
        }
    }
}
