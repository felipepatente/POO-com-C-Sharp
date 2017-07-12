using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Funcionario
    {
        private decimal valorHora;
        private string funcao;
        private string nome;
        private double qtdHoras;
        

        public Funcionario(decimal valorHora, string funcao, string nome, double qtdHoras)
        {
            this.valorHora = valorHora;
            this.funcao = funcao;
            this.nome = nome;
            this.qtdHoras = qtdHoras;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public decimal GetValorHora()
        {
            return this.valorHora;
        }

        public double GetQtdHoras()
        {
            return this.qtdHoras;
        }

        public void SetValorHora(decimal valorHora)
        {
            this.valorHora = valorHora;
        }

        public void SetQtdhoras(double qtdHoras)
        {
            this.qtdHoras = qtdHoras;
        }
    }
}
