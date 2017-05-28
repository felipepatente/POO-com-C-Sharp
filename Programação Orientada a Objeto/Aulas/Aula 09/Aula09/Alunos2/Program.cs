using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o número de alunos da sala: ");
            int numeroAlunos = int.Parse(Console.ReadLine());

            Aluno[] aluno = new Aluno[numeroAlunos];

            string nome;
            double nota1, nota2;

            for (int i = 0; i < aluno.Length; i++)
            {
                Console.Write("\nDigite o nome do aluno: ");
                nome = Console.ReadLine();

                Console.Write("Digite a 1° nota: ");
                nota1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a 2° nota: ");
                nota2 = double.Parse(Console.ReadLine());

                aluno[i] = new Aluno(nome, nota1, nota2);
            }

            Console.WriteLine("\nAlunos Aprovados");
            for (int i = 0; i < aluno.Length; i++)
            {
                if (aluno[i].GetMedia() >= 6)
                {
                    Console.WriteLine(aluno[i].Nome);
                }
            }

            Console.WriteLine("\nAlunos Reprovados");
            for (int i = 0; i < aluno.Length; i++)
            {
                if (aluno[i].GetMedia() < 6)
                {
                    Console.WriteLine(aluno[i].Nome);
                }
            }
        }
    }
}

/*Melhore o programa anterior de forma que o usuário possa entrar, primeiramente, com o número de alunos que 
 * existe na sala.*/
