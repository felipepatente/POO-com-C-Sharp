using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutarTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.Write("Entre com L1 do T1: ");
            double l1t1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com L2 do T1: ");
            double l2t1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com L3 do T1: ");
            double l3t1 = double.Parse(Console.ReadLine());

            Console.Write("Entre com L1 do T2: ");
            double l1t2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com L2 do T2: ");
            double l2t2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com L3 do T2: ");
            double l3t2 = double.Parse(Console.ReadLine());

            //Processamento
            Triangulo t1 = new Triangulo(l1t1, l2t1, l3t1);
            Triangulo t2 = new Triangulo(l1t2, l2t2, l3t2);
            bool saoIguais = t1.EhIgual(t2);

            //Saida
            Console.WriteLine(saoIguais ? "São iguais" : "não são iguais");
        }
    }
}
