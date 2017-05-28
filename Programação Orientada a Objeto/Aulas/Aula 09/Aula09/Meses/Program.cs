using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Mes mes = new Mes();
            mes.SetNumero(numero);
            int qtdDias = mes.GetDias();

            Console.WriteLine("Quantidades de dias do mes {0}: {1}", mes.GetMes(), qtdDias);


        }
    }
}
/*Escreva um progrma que lê um número inteiro entre 1 e 12 que representa o mês (1 p/Janeiro,
 * ..., 12 p/dezembro) e mostra o número de dias que ele tem. Obs.: não pode usar if/switch */
