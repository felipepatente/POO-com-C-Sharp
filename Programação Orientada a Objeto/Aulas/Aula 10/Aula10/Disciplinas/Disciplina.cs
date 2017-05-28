using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disciplinas
{
    public class Disciplina
    {
        private string nomeDisciplina, nomeAluno;
        private double p1, p2;

        public Disciplina(string nomeAluno, string nomeDisciplina, double p1, double p2)
        {
            this.nomeDisciplina = nomeDisciplina;
            this.nomeAluno = nomeAluno;
            this.p1 = p1;
            this.p2 = p2;
        }

        public double GetMedia()
        {
            return (this.p1 + this.p2) / 2;
        }

        public bool GetAprovado()
        {
            return this.GetMedia() >= 6;
        }

        public string NomeDisciplina
        {
            get
            {
                return this.nomeDisciplina;
            }
        }

        public string GetNomeAluno()
        {
            return this.nomeAluno;
        }

        public double GetP1()
        {
            return this.p1;
        }

        public double GetP2()
        {
            return this.p2;
        }
    }
}
