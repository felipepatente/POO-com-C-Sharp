using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    public class ContaPoupanca : Conta
    {
        private decimal rendimento;

        public ContaPoupanca(int numConta, string nome) : base(numConta, nome)
        {
            this.rendimento = 1.05m;
        }

        public decimal GetViradaMes()
        {
            return GetSaldo() * this.rendimento;
        }
    }
}
