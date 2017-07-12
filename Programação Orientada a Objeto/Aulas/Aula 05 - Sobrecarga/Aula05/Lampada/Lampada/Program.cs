using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampada l = new Lampada();

            bool sair = false;

            do
            {
                Console.WriteLine("Estado da lâmpada: " + l.GetEstado());
                Console.WriteLine("O que você quer fazer?");
                Console.WriteLine("1. Acender");
                Console.WriteLine("2. Apagar");
                Console.WriteLine("3. Sair");
                Console.Write("Sua opção:");
                string opcao = Console.ReadLine();
                Console.WriteLine("");

                switch (opcao)
                {
                    case "1":
                        l.Acender();
                        break;
                    case "2":
                        l.Apagar();
                        break;
                    case "3":
                        sair = true;
                        break;

                }
            } while (!sair);


        }
    }
}
