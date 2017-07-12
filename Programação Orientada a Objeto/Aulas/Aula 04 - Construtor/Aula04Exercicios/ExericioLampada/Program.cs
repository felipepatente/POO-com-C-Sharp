using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericioLampada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Lampada lampada = new Lampada();

            string controlarLampada, trocarLampada;

            Random rand = new Random();
            int qtdVezes;

            do
            {
                Console.Write("Deseja Desligar(D) ou Ligar(L) a Lampada e se quier sair do ambiente(S): ");
                controlarLampada = Console.ReadLine();

                qtdVezes = rand.Next(5) + 1;
                Console.WriteLine(qtdVezes);

                if (qtdVezes != 5)
                {
                    if (lampada.GetLampada(controlarLampada))
                    {
                        Console.WriteLine("Lampada se encontra acessa");
                    }
                    else
                    {
                        Console.WriteLine("Lampada se encontra desligada");
                    }
                }else
                {
                    Console.WriteLine("Lampada queimada");
                    Console.Write("Deseja trocar a lampada queimada(S/N):");
                    trocarLampada = Console.ReadLine();

                    if (trocarLampada == "S")
                    {
                        if (lampada.GetLampada("L"))
                        {
                            Console.WriteLine("Lampada trocada com sucesso");
                            qtdVezes = 0;
                        }
                    }
                }

            } while (controlarLampada != "S" && qtdVezes != 5);
            
        }
    }
}
/*
Melhore a simulação de forma que, na quinta vez em que a lâmpada é acendida, ela queima. 
Opcional: faça com que o número de vezes que a lâmpada acende antes de queimar seja aleatório.
 */
