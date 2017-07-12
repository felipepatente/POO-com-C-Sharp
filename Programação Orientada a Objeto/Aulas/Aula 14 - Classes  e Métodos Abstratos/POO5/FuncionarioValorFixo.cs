using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class FuncionarioValorFixo : Funcionario
    {
        private decimal valor = 0;

        public FuncionarioValorFixo(string nome, decimal valor)
            :base(nome)
        {
            this.valor = valor;
        }

        public override decimal getSalario()
        {
            return valor;
        }
    }
}
