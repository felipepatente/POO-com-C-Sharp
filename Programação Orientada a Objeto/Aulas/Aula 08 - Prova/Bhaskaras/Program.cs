
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskaras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            Bhaskara ba = new Bhaskara(a,b,c);

            double delta = ba.GetDelta();
            if (delta >= 0)
            {
                Console.WriteLine("Valor do delta = {0:f2}, X1 = {1:f2} e X2 = {2:f2}", delta, ba.GetX1(), ba.GetX2());
            }else
            {
                Console.WriteLine("Não existe raizes com valores negativos");
            }
        }
    }
}
