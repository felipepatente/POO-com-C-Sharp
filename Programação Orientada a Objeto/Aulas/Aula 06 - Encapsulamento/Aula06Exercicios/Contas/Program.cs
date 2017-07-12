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

            string opcao = "";
            double valor;
            ContaCorrente conta = new ContaCorrente();

            do
            {
                Console.Write("\nSaldo: R$ {0}\nO que você quer fazer?\n1. Depositar\n2.Sacar\n3.Sair\n-> ", conta.Saldo);
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Sua opção: {0}", opcao);
                        Console.Write("Qual valor: ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Depositar = valor;
                        break;
                    case "2":
                        Console.WriteLine("Sua opção: {0}", opcao);
                        Console.Write("Qual valor: ");
                        valor = double.Parse(Console.ReadLine());
                        conta.Sacar = valor;
                        break;
                    case "3":
                        Console.WriteLine("Programa encerrado");
                        break;                    
                }

            } while (opcao != "3");

        }
    }
}
/*
Escreva um programa que simule uma conta corrente: ela possui um saldo e você pode depositar ou sacar valores 
dela (ações).
*/
