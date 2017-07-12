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

            if (tipoFigura == "1")
            {
                Console.Write("Digite o lado 1: ");
                double lado1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o lado 2: ");
                double lado2 = double.Parse(Console.ReadLine());

                Retangulo re = new Retangulo(lado1, lado2);

                Console.WriteLine("Perímetro do retângulo: {0}", re.GetPerimetro());
                Console.WriteLine("Área do retângulo: {0}", re.GetArea());
            }else
            {
                Console.Write("Digite o raio: ");
                double raio = double.Parse(Console.ReadLine());
                
                Circulo cir = new Circulo(raio);

                Console.WriteLine("Perímetro do retângulo: {0}", cir.GetPerimetro());
                Console.WriteLine("Área do retângulo: {0}", cir.GetArea());
            }
        }
    }
}
/*
 * Você está desenvolvendo um sistema para aprendizado de geometria onde, na primeira versão, 
 * o estudante irá aprender sobre retângulos e círculos:

Os retângulos possuem coordenadas x e y e a medida de seus dois lados.
Os círculos possuem coordenadas x e y e a medida de seu raio.
Para cada figura geométrica, será possível calcular o perímetro e a área.

Escreva um programa que pergunta qual a figura que será estudada e lê os seus dados. Após isso, o programa deve 
mostrar o perímetro e a área da figura escolhida.
 */
