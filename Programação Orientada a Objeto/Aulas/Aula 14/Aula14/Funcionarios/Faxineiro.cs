using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Faxineiro : Funcionario
    {
        private decimal adicional;
        private decimal valorEstipulado;
        private List<Faxineiro> faxineiro;
        private decimal valorTotal;

        public Faxineiro(string nome, decimal valorEstipulado) : base(0,"Faxineiro",nome,0)
        {
            this.adicional = 1.05m;
            this.valorEstipulado = valorEstipulado;
            faxineiro = new List<Faxineiro>();
        }

        public List<Faxineiro> GetFaxineiro()
        {
            return faxineiro;
        }

        public override decimal GetValorTotal()
        {
            return valorEstipulado * adicional;
        }

        public void Mostrar()
        {
            valorTotal = 0.0m;
            for (int i = 0; i < faxineiro.Count; i++)
            {
                Console.WriteLine("{0}                            {1}",
                    faxineiro[i].GetNome(), faxineiro[i].GetValorTotal());
                valorTotal += faxineiro[i].GetValorTotal();
            }
        }

        public decimal GetValorTotalFaxineiro()
        {
            return valorTotal;
        }
    }
}
