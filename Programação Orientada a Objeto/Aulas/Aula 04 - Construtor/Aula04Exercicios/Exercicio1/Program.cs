using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor da hora: ");
            decimal valorHora = Decimal.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas trabalhadas: ");
            double qtdHora = double.Parse(Console.ReadLine());

            Funcionario f = new Funcionario(nome,valorHora,qtdHora);

            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ "
               + " {2} e deve receber R$ {3}",
               f.nome, f.qtdHora, f.valorHora, f.GetSalario());
        }
    }
}
/*
Escreva um algoritmo que lê o nome de um funcionário, o valor da sua hora de trabalho e a quantidade de horas que 
ele trabalhou. O algoritmo deve calcular o valor do salário a ser pago e mostrar a seguinte mensagem: 
“O funcionário Nome do Funcionário trabalhou Horas Trabalhadas horas por R$ Valor da Hora e deve receber R$ Valor do 
Salário“.
 */
