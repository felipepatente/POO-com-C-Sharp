using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class FuncionarioPorHora : Funcionario
    {
        private double horas = 0;
        // para eu ter acesso a essa variável na classe programador
        // mudo para protected
        protected decimal valor = 0; 
        // outra alternativa é usar o método set ou uma sobrecarga

        public FuncionarioPorHora(string nome, double horas, decimal valor)
            :base(nome)
        {
            this.horas = horas;
            this.valor = valor;
        }

        public override decimal getSalario()
        {
            return Convert.ToDecimal(horas) * valor;
        }
    }
}
