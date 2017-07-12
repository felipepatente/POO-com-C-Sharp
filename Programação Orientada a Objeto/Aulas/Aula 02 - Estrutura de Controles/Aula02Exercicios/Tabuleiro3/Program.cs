using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro3
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] vetor = {"1", "2", "3", "4", "5", "6", "7", "8","9"};

            Console.WriteLine(vetor[0] + "    | " + vetor[1] + "  |" + vetor[2]);
            Console.WriteLine("-----+    +-----");
            Console.WriteLine(vetor[3] + "    | " + vetor[4] + "  |" + vetor[5]);
            Console.WriteLine("-----+    +-----");
            Console.WriteLine(vetor[6] + "    | " + vetor[7] + "  |" + vetor[8]);

            for (int j = 0; j < 9; j++)
            {
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

                }
                else
                {
                    for (int i = 0; i < posicao; i++)
                    {
                        if (i == (posicao - 1))
                            vetor[i] = "X";
                    }
                }

                Console.WriteLine(vetor[0] + "    | " + vetor[1] + "  |" + vetor[2]);
                Console.WriteLine("-----+    +-----");
                Console.WriteLine(vetor[3] + "    | " + vetor[4] + "  |" + vetor[5]);
                Console.WriteLine("-----+    +-----");
                Console.WriteLine(vetor[6] + "    | " + vetor[7] + "  |" + vetor[8]);
            }
        }
    }
}
