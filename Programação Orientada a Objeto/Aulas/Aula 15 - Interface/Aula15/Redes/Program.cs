using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite uma mensagem: ");
            string mensagem = Console.ReadLine();

            List<RedesSociais> rede = new List<RedesSociais>();
            rede.Add(new WhatsApp(nome,mensagem));
            rede.Add(new Instagram(nome, mensagem));
            rede.Add(new Twitter(nome, mensagem));
            rede.Add(new Facebook(nome, mensagem));

            for (int i = 0; i < rede.Count; i++)
            {
                Console.WriteLine(rede[i].ImprimirMensagem());
            }
        }
    }
}

