using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENTRADA
            Console.Write("n: ");

            // PROCESSAMENTO
            try
            {
                int n = int.Parse(Console.ReadLine());
                Fatorial f = new Fatorial(n);
                int resultado = f.getResultado();

                // SAÍDA
                Console.WriteLine("{0}! = {1}", n, resultado);
            } catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            // ----------------------------------------------------------------------
            //                        SEGUNDA PARTE DA AULA
            // ----------------------------------------------------------------------
            // primeiro as exceções específicas
            //catch (NumeroNegativoException ex)
            //{

            //    Console.WriteLine("Número Inválido: " + ex.getN());
            //    Console.WriteLine("Usuário, por favor, entre com um número inteiro NÃO-NEGATIVO!");
            //}
            //// depois as generalizadas
            //catch (FatorialException ex)
            //{
            //    Console.WriteLine("Não consigo calcular o fatorial...");
            //}

            // ----------------------------------------------------------------------
            //                         PRIMEIRA PARTE DA AULA
            // ----------------------------------------------------------------------
            // HERANÇA - SEM A CLASSE FATORIAL EXCEPTION
            //} catch (FormatException ex)
            //{
            //    // essa mensagem é mais para o programador poder investigar
            //    // e não para  o usuário 
            //    Console.WriteLine("Erro: " + ex.Message);
            //    Console.WriteLine("Usuário, por favor, entre com um número inteiro!");
            //}
            //catch (NumeroNegativoException ex)
            //{
            //    Console.WriteLine("Número Inválido: " + ex.getN());
            //    Console.WriteLine("Usuário, por favor, entre com um número inteiro NÃO-NEGATIVO!");
            //}
            //catch (EstouroException ex)
            //{
            //    Console.WriteLine("Número Inválido: " + ex.getN());
            //    Console.WriteLine("Usuário, por favor, entre com um número até 16! (Não consigo calcular maior que isso)");
            //}

            Console.WriteLine("");

        }
    }
}
