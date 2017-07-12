using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            Console.Write("Digite a 1° medida do 1° triângulo: ");
            double tri1Lado1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 2° medida do 1° triângulo: ");
            double tri1Lado2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 3° medida do 1° triângulo: ");
            double tri1Lado3 = double.Parse(Console.ReadLine());


            Console.Write("\nDigite a 1° medida do 2° triângulo: ");
            double tri2Lado1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 2° medida do 2° triângulo: ");
            double tri2Lado2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 3° medida do 2° triângulo: ");
            double tri2Lado3 = double.Parse(Console.ReadLine());


            Triangulo triangulo = new Triangulo(tri1Lado1,tri1Lado2,tri1Lado3);
            Triangulo triangulo2 = new Triangulo(tri2Lado1,tri2Lado2,tri2Lado3);

            if (triangulo2.GetIgual(triangulo))
            {
                Console.WriteLine("Os triangulos são iguais");
            }else
            {
                Console.WriteLine("Os triangulos são diferentes");
            }

        }
    }
}
