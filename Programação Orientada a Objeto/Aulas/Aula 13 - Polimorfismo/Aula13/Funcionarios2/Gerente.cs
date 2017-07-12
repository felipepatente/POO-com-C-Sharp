using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios2
{
    public class Gerente : Funcionario
    {
        private decimal bonus;

        public Gerente(string nome, double qtdHoras, decimal valorHora, decimal bonus) : base(nome, qtdHoras, valorHora)
        {
            this.bonus = bonus;
        }

        

        public override decimal GetSalario()
        {
            return GetValorHora() * Convert.ToDecimal(GetQtdHoras()) + bonus;
        }
    }
}
