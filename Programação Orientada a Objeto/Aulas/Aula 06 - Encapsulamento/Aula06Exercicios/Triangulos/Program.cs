using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a 1° medida do triangulo: ");
            double medida1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 2° medida do triangulo: ");
            double medida2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 3° medida do triangulo: ");
            double medida3 = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo();
            triangulo.Medida1 = medida1;
            triangulo.Medida2 = medida2;
            triangulo.Medida3 = medida3;

            string[] tipoTriangulo = { "Equilátero", "Escaleno", "Isósceles"};

            if (triangulo.ETriangulo())
            {
                int index = triangulo.GetTipo();
                Console.WriteLine("As medidas {0}, {1} e {2} formam um triângulo {3}.",
                    triangulo.Medida1, triangulo.Medida2, triangulo.Medida3, tipoTriangulo[index]);
            }else
            {
                Console.WriteLine("As medidas {0}, {1} e {2} não formam um triângulo.",
                    triangulo.Medida1, triangulo.Medida2, triangulo.Medida3);
            }
        }
    }
}
/*
Escreva um algoritmo que lê três medidas e verifica se elas formam um triângulo. Caso positivo, o algoritmo deve 
identificar qual o tipo de triângulo formado: equilátero, isósceles ou escaleno.

A saída deve estar no seguinte formato: “As medidas Medida 1, Medida 2 e Medida 3 formam um triângulo Tipo do 
Triângulo.”

Ou, no caso de não formar um triângulo: “As medidas Medida 1, Medida 2 e Medida 3 não formam um triângulo.”.*/
