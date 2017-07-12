using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Operacao> operacoes = new List<Operacao>();
            operacoes.Add(new Soma());
            operacoes.Add(new Subtracao());
            operacoes.Add(new Multiplicacao());
            operacoes.Add(new Divisao());
            operacoes.Add(new Modulo());
            operacoes.Add(new Exponenciacao());
            operacoes.Add(new Fatorial());

            for (int i = 0; i < operacoes.Count; i++)
            {
                Console.WriteLine("{0} para {1}", i, operacoes[i].ToString());
            }

            Console.Write("-> ");
            int opcao = int.Parse(Console.ReadLine());
            
            Operacao calculo = operacoes[opcao];
            double resultado;


            double num1, num2;

            Console.Write("Digite um número: ");
            num1 = double.Parse(Console.ReadLine());

            if (opcao <= 5)
            {
                Console.Write("Digite o 2° número: ");
                num2 = double.Parse(Console.ReadLine());

                resultado = calculo.FazConta(num1, num2);
            }else
            {
                Fatorial fat = new Fatorial();
                resultado = fat.FazConta(num1);
            }

            
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
