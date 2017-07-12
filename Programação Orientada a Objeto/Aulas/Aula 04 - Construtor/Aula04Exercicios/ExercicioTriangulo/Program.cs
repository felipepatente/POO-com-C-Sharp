using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a 1° medida: ");
            int medida1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a 2° medida: ");
            int medida2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a 3° medida: ");
            int medida3 = int.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(medida1, medida2, medida3);

            if (triangulo.GetETriangulo())
            {
                Console.WriteLine("As medidas {0}, {1} e {2} formam um triângulo {3}.",
                    triangulo.medida1, triangulo.medida2, triangulo.medida3, triangulo.GetTipoTriangulo());
            }else
            {
                Console.WriteLine("As medidas {0}, {1} e {2} não formam um triângulo.",
                    triangulo.medida1, triangulo.medida2, triangulo.medida3);
            }
        }
    }
}
/*
Escreva um algoritmo que lê três medidas e verifica se elas formam um triângulo. 
Caso positivo, o algoritmo deve identificar qual o tipo de triângulo formado: equilátero, isósceles ou escaleno.

A saída deve estar no seguinte formato: 
“As medidas Medida 1, Medida 2 e Medida 3 formam um triângulo Tipo do Triângulo.”

Ou, no caso de não formar um triângulo: “As medidas Medida 1, Medida 2 e Medida 3 não formam um triângulo.”.
 */
