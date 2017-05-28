using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    public class ContaEspecial : Conta
    {
        private decimal limiteCredito;

        public ContaEspecial(int numConta, string nome) : base(numConta, nome)
        {
            this.limiteCredito = 0.1m;
        }

        public decimal GetViradaMes()
        {
            return GetSaldo() - (GetSaldo() * this.limiteCredito);
        }
    }
}
