using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class FaxineiroNoturno : FuncionarioValorFixo
    {
        public FaxineiroNoturno(string nome, decimal valor)
            : base(nome, valor)
        {
        }

        public override decimal getSalario()
        {
            return base.getSalario() + getAdicional();
        }

        public decimal getAdicional()
        {
            return 0.05M * base.getSalario();
        }
    }
}
