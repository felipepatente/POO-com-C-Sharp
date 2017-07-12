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
            //ENTRADA
            Console.WriteLine("Mês: ");
            int mes = int.Parse(Console.ReadLine());

            //PROCESSAMENTO
            Mes[] meses = new Mes[]
            {
                new Mes("jan",31),
                new Mes("fev",28),
                new Mes("mar",31),
                new Mes("abr",31),
                new Mes("mai",31),
                new Mes("jun",31),
                new Mes("jul",31),
                new Mes("ago",31),
                new Mes("set",31),
                new Mes("out",31),
                new Mes("nov",31),
                new Mes("dez",31)
            };

            Mes m = meses[mes - 1];

            //SAIDA
            Console.WriteLine("Dias: " + m.dias);
            Console.WriteLine("Mes: " + m.mes);
        }
    }
}
