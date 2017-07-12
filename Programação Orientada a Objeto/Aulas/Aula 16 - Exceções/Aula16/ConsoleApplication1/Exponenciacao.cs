using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes
{
    public class Exponenciacao : Operacao
    {

        public override double FazConta(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public override string ToString()
        {
            return "Exponenciacao";
        }
    }
}
