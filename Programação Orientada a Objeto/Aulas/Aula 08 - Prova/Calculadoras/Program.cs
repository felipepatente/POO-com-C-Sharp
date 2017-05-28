using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1° número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite um operador matematico (+ - / *): ");
            string operador = Console.ReadLine();

            Calculadora cal = new Calculadora(num1, num2, operador);

            Console.WriteLine("Resultado: {0:f2}", cal.GetResultado());

        }
    }
}
/*Escreva um algoritmo que lê dois números e qual a operação matemática desejada: soma, subtração, 
 * multiplicação ou divisão. Após isso, ele deve calcular e mostrar o resultado dessa operação.*/
