using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disciplinas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Aluno aluno = new Aluno(nome,new Disciplina(nome,"",0.0,0.0));

            string nomeDisciplina, continua, materia;
            double p1, p2;

            do
            {
                Console.Write("Digite o nome da disciplina: ");
                nomeDisciplina = Console.ReadLine();

                Console.Write("Digite a nota da prova 1: ");
                p1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a nota da prova 2: ");
                p2 = double.Parse(Console.ReadLine());

                Console.Write("Deseja continuar cadastrando disciplinas(S/N): ");
                continua = Console.ReadLine();

                aluno.GetDisciplina().Add(new Disciplina(nome,nomeDisciplina, p1, p2));

            } while (continua == "S");


            do
            {
                Console.WriteLine("Qual disciplina você quer saber? ");
                materia = Console.ReadLine();

                for (int i = 0; i < aluno.GetDisciplina().Count; i++)
                {
                    if (materia == aluno.GetDisciplina()[i].NomeDisciplina)
                    {
                        Console.WriteLine("Disciplina: " + aluno.GetDisciplina()[i].NomeDisciplina);
                        Console.WriteLine("O aluno {0} {3} na disciplina {1} com média {2}.", 
                            aluno.Nome, aluno.GetDisciplina()[i].NomeDisciplina, aluno.GetDisciplina()[i].GetMedia(),
                            aluno.GetDisciplina()[i].GetAprovado() ? "passou" : "não passou");
                    }
                }

            } while (materia != "");

        }
    }
}
