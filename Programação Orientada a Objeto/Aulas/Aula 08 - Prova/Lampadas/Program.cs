using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampada lamp = new Lampada();
            string opcao, situacaoLampada;

            do
            {
                situacaoLampada = lamp.Acessa ? "acessa" : "apagada";

                Console.WriteLine("\nEstado da lâmpada: {0}", situacaoLampada);
                Console.WriteLine("O que você quer fazer? ");
                Console.Write("1. Acender\n2. Apagar\n3. Sair\n-> ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Sua Opção: {0}", opcao);
                        lamp.AcenderLampada();

                        if (!lamp.Acessa)
                        {
                            Console.WriteLine("Lampada Queimada");
                            Console.Write("Deseja trocar de lampada (S/N): ");
                            opcao = Console.ReadLine();

                            if (opcao == "S")
                            {
                                lamp.AcenderLampada();
                            }else
                            {
                                opcao = "3";
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Sua Opção: {0}", opcao);
                        lamp.ApagarLampada();
                        break;
                    case "3":
                        Console.WriteLine("Programa encerrdo");
                        break;
                }

            } while (opcao != "3");
        }
    }
}
