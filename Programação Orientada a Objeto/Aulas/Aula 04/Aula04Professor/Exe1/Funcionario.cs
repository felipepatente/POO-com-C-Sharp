using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    class Funcionario
    {
        public string nome;
        public decimal valorHora;
        public double horas;

        public Funcionario(string nome, decimal valorHora, double horas)
        {
            this.nome = nome;
            this.valorHora = valorHora;
            this.horas = horas;
        }

        public decimal GetSalario()
        {
            return Convert.ToDecimal(horas) * valorHora;
        }
    }
}
