using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Funcionario
    {
        public string nome;
        public decimal valorHora;
        public double qtdHora;

        public Funcionario(string nome, decimal valorHora, double qtdHora)
        {
            this.nome = nome;
            this.valorHora = valorHora;
            this.qtdHora = qtdHora;
        }

        public decimal GetSalario()
        {
            return Convert.ToDecimal(qtdHora) * this.valorHora;
        }

    }
}
