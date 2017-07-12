using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno aluno = new Aluno();

            string continua;
            do
            {
                
                Console.WriteLine("\n1 - Inserir Aluno");
                Console.WriteLine("2 - Lista Aluno (ordem alfabética) ");
                Console.WriteLine("3 - Consultar Aluno");
                Console.WriteLine("4 - Remover Aluno");
                Console.WriteLine("5 - Lista alunos aprovados");
                Console.WriteLine("6 - Listar alunos reprovados");
                Console.Write("7 - lista alunos (ordem de média)\n->");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite a matrícula: ");
                        string matricula = Console.ReadLine();

                        Console.Write("Digite o nome do aluno: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite a nota da 1° prova: ");
                        double p1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite a nota da 2° prova: ");
                        double p2 = double.Parse(Console.ReadLine());

                        alunos.Add(new Aluno(matricula, nome, p1, p2));
                        break;
                    case "2":
                        aluno.MostrarAlunos(alunos);
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome do aluno a ser consultado");
                        string nomeAluno = Console.ReadLine();

                        int posicao = aluno.ConsultarAluno(alunos, nomeAluno);
                        if (posicao >= 0)
                        {
                            Console.WriteLine("\nMatricula: {0}", alunos[posicao].GetMatricula());
                            Console.WriteLine("Nome: {0}", alunos[posicao].GetNome());
                            Console.WriteLine("P1: {0}", alunos[posicao].GetP1());
                            Console.WriteLine("P2: {0}", alunos[posicao].GetP2());
                            Console.WriteLine("Média: {0}\n", alunos[posicao].GetMedia());
                        }else
                        {
                            Console.WriteLine("Aluno não encontrado");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Digite o nome do aluno a ser removido: ");
                        string nomeAlunoRemover = Console.ReadLine();
                        bool alunoEstaRemovido = false;

                        for (int i = 0; i < alunos.Count; i++)
                        {
                            if (nomeAlunoRemover.ToUpper() == alunos[i].GetNome().ToUpper())
                            {
                                alunos.RemoveAt(i);
                                alunoEstaRemovido = true;
                            }
                        }

                        if (alunoEstaRemovido)
                        {
                            Console.WriteLine("{0} foi removido da lista", nomeAlunoRemover);
                        }else
                        {
                            Console.WriteLine("{0} não foi encontrado na lista");
                        }
                        break;

                    case "5":
                        for (int i = 0; i < alunos.Count; i++)
                        {
                            if (alunos[i].GetMedia() >= 6)
                            {
                                Console.WriteLine("\nMatricula: {0}", alunos[i].GetMatricula());
                                Console.WriteLine("Nome: {0}", alunos[i].GetNome());
                                Console.WriteLine("P1: {0}", alunos[i].GetP1());
                                Console.WriteLine("P2: {0}", alunos[i].GetP2());
                                Console.WriteLine("Média: {0}\n", alunos[i].GetMedia());
                            }
                        }
                        break;
                    case "6":
                        for (int i = 0; i < alunos.Count; i++)
                        {
                            if (alunos[i].GetMedia() < 6)
                            {
                                Console.WriteLine("\nMatricula: {0}", alunos[i].GetMatricula());
                                Console.WriteLine("Nome: {0}", alunos[i].GetNome());
                                Console.WriteLine("P1: {0}", alunos[i].GetP1());
                                Console.WriteLine("P2: {0}", alunos[i].GetP2());
                                Console.WriteLine("Média: {0}\n", alunos[i].GetMedia());
                            }
                        }
                        break;
                    case "7":
                        alunos.Sort(new OrdenarPorMedia());
                        for (int i = 0; i < alunos.Count; i++)
                        {
                            Console.WriteLine("\nMatricula: {0}", alunos[i].GetMatricula());
                            Console.WriteLine("Nome: {0}", alunos[i].GetNome());
                            Console.WriteLine("P1: {0}", alunos[i].GetP1());
                            Console.WriteLine("P2: {0}", alunos[i].GetP2());
                            Console.WriteLine("Média: {0}\n", alunos[i].GetMedia());
                        }
                        break;
                }

                Console.WriteLine("Deseja continuar (S/N): ");
                continua = Console.ReadLine();

            } while (continua.ToUpper() == "S");
        }
    }
}