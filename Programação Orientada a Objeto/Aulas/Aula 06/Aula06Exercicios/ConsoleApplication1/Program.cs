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
            Console.Write("Digite o 1° número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação desejada (+ - / *): ");
            string operador = Console.ReadLine();

            Calculadora calculadora = new Calculadora(num1, num2);
            double resultado = calculadora.GetCalculo(operador);

            Console.WriteLine("Resultado da operação: {0:F2}", resultado);

        }
    }
}
/*
Escreva um algoritmo que lê dois números e qual a operação matemática desejada: soma, subtração, 
multiplicação ou divisão. Após isso, ele deve calcular e mostrar o resultado dessa operação.
 */
