using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vetor = new string[10];

            Console.WriteLine(vetor[0] + "     | "+ vetor[1] + "   |" + vetor[2]);
            Console.WriteLine("-----+    +-----");
            Console.WriteLine(vetor[3] + "     | " + vetor[4] + "   |" + vetor[5]);
            Console.WriteLine("-----+    +-----");
            Console.WriteLine(vetor[6] + "     | " + vetor[7] + "   |" + vetor[8]);

            Console.Write("De quem é a vez: ");
            string vez = Console.ReadLine();

            Console.Write("Em qual posição: ");
            int posicao = int.Parse(Console.ReadLine());

            if (vez.Equals("O"))
            {
                for (int i = 0; i < posicao; i++)
                {
                    if (i == (posicao - 1))
                        vetor[i] = "O";
                }

            }else
            {
                for (int i = 0; i < posicao; i++)
                {
                    if (i == (posicao - 1))
                        vetor[i] = "X";
                }
            }

            Console.WriteLine();
            Console.WriteLine(vetor[0] + "     | " + vetor[1] + "   |" + vetor[2]);
            Console.WriteLine("-----+    +-----");
            Console.WriteLine(vetor[3] + "     | " + vetor[4] + "   |" + vetor[5]);
            Console.WriteLine("-----+    +-----");
            Console.WriteLine(vetor[6] + "     | " + vetor[7] + "   |" + vetor[8]);
        }
    }
}
