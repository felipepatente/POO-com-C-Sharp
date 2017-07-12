using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes
{
    public class Multiplicacao : Operacao
    {
        public override double FazConta(double num1, double num2)
        {
            return num1 * num2;
        }

        public override string ToString()
        {
            return "Multiplicação";
        }
    }
}
