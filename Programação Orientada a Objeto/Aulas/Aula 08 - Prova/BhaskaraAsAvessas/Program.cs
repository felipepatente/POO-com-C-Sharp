using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskaraAsAvessas
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

            BhaskaraAsAvessa ba = new BhaskaraAsAvessa(x1, x2, c);

            double somaRaiz = ba.GetSomaRaiz();
            double multRaiz = ba.GetMultRaiz();
            double a = ba.GetA(multRaiz);
            double b = ba.GetB(somaRaiz, a);
            
            Console.WriteLine("\nA = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
        }
    }
}
