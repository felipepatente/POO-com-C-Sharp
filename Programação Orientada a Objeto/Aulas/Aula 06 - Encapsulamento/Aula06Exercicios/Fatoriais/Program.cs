using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatoriais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            Fatorial fat = new Fatorial();
            fat.Numero = num;

            Console.WriteLine("O fatorial de {0} é {1}", fat.Numero, fat.GetFatorial());
        }
    }
}
/*Escreva um algoritmo que lê um número inteiro maior ou igual à zero e depois mostra o fatorial do número lido.*/
