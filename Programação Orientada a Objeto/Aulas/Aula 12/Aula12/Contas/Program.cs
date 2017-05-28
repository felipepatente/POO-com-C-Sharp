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
            Console.Write("Que tipo de conta será usada (CC, CE, CP): ");
            string tipoConta = Console.ReadLine();

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite um valor: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            if (tipoConta == "CC")
            {
                ContaCorrente cc = new ContaCorrente(numConta, nome);
                cc.Depositar(valor);
                Console.WriteLine("Saldo atual: {0}", cc.GetSaldo());

            }
            else if (tipoConta == "CE")
            {
                ContaEspecial ce = new ContaEspecial(numConta, nome);
                ce.Depositar(valor);
                Console.WriteLine("Saldo atual: {0}", ce.GetSaldo());
                Console.WriteLine("Vira de Mês: {0}", ce.GetViradaMes());
            }
            else
            {
                ContaPoupanca cp = new ContaPoupanca(numConta, nome);
                cp.Depositar(valor);
                Console.WriteLine("Saldo atual: {0}", cp.GetSaldo());
                Console.WriteLine("Vira de Mês: {0}", cp.GetViradaMes());
            }

        }
    }
}
/*
 * Em um determinado banco, existem três tipos de conta:

Conta Corrente: possui um saldo.
Conte Especial: possui um saldo e um limite de crédito com juros de 10% ao mês.
Conta Poupança: possui um saldo e um rendimento de 0.5% ao mês.

Além disso, todos os tipo de conta também possuem um número que a identifica e o nome do correntista.

Escreva um programa que pergunta qual o tipo de conta que será usada e lê os seus dados. 
Após isso, o programa deve mostrar o saldo atual da conta, bem como o saldo após a virada do mês.
 */
