using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Valor da Hora: ");
            decimal valorHora = Decimal.Parse(Console.ReadLine());

            Console.Write("Horas: ");
            double horas = double.Parse(Console.ReadLine());


            //Processamento
            Funcionario f = new Funcionario(nome,valorHora,horas);
            decimal salario = f.GetSalario();

            //Saida
            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} e deve receber R$ {3}",
                nome, horas, valorHora, salario);


        }
    }
}
