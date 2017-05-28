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
            //1° forma
            Console.Write("Digite o 1° número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o operador: ");
            string operador = Console.ReadLine();


            Calculadora calculadora = new Calculadora (num1, num2, operador);
            Console.WriteLine("Resultado: {0:F2}", calculadora.GetCalculo());


            //2° Forma
            Calculadora calculadora2 = new Calculadora(num1, num2);
            Console.WriteLine("Resultado: {0:F2}", calculadora2.GetCalculo());

            //3° Forma
            Calculadora calculadora3 = new Calculadora(operador);
            Console.WriteLine("Resultado: {0:F2}", calculadora3.GetCalculo(num1, num2));

            //4° Forma
            Calculadora calculadora4 = new Calculadora();
            Console.WriteLine("Resultado: {0:F2}", calculadora3.GetCalculo(num1, num2, operador));
        }
    }
}
