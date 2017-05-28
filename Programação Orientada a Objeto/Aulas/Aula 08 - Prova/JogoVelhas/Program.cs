using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoVelhas
{
    public class Program
    {
        public static string[] vetor = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public static bool GetGanhou(string vez)
        {
            bool ganhou = false;

            if (vetor[0] == vez && vetor[4] == vez && vetor[8] == vez)
            {
                ganhou = true;
            }else if (vetor[2] == vez && vetor[4] == vez && vetor[6] == vez)
            {
                ganhou = true;
            }else if (vetor[1] == vez && vetor[4] == vez && vetor[7] == vez)
            {
                ganhou = true;
            }else if (vetor[3] == vez && vetor[4] == vez && vetor[5] == vez)
            {
                ganhou = true;
            }

            return ganhou;
        }


        public static void colocar(string vez,int posicao)
        {
            switch (posicao)
            {
                case 0:
                    vetor[0] = vez;
                    break;
                case 1:
                    vetor[1] = vez;
                    break;
                case 2:
                    vetor[2] = vez;
                    break;
                case 3:
                    vetor[3] = vez;
                    break;
                case 4:
                    vetor[4] = vez;
                    break;
                case 5:
                    vetor[5] = vez;
                    break;
                case 6:
                    vetor[6] = vez;
                    break;
                case 7:
                    vetor[7] = vez;
                    break;
                case 8:
                    vetor[8] = vez;
                    break;
            }
        }

        static void Main(string[] args)
        {
            
            
            Console.WriteLine("{0}  |{1}  |{2}", vetor[0], vetor[1], vetor[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine("{0}  |{1}  |{2}", vetor[3], vetor[4], vetor[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine("{0}  |{1}  |{2}", vetor[6], vetor[7], vetor[8]);

            int qtd = 0;
            bool ganhou = true;

            do
            {
                Console.Write("De quem é a vez: ");
                string vez = Console.ReadLine();

                Console.Write("Jogar em que posição: ");
                int posicao = int.Parse(Console.ReadLine());
                posicao--;

                colocar(vez, posicao);

                Console.WriteLine("\n{0}  |{1}  |{2}", vetor[0], vetor[1], vetor[2]);
                Console.WriteLine("---+---+---");
                Console.WriteLine("{0}  |{1}  |{2}", vetor[3], vetor[4], vetor[5]);
                Console.WriteLine("---+---+---");
                Console.WriteLine("{0}  |{1}  |{2}", vetor[6], vetor[7], vetor[8]);

                if (GetGanhou(vez))
                {
                    Console.WriteLine("{0} ganhou o jogo da velha",vez);
                    ganhou = false;
                }

            } while (qtd <= 8 && ganhou);
        }
    }
}
