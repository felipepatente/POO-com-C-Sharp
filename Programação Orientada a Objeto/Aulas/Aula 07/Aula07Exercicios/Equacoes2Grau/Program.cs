using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacoes2Grau
{
    class Program
    {
        static void Main(string[] args)
        {
            //1° Forma
            Console.Write("Digite o valor do coeficiente a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do coeficiente b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do coeficiente c: ");
            double c = double.Parse(Console.ReadLine());


            Equacao equacao = new Equacao(a, b, c);
            double delta = equacao.GetDelta();

            if (delta >= 0)
            {
                Console.WriteLine("O valor do delta é de {0} com os valores das raizes de x1 = {1} e x2 = {2}",
                delta, equacao.GetX1(), equacao.GetX2());
            }else
            {
                Console.WriteLine("Não existe valores para raizes com delta negativo");
            }



            //2°Forma
            Console.Write("Digite o valor do coeficiente a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do coeficiente b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do coeficiente c: ");
            c = double.Parse(Console.ReadLine());


            Equacao equacao2 = new Equacao();
            delta = equacao2.GetDelta(a, b, c);


            if (delta >= 0)
            {
                Console.WriteLine("O valor do delta é de {0} com os valores das raizes de x1 = {1} e x2 = {2}",
                delta, equacao.GetX1(delta), equacao.GetX2(delta));
            }
            else
            {
                Console.WriteLine("Não existe valores para raizes com delta negativo");
            }

        }
    }
}
