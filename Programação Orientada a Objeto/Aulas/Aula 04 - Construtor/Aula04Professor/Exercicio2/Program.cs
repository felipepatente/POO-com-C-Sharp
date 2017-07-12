using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Endrada
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nível: ");
            int nivel = int.Parse(Console.ReadLine());

            Console.Write("Horas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.Write("Teve promoção: ");
            string promocao = Console.ReadLine();

            //Processamento
            Funcionario f = new Funcionario(nome, nivel, horas);
            decimal valorHora = f.GetValorHora();
            decimal salario = f.GetSalario();


            //Saida
            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} (Nível {3}) e deve receber R$ {4}",
                nome,horas,valorHora,nivel,salario);


            if (promocao == "s")
            {
                f.Promover();
                valorHora = f.GetValorHora();
                salario = f.GetSalario();
                nivel = f.nivel;
                Console.WriteLine("O funcionário {0} teve promoção, trabalhou {1} horas por R$ {2} (Nível {3}) e o seu novo salário é de R$ {4}.",
               nome, horas, valorHora, nivel, salario);
            }







        }
    }
}
