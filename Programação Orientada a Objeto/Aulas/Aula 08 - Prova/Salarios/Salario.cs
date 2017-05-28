using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarios
{
    class Salario
    {
        private string _nome;
        private double _valorHora;
        private double _qtdHora;

        public Salario(string _nome, double _valorHora, double _qtdHora)
        {
            this._nome = _nome;
            this.ValorHora = _valorHora;
            this.QtdHoras = _qtdHora;
        }

        public Salario(string nome) : this(nome, 0.0,0.0)
        {
        }

        public double GetSalario()
        {
            return this._valorHora * this._qtdHora;
        }

        public double ValorHora
        {
            get
            {
                return this._valorHora;
            }

            set
            {
                if (value > 0)
                {
                    this._valorHora = value;
                }
            }
        }

        public double QtdHoras
        {
            get
            {
                return this._qtdHora;
            }

            set
            {
                if (value > 0)
                {
                    this._qtdHora = value;
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
    }
}
