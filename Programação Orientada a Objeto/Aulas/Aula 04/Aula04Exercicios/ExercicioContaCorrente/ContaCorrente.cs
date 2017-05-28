using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaCorrente
{
    class ContaCorrente
    {
        public decimal saldo;

        public decimal GetSaldo()
        {
            return this.saldo;
        }

        public void setDepositar(decimal valor)
        {
            this.saldo += valor;
        }

        public void setSacar(decimal valor)
        {
            if ((this.saldo - valor) >= 0)
            {
                this.saldo -= valor;
            }
        }
    }
}
