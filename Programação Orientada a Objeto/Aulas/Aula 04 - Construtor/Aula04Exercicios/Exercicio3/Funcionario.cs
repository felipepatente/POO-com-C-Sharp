using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Funcionario
    {
        public string nome;
        public int nivel;
        public double qtdHora;

        public Funcionario(string nome, int nivel, double qtdHora)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.qtdHora = qtdHora;
        }

        public decimal GetValorHora()
        {
            decimal valorHora = 0M;
            switch (this.nivel)
            {
                case 1:
                    valorHora = 15.0M;
                    break;
                case 2:
                    valorHora = 18.0M;
                    break;
                case 3:
                    valorHora = 22.0M;
                    break;
                case 4:
                    valorHora = 27.0M;
                    break;
                case 5:
                    valorHora = 33.0M;
                    break;
            }

            return valorHora;
        }


        public decimal GetSalario()
        {
            return Convert.ToDecimal(qtdHora) * this.GetValorHora();
        }

        public void aumentarNivel()
        {
            if (this.nivel < 5)
            {
                this.nivel++;
            }
        }
    }
}
