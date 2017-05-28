using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskarAvessas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma parábola que intercepta o eixo x1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Digite uma parábola que intercepta o eixo x2: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            int c = int.Parse(Console.ReadLine());

            int somaRaiz = x1 + x2;
            int multRaiz = x1 * x2;
            int a = multRaiz / multRaiz;
            int b = (somaRaiz / a) * -1 ;

            Console.WriteLine("\nA = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);

        }
    }
}
