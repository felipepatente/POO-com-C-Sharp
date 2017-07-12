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
            string opcao = "", situacao = "";
            Lampada lampada = new Lampada();

            do
            {
                situacao = lampada.GetEstado() ? "acesa" : "apagada";


                Console.WriteLine("\nEstado da Lampada: {0}", situacao);
                Console.Write("O que você quer fazer?\n1. Acender\n2. Apagar\n3. Sair\n-> ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        lampada.SetAcender();
                        if (!lampada.GetEstado())
                        {
                            Console.WriteLine("Lampada Queimada");
                            Console.Write("Deseja colocar uma lampada nova: (S/N): ");
                            opcao = Console.ReadLine();

                            if (opcao == "S")
                            {
                                lampada.SetAcender();
                            }else
                            {
                                opcao = "3";
                            }

                        }
                        break;
                    case "2":
                        lampada.SetApagar();
                        break;
                    case "3":
                        Console.WriteLine("Programa Encerrado");
                        break;
                    default:
                        break;
                }

            } while (opcao != "3");
        }
    }
}
