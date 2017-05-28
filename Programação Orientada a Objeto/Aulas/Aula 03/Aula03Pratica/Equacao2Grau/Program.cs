using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacao2Grau
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

            Equacao equacao = new Equacao(a,b,c);

            if (equacao.temRaiz())
            {
                Console.WriteLine("Raiz X1: " + equacao.GetX1());
                Console.WriteLine("Raiz X2: " + equacao.GetX2());
            }else
            {
                Console.WriteLine("Não existe raizes para valores negativos");
            }
        }
    }
}
