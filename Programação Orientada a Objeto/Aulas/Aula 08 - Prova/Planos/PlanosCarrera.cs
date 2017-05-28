using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planos
{
    class PlanosCarrera
    {
        private string _nome;
        private double _qtdHoras;
        private int _nivel;
        
        public PlanosCarrera(string _nome)
        {
            this._nome = _nome;
        } 

        public string Nome
        {
            get
            {
                return this._nome;
            }

            set
            {
                this._nome = value;
            }
        }

        public double QtdHoras
        {
            get
            {
                return this._qtdHoras;
            }

            set
            {
                if (value > 0)
                {
                    this._qtdHoras = value;
                }
            }
        }

        public int Nivel
        {
            get
            {
                return this._nivel;
            }

            set
            {
                if (value >= 1 && value <= 5)
                {
                    this._nivel = value;
                }
            }
        }


        public double GetValorHora()
        {
            double valorHora = 0.0;

            switch (this._nivel)
            {
                case 1:
                    valorHora = 15.00;
                    break;
                case 2:
                    valorHora = 18.00;
                    break;
                case 3:
                    valorHora = 22.00;
                    break;
                case 4:
                    valorHora = 27.00;
                    break;
                case 5:
                    valorHora = 33.00;
                    break;
            }

            return valorHora;
        }


        public double GetSalario()
        {
            return this._qtdHoras * this.GetValorHora();
        }
        
    }
}

