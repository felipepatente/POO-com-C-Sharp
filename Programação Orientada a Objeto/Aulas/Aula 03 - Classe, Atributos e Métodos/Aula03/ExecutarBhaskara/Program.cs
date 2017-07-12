using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bhaskaraa;

namespace ExecutarBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double a = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double c = Double.Parse(Console.ReadLine());


            Class1 bhas = new Class1();
            bhas.a = a;
            bhas.b = b;
            bhas.c = c;
            bhas.delta = bhas.CalcularDelta();

            if (bhas.delta >= 0)
            {
                bhas.b = -bhas.b;
                bhas.delta = (int)Math.Sqrt(bhas.delta);
                bhas.a *= 2;
                bhas.x1 = (b + bhas.delta) / bhas.a;
                bhas.x2 = (b - bhas.delta) / bhas.a;

                Console.WriteLine("\nX1: " + bhas.x1);
                Console.WriteLine("X2: " + bhas.x2);
            }
            else
            {
                Console.WriteLine("Não existe raiz real para delta negativo!");
            }
        }
    }
}
