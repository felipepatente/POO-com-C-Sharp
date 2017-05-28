using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a 1° nota: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 2° nota: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            double media = (p1 + p2) / 2;

            if(media >= 6)
                Console.Write("APROVADO\nMedia: " + media + "\n");
            else
                Console.Write("REPROVADO\nMedia: " + media + "\n");
        }
    }
}
