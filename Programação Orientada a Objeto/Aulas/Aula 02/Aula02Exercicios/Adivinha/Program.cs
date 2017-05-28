using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int sorteado = rand.Next(10) + 1;
            int num = 0, tentativas = 1;

            do
            {
                Console.Write("Tente acertar o número da sorte: ");
                num = int.Parse(Console.ReadLine());

                if (num == sorteado)
                {
                    Console.WriteLine("Você acertou em "+ tentativas +" tentativas!");
                }
                else
                {
                    if (sorteado > num)
                    {
                        Console.WriteLine("Você errou!O número sorteado é maior que o valor lido.Tente novamente!");
                    }
                    else
                    {
                        Console.WriteLine("Você errou!O número sorteado é menor que o valor lido.Tente novamente!");
                    }
                    tentativas++;
                }

            } while (num != sorteado);

        }
    }
}
