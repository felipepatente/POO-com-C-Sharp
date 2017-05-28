using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarAlunos
{
    public class Aluno : IComparable<Aluno>
    {
        private string matricula;
        private string nome;
        private double p1;
        private double p2;

        public Aluno(string matricula, string nome, double p1, double p2)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.p1 = p1;
            this.p2 = p2;
        }

        public Aluno()
        {

        }
        
        public string GetNome()
        {
            return this.nome;
        }

        public string GetMatricula()
        {
            return this.matricula;
        }

        public double GetP1()
        {
            return this.p1;
        }

        public double GetP2()
        {
            return this.p2;
        }

        public double GetMedia()
        {
            return (p1 + p2) / 2;
        }

        public int CompareTo(Aluno other)
        {
            return this.GetNome().CompareTo(other.GetNome());
        }

        public void MostrarAlunos(List<Aluno> alunos)
        {
            alunos.Sort();
            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine("\nMatricula: {0}", alunos[i].GetMatricula());
                Console.WriteLine("Nome: {0}", alunos[i].GetNome());
                Console.WriteLine("P1: {0}", alunos[i].GetP1());
                Console.WriteLine("P2: {0}", alunos[i].GetP2());
                Console.WriteLine("Média: {0}\n", alunos[i].GetMedia());
            }
        }

        public int ConsultarAluno(List<Aluno> alunos, string nomeAluno)
        {
            int posicao = -1;
            for (int i = 0; i < alunos.Count; i++)
            {
                if (nomeAluno.ToUpper() == alunos[i].GetNome().ToUpper())
                {
                    posicao = i;
                }
            }

            return posicao;
        }
        
    }
}
