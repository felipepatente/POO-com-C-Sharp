using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Busca busca = new Busca();
            busca.SetNumero(numero);

            if (busca.GetPosicao() != -1)
            {
                Console.WriteLine("{0} encontrado na posição: {1}", busca.GetNumero(), busca.GetPosicao());
            }else
            {
                Console.WriteLine("Número não encontrado");
            }
        }
    }
}
/* Escreva um programa que preenche um vetor de cem posições com números aleatórios entre um e dez (inclusive). 
 * Depois, o programa deve perguntar por um número e mostrar em quais posições do vetor ele foi encontrado. Caso o número lido não seja 
 * encontrado em nenhuma posição, o programa deve mostrar a mensagem “Número não encontrado!“.*/
