using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            string opcao;
            double valor;

            do
            {
                Console.WriteLine("\nSaldo: R$ {0}", conta.Saldo);
                Console.Write("O que você quer fazer\n1. Depositar\n2. Sacar\n3. Sair\n-> ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Sua opcao: {0}", opcao);
                        Console.Write("Qual valor? ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Depositar(valor);
                        break;
                    case "2":
                        Console.WriteLine("Sua opcao: {0}", opcao);
                        Console.Write("Qual valor? ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Sacar(valor);
                        break;
                    case "3":
                        Console.WriteLine("Programa encerrado");
                        break;
                }

            } while (opcao != "3");
        }
    }
}
