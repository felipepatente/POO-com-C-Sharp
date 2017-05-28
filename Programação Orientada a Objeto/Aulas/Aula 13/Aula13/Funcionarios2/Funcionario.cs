using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios2
{
    public class Funcionario
    {
        private decimal valorHora;
        private string nome;
        private double qtdHoras;


        public Funcionario(string nome, double qtdHoras, decimal valorHora)
        {
            this.nome = nome;
            this.valorHora = valorHora;
            this.qtdHoras = qtdHoras;
        }

        public virtual decimal GetSalario()
        {
            return valorHora * Convert.ToDecimal(qtdHoras);
        }

        public decimal GetValorHora()
        {
            return valorHora;
        }

        public double GetQtdHoras()
        {
            return qtdHoras;
        }
    }
}
