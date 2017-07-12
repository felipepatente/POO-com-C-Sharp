using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a figura geometrica desejada (1 - Retangulo ou 2 - circulo): ");
            string tipoFigura = Console.ReadLine();


            Geometria geometria;
            if (tipoFigura == "1")
            {
                Console.Write("Digite o lado 1: ");
                double lado1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o lado 2: ");
                double lado2 = double.Parse(Console.ReadLine());

                geometria = new Retangulo(lado1, lado2);

                Console.WriteLine("Perímetro do retângulo: {0}", geometria.GetPerimetro());
                Console.WriteLine("Área do retângulo: {0}", geometria.GetArea());
            }
            else
            {
                Console.Write("Digite o raio: ");
                double raio = double.Parse(Console.ReadLine());

                geometria = new Circulo(raio);

                Console.WriteLine("Perímetro do retângulo: {0}", geometria.GetPerimetro());
                Console.WriteLine("Área do retângulo: {0}", geometria.GetArea());
            }
        }
    }
}
