using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Aluno> aluno = new List<Aluno>();

            string nome;
            double nota1, nota2;
            

            do
            {
                Console.Write("\nDigite o nome do aluno: ");
                nome = Console.ReadLine();

                Console.Write("Digite a 1° nota: ");
                nota1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a 2° nota: ");
                nota2 = double.Parse(Console.ReadLine());

                aluno.Add(new Aluno(nome,nota1,nota2));

            } while (nome != "");
            


            Console.WriteLine("\nAlunos Aprovados");
            for (int i = 0; i < aluno.Count; i++)
            {
                if (aluno[i].GetMedia() >= 6)
                {
                    Console.WriteLine(aluno[i].Nome);
                }
            }

            Console.WriteLine("\nAlunos Reprovados");
            for (int i = 0; i < aluno.Count; i++)
            {
                if (aluno[i].GetMedia() < 6)
                {
                    Console.WriteLine(aluno[i].Nome);
                }
            }
        }
    }
}
/*
 * Melhore o programa anterior de forma que o usuário possa entrar com os dados dos alunos sem se preocupar com 
 * quantos são. Para indicar que o não existem mais alunos a serem lidos, o usuário entra com um nome vazio.
 */
