using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos3
{
    public class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;

        public Aluno(string nome, double nota1, double nota2)
        {
            this.nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
        }

        public double Nota1
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.nota1 = value;
                }
            }
        }

        public double Nota2
        {
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.nota2 = value;
                }
            }
        }

        public double GetMedia()
        {
            return (this.nota1 + this.nota2) / 2;
        }
    }
}
