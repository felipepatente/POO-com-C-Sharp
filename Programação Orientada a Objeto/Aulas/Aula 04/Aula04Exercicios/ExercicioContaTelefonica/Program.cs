using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            Console.Write("Digite os minutos gasto em ligações locais: ");
            double minutosLocais = double.Parse(Console.ReadLine());
            
            Console.Write("Digite os minutos gasto em ligações Interurbanas(DDD): ");
            double minutosInterurbanos = double.Parse(Console.ReadLine());

            Console.Write("Digite os minutos gasto em ligações Internacionais(DDI): ");
            double minutosInternacionais = double.Parse(Console.ReadLine());

            //PROCESSAMENTO
            ContaTelefonica conta = new ContaTelefonica(minutosLocais,minutosInterurbanos,minutosInternacionais);


            //SAIDA
            Console.WriteLine("\nAssinatura: R${0}", conta.GetAssinatura());
            Console.WriteLine("Ligações locais: R${0}", conta.GetValorLocais());
            Console.WriteLine("Ligações Interurbanos: R${0}", conta.GetValorInterurbanos());
            Console.WriteLine("Ligações Internacionais: R${0}", conta.GetValorInternacionais());
            Console.WriteLine("Total a ser Pago R${0}", conta.GetValorTotal());
        }
    }
}

/*
Assinatura: R$ 23,32
Ligações Locais: R$ 0,09 / min
Ligações Interurbanas (DDD): R$ 0,26 / min
Ligações Internacionais (DDI): R$ 0,86 / min
Escreva um algoritmo que lê os minutos gastos em cada tipo de ligação e que mostra o valor a ser pago em cada 
um dos itens e, também, o valor total.
 */
