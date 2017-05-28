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

            Console.Write("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine());

            Equacao2Grau equacao = new Equacao2Grau(a, b, c);

            if (equacao.GetDelta() >= 0)
            {
                Console.WriteLine("Valor de x1 = {0} e x2 = {1}", equacao.GetX1(), equacao.GetX2());
            }else
            {
                Console.WriteLine("Não existe raiz negativa");
            }

            Console.WriteLine(equacao.GetDelta());
        }
    }
}
/*Escreva um algoritmo que lê os coeficientes a, b e c da equação de 2º grau e 
 * que mostra as suas raízes, quando possível.*/
