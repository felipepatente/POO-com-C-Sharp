using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("n1: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("n2: ");
                double n2 = double.Parse(Console.ReadLine());

                foreach (Operacao operacao in Operacao.GetOperacoes())
                {
                    Console.WriteLine("{0}\t{1}", operacao.GetSimbolo(), operacao);
                }
                Console.Write("Operação: ");
                string simbolo = Console.ReadLine();

                Operacao escolhida = Operacao.GetOperacao(simbolo);
                double resultado = escolhida.Calcula(n1, n2);

                Console.WriteLine(resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Entre com um número!");
            }
            catch (OperacaoInvalidaException)
            {
                Console.WriteLine("Entre com uma operação válida!");
            }
            catch (DivisaoPorZeroException)
            {
                Console.WriteLine("Não dividirás por zero!");
            }
        }
    }
}
