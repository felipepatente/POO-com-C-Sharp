using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            int delta = (b * b) - 4 * a * c;
            int x1 = 0, x2 = 0;

            if (delta >= 0)
            {
                b = -b;
                delta = (int)Math.Sqrt(delta);
                a *= 2;
                x1 = (b + delta) / a;
                x2 = (b - delta) / a;

                Console.WriteLine("\nX1: " + x1);
                Console.WriteLine("X2: " + x2);
            }
            else
            {
                Console.WriteLine("Não existe raiz real para delta negativo!");
            }
        }
    }
}
