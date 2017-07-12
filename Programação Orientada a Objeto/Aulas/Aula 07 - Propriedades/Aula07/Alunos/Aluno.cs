using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    class Aluno
    {
        private string _nome;
        private double _p1, _p2;

        public Aluno(string nome, double p1, double p2)
        {
            this._nome = nome;
            this._p1 = p1;
            this._p2 = p2;
        }

        public Aluno(string nome): this(nome, 0, 0)
        {   
        }

        public Aluno(double p1, double p2) : this("Anônimo", p1, p2)
        {
        }

        public double P1
        {
            set
            {
                _p1 = value;
            }
        }

        public double P2
        {
            set
            {
                _p2 = value;
            }
        }


        public double GetMedia()
        {
            return (_p1 + _p2) / 2;
        }

        public bool IsAprovado()
        {
            double media = GetMedia();
            return IsAprovado(media);
        }

        public bool IsAprovado(double media)
        {
            return media >= 6.0;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }
    }
}
