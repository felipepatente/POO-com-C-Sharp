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
        private double _nota1;
        private double _nota2;
        private double _frequencia;


        public Aluno(string nome)
        {
            this.Nome = nome;
        }


        public string Nome {
            get{return this._nome; }
            set{ this._nome = value; }
        }
        
        public double Nota1
        {
            get { return _nota1; }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    this._nota1 = value;
                }
            }
        }

        public double Nota2
        {
            get { return _nota2; }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    this._nota2 = value;
                }
            }
        }

        public double Frequencia {

            get { return _frequencia; }

            set
            {
                if (value >= 0  && value <= 100)
                {
                    this._frequencia = value;
                }
            }

        }

        public double GetMedia()
        {
            return (this._nota1 + this._nota2) / 2;
        }
        
    }
}
