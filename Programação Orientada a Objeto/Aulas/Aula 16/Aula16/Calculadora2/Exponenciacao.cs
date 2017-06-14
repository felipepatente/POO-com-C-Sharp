using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    class Exponenciacao : Operacao
    {
        public override double Calcula(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public override string GetSimbolo()
        {
            return "^";
        }

        public override string ToString()
        {
            return "Exponenciação";
        }
    }
}
