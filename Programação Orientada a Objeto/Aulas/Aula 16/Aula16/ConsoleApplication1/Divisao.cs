using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes
{
    public class Divisao : Operacao
    {
        public override double FazConta(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ExceptionDivisaoPorZero();
            }

            return num1 / num2;
        }

        public override string ToString()
        {
            return "Divisão";
        }
    }
}
