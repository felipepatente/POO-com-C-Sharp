using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Vendedor : Funcionario
    {
        private decimal comissao;
        private decimal valorFixo;
        private decimal totalVendas;
        private List<Vendedor> vendedor;
        private decimal valorTotal;

        public Vendedor(decimal totalVendas, string nome) : base(0.0m, "Vendedor", nome, 0.0d)
        {
            this.comissao = 0.20m;
            this.valorFixo = 2000;
            this.totalVendas = totalVendas;
            this.vendedor = new List<Vendedor>();
        }

        public List<Vendedor> GetVendedor()
        {
            return vendedor;
        }

        public override decimal GetValorTotal()
        {
            return valorFixo + (totalVendas * comissao);
        }

        public void Mostrar()
        {
            valorTotal = 0.0m;
            for (int i = 0; i < vendedor.Count; i++)
            {
                Console.WriteLine("{0}                            {1}",
                    vendedor[i].GetNome(), vendedor[i].GetValorTotal());
                valorTotal += vendedor[i].GetValorTotal();
            }
        }

        public decimal GetValorTotalVendedor()
        {
            return valorTotal;
        }
    }
}
