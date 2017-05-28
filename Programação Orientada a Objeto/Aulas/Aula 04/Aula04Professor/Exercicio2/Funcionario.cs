using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Funcionario
    {
        public double horas;
        public int nivel;
        public string nome;

        public Funcionario(string nome, int nivel, double horas)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.horas = horas;
        }

        public decimal GetValorHora()
        {
            decimal valorhora = 0M;

            switch (this.nivel)
            {
                case 1:
                    valorhora = 15.0M;
                    break;
                case 2:
                    valorhora = 18.0M;
                    break;
                case 3:
                    valorhora = 22.0M;
                    break;
                case 4:
                    valorhora = 27.0M;
                    break;
                case 5:
                    valorhora = 33.0M;
                    break;
            }

            return valorhora;
        }

        public decimal GetSalario()
        {
            return Convert.ToDecimal(horas) * GetValorHora();
        }

        public void Promover()
        {
            if (this.nivel < 5)
            {
                this.nivel++;
            }
        }
    }
}
