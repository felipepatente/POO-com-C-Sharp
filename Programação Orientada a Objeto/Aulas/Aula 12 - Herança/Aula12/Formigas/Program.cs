using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formigas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Colunas: ");
            int colunas = int.Parse(Console.ReadLine());
            
            Console.Write("Linha inicial: ");
            int linhaInicial = int.Parse(Console.ReadLine());

            Console.Write("Coluna inicial: ");
            int colunaInicial = int.Parse(Console.ReadLine());

            Console.Write("Direção inicial (N, S, L, O): ");
            string direcao = Console.ReadLine();

            Tabuleiro tabuleiro = new Tabuleiro(linhas, colunas, linhaInicial, colunaInicial, direcao);

            string continua;

            do
            {
                tabuleiro.MostarTabuleiro();
                tabuleiro.MovimentoFormiga();
                
                Console.Write("Quer continuar (S/N): ");
                continua = Console.ReadLine();
                
            } while (continua.ToUpper() == "S");
        }
    }
}
