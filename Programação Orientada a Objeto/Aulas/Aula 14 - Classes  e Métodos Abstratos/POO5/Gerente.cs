using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Gerente : FuncionarioPorHora
    {
        private decimal bonus = 0;

        public Gerente(string nome, decimal bonus, double horas)
            : base(nome, horas, 100)
        {
            this.bonus = bonus;
        }

        public override decimal getSalario()
        {
            return base.getSalario() + bonus;
        }
    }
}
