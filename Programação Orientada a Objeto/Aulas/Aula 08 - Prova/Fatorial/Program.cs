using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = int.Parse(Console.ReadLine());

            Fatorial fat = new Fatorial();
            fat.SetNum(num);

            Console.WriteLine("O fatorial de {0} é de {1}", fat.GetNum(), fat.GetFatorial());

        }
    }
}
