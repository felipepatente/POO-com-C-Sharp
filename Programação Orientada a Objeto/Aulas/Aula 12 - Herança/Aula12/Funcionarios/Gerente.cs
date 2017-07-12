using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Gerente : Funcionario
    {
        private decimal bonusFixo;
        private List<Gerente> gerente;
        private decimal valorTotal;

        public Gerente(double qtdHoras, decimal bonusFixo,string nome) : base(100.0m,"Gerente",nome,qtdHoras)
        {
            this.bonusFixo = bonusFixo;
            gerente = new List<Gerente>();
        }

        public decimal GetValorTotal()
        {
            return GetValorHora() * Convert.ToDecimal(GetQtdHoras()) + bonusFixo;
        }

        public List<Gerente> GetGerente()
        {
            return gerente;
        }

        public void Mostrar()
        {
            valorTotal = 0.0m;
            for (int i = 0; i < gerente.Count; i++)
            {
                Console.WriteLine("{0}                            {1}",
                    gerente[i].GetNome(), gerente[i].GetValorTotal());
                valorTotal += gerente[i].GetValorTotal();
            }
        }

        public decimal GetValorTotalGerente()
        {
            return valorTotal;
        }
    }
}
