using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Medidas do 1° triangulo");
            Console.Write("Digite a 1° medida: ");
            int triangulo1Medida1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a 2° medida: ");
            int triangulo1Medida2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a 3° medida: ");
            int triangulo1Medida3 = int.Parse(Console.ReadLine());



            Console.WriteLine("\nMedidas do 2° triangulo");
            Console.Write("Digite a 1° medida: ");
            int triangulo2Medida1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a 2° medida: ");
            int triangulo2Medida2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a 3° medida: ");
            int triangulo3Medida3 = int.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(triangulo1Medida1, triangulo1Medida2,triangulo1Medida3,
                triangulo2Medida1,triangulo2Medida2,triangulo3Medida3);

            if (triangulo.GetEIgual())
            {
                Console.WriteLine("Os triangulos são iguais");
            }else
            {
                Console.WriteLine("Os triangulos são diferentes");
            }
        }
    }
}
/*
Escreva um algoritmo que lê três medidas de dois triângulos e verifica se eles são iguais.
 */
