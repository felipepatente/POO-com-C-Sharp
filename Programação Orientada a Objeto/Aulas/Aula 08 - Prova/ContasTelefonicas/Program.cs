using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasTelefonicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite os minutos gastos em ligações locais: ");
            double locais = double.Parse(Console.ReadLine());

            Console.Write("Digite os minutos gastos em ligações interurbanas: ");
            double interurbanas = double.Parse(Console.ReadLine());

            Console.Write("Digite os minutos gastos em ligações internacionais: ");
            double internacionais = double.Parse(Console.ReadLine());

            ContaTelefonica conta = new ContaTelefonica();
            conta.SetLocais(locais);
            conta.SetInterurbanas(interurbanas);
            conta.SetInternacionais(internacionais);

            Console.WriteLine("Valores a ser pagos");
            Console.WriteLine("Ligações Locais: {0:f2}\nLigações Interurbanas: {1:f2}\nLigações Internacionais: {2:f2}\nValor total: {3:f2}",
                conta.GetValorLocais(), conta.GetValorInterurbanas(), conta.GetValorInternacionais(), conta.GetValorTotal());
        }
    }
}
