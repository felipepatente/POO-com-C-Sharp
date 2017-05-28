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

        public Double Saldo
        {
            get
            {
                return this._saldo;
            }
        }

        public double Depositar {
            set
            {
                if (value >= 0)
                {
                    this._saldo += value;
                }
            }
        }

        public double Sacar
        {
            set
            {
                if (value >= 0 && value <= this._saldo)
                {
                    this._saldo -= value;
                }
            }
        }

    }
}
