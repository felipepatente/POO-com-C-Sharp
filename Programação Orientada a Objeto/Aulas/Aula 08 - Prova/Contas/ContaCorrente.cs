using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    class ContaCorrente
    {
        private double _saldo;

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
        }

        public void Sacar(double valor)
        {
            if (valor >= 0 && valor <= this._saldo)
            {
                this._saldo -= valor;
            }
        }


        public void Depositar(double valor)
        {
            if (valor >= 0)
            {
                this._saldo += valor;
            }
        }
    }
}
