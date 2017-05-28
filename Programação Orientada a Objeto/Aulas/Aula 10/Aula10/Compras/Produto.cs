using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    public class Produto
    {
        private string nomeProduto;
        private double preco;

        public Produto(string nomeProduto, double preco)
        {
            this.nomeProduto = nomeProduto;
            this.preco = preco;
        }

        public string NomeProduto
        {
            get
            {
                return this.nomeProduto;
            }

            set
            {
                this.nomeProduto = value;
            }
        }

        public double Preco
        {
            get
            {
                return this.preco;
            }
        }
    }
}
