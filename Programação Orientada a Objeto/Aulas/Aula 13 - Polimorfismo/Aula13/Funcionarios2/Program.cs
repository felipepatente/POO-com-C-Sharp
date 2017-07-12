using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor da hora: ");
            decimal valorHora = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas trabalhadas: ");
            double qtdHoras = double.Parse(Console.ReadLine());

            Console.Write("Você é gerente (S/N): ");
            string resposta = Console.ReadLine();

            Funcionario funcionario;

            if(resposta.ToUpper() == "S")
            {
                Console.Write("Digite seu bonus: ");
                decimal bonus = decimal.Parse(Console.ReadLine());

                funcionario = new Gerente(nome, qtdHoras, valorHora, bonus);

            }
            else
            {
                funcionario = new Funcionario(nome, qtdHoras, valorHora);
            }


            Console.WriteLine("Salario a ser recebido: R$ " + funcionario.GetSalario());

        }
    }
}
/*
Escreva um programa que lê o nome, o valor da hora e a quantidade de horas trabalhadas de um funcionário.
Pergunte, também, se ele é gerente. Se for, além dos dados anteriores, o gerente recebe um bônus que deve 
ser fornecido pelo usuário.
Após isso, mostre o salário a ser recebido.
*/