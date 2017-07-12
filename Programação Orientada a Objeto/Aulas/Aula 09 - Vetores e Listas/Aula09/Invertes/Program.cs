using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = new string[10];
            

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite a {0} palavra: ", i);
                palavras[i] = Console.ReadLine();
            }

            Console.WriteLine("Vetor antes de ordenar");
            foreach (string normal in palavras)
            {
                Console.Write(normal + " ");
            }

            Inverte inverte = new Inverte(palavras);
            string[] vetorInvertido = inverte.GetInverter();

            Console.WriteLine("\nVetor depois de ordenar");
            foreach (string invertido in vetorInvertido)
            {
                Console.Write("{0} ", invertido);
            }
            Console.WriteLine();
        }
    }
}
