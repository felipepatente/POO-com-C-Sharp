using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes
{
    public class Fatorial : Operacao
    {
        public override double FazConta(double num)
        {
            double fat = 1;
            for (int i = 1; i <= num; i++)
            {
                fat *= i;
            }

            return fat;
        }


        public override string ToString()
        {
            return "Fatorial";
        }
    }
}
