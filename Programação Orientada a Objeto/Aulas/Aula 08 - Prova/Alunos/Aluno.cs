using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    class Aluno
    {

        private double _nota1;
        private double _nota2;
        private string _nome;
        private double _frequencia;

        public Aluno(string nome)
        {
            this._nome = nome;
        }

        public double Nota1
        {
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
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this._nota2 = value;
                }
            }
        }

        public double Frequencia
        {
            get
            {
                return this._frequencia;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    this._frequencia = value;
                }
            }
        }

        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        public double GetMedia()
        {
            return (_nota1 + _nota2) / 2;
        }
    }
}
