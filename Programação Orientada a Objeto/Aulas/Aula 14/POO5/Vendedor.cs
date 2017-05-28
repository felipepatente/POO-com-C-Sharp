using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Vendedor : FuncionarioValorFixo
    {
        private decimal valorVendas;

        public Vendedor(string nome, decimal valorVendas)
            : base(nome, 2000)
        {
            this.valorVendas = valorVendas;
        }

        public override decimal getSalario()
        {
            // boa prática de programação
            //decimal comissao = 0.2M * valorVendas;
            return base.getSalario() + getComissao();
            //return base.getSalario() + (0.2M * valorVendas);
        }

        public decimal getComissao()
        {
            return 0.2M * valorVendas;
        }
    }
}
