using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            float media = 25.0f / 2;
            Console.WriteLine("{0}",media);

            //3 + 4 = 34
            Console.WriteLine("3 + 4 = "+ 3 + 4);

            //7 = 3 + 4
            Console.WriteLine(3 + 4 + " = 3 + 4");

            //3 + 4 = 7
            Console.WriteLine("3 + 4 = " + (3 + 4));

            long longo = 34l;

            //Como o tipo long é maior que o inteiro, é necessario fazer a conversão explitamente
            int inteiro = Convert.ToInt32(longo);

            //Tem o mesmo efeito do código de cima
            int inteiro2 = (int) longo;

            Console.WriteLine("{0} {1} ", inteiro, inteiro2);

            double dobro = longo;
            decimal dicimal = longo + 5;
            long longo2 = (long) dicimal;

            Console.WriteLine("{0} {1}", dobro, dicimal);

            int i = 3;
            long l = 3L;
            double d = 3.0;
            decimal m = 3.0M;
            String s = "3.0";

            s = Convert.ToString(i);
            m = Convert.ToDecimal(d);
            d = Convert.ToDouble(m);

        }
    }
}
