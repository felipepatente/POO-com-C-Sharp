using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor da hora: ");
            double valorHora = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas trabalhadas: ");
            double qtdHoras = double.Parse(Console.ReadLine());

            Salario salario = new Salario(nome,valorHora,qtdHoras);
            /*salario.QtdHoras = qtdHoras;
            salario.ValorHora = valorHora;*/
            
            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} e deve receber R${3}",
                salario.Nome, salario.QtdHoras, salario.ValorHora, salario.GetSalario());
        }
    }
}
/*Escreva um algoritmo que lê o nome de um funcionário, o valor da sua hora de trabalho e a quantidade de horas 
 * que ele trabalhou. O algoritmo deve calcular o valor do salário a ser pago e mostrar a seguinte mensagem: 
 * “O funcionário Nome do Funcionário trabalhou Horas Trabalhadas horas por R$ Valor da Hora e deve receber 
 * R$ Valor do Salário“.*/
