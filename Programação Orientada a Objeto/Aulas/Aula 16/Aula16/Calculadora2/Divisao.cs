using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    class Divisao : Operacao
    {
        public override double Calcula(double n1, double n2)
        {
            if (n2 == 0)
            {
                throw new DivisaoPorZeroException();
            }

            return n1 / n2;
        }

        public override string GetSimbolo()
        {
            return "/";
        }

        public override string ToString()
        {
            return "Divisão";
        }
    }
}
