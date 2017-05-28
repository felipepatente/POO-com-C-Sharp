using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    public class Conta
    {
        private decimal saldo;
        private int numConta;
        private string nome;

        public Conta(int numConta, string nome)
        {
            this.numConta = numConta;
            this.nome = nome;
            this.saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if ((this.saldo - valor) >= 0)
            {
                this.saldo -= valor;
            }
        }

        public decimal GetSaldo()
        {
            return this.saldo;
        }
    }
}
