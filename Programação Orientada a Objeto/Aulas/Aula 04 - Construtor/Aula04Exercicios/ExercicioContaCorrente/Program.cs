using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            decimal valor = 0M;
            ContaCorrente conta = new ContaCorrente();

            do
            {
                Console.Write("\nSaldo: R$ {0} \nO que você quer fazer?\n1.Depositar\n2.Sacar\n3.Sair\n-> ",conta.GetSaldo());
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Sua opção:{0}\nQual valor? ",opcao);
                        valor = decimal.Parse(Console.ReadLine());
                        conta.setDepositar(valor);
                        break;
                    case 2:
                        Console.Write("Sua opção:{0}\nQual valor? ", opcao);
                        valor = decimal.Parse(Console.ReadLine());
                        conta.setSacar(valor);
                        break;
                    case 3:
                        Console.WriteLine("Progrma encerrado");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }

            } while (opcao != 3);
        }
    }
}
/*
 *Nos exercícios abaixo, simulação quer dizer que você deve fazer um programa que permite uma interface entre o usuário e o que se está querendo simular. No caso do primeiro exercício, por exemplo, pode-se ter uma tela da seguinte forma:

Saldo: R$ 0.00
O que você quer fazer?
1. Depositar
2. Sacar
3. Sair
Sua opção: 1
Qual valor? 1000


Após a entrada do usuário, mostra novamente a tela:

Saldo: R$ 1000.00
O que você quer fazer?
1. Depositar
2. Sacar
3. Sair
Sua opção: 
 */
