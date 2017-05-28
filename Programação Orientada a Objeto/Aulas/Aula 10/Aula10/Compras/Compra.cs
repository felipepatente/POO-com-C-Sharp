using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    public class Compra
    {
        private List<Produto> produto;
        private int index;
        private int[] quantidade = new int[5];
        private double valorCompra;

        public Compra()
        {
            produto = new List<Produto>();
            this.InicializarProdutos();
        }

        public void SetProduto(string produto)
        {
            
            switch (produto)
            {
                case "1":
                    index = 0;
                    quantidade[0]++;
                    this.SetValorCompra(9.19);
                    break;
                case "2":
                    index = 1;
                    quantidade[1]++;
                    this.SetValorCompra(16.39);
                    break;
                case "3":
                    index = 2;
                    quantidade[2]++;
                    this.SetValorCompra(6.61);
                    break;
                case "4":
                    index = 3;
                    quantidade[3]++;
                    this.SetValorCompra(14.96);
                    break;
                case "5":
                    index = 4;
                    quantidade[4]++;
                    this.SetValorCompra(9.82);
                    break;
                default:
                    index = 4;
                    quantidade[4]++;
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

        public void InicializarProdutos()
        {
            this.produto.Add(new Produto("Arroz", 9.19));
            this.produto.Add(new Produto("Vinho", 16.39));
            this.produto.Add(new Produto("Maça", 6.61));
            this.produto.Add(new Produto("Carne", 14.96));
            this.produto.Add(new Produto("Pera", 9.82));
        }
        
        public int[] GetQuantidade()
        {
            return this.quantidade;
        }
    }
}
