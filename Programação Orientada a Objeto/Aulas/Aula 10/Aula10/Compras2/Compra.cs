using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras2
{
    public class Compra
    {
        private List<Produto> produto;
        private int index;
        private double valorCompra;

        public Compra()
        {
            produto = new List<Produto>();
            index = -1;
        }

        public void SetProduto(string produto)
        {

            switch (produto)
            {
                case "1":
                    index++;
                    this.produto.Add(new Produto("Arroz", 9.19));
                    this.SetValorCompra(9.19);
                    break;
                case "2":
                    index++;
                    this.produto.Add(new Produto("Vinho", 16.39));
                    this.SetValorCompra(16.39);
                    break;
                case "3":
                    index++;
                    this.produto.Add(new Produto("Maça", 6.61));
                    this.SetValorCompra(6.61);
                    break;
                case "4":
                    index++;
                    this.produto.Add(new Produto("Carne", 14.96));
                    this.SetValorCompra(14.96);
                    break;
                case "5":
                    index++;
                    this.produto.Add(new Produto("Pera", 9.82));
                    this.SetValorCompra(9.82);
                    break;
                default:
                    index++;
                    this.produto.Add(new Produto("Pera", 9.82));
                    this.SetValorCompra(9.82);
                    break;
            }
        }

        public string GetNomeProduto()
        {
            return produto[index].NomeProduto;
        }

        public List<Produto> GetProduto()
        {
            return this.produto;
        }

        private void SetValorCompra(double valorCompra)
        {
            this.valorCompra += valorCompra;
        }

        public double GetValorCompra()
        {
            return this.valorCompra;
        }

    }
}
