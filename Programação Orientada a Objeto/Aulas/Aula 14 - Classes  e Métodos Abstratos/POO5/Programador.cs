using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Programador : FuncionarioPorHora
    {
        private string nivel = "";

        // posso passar qualquer valor da hora pq no construtor setarei o certo
        public Programador(string nome, string nivel, double horas)
            : base(nome, horas, getValor(nivel))
        {
            this.nivel = nivel;
        }

        public static decimal getValor(string nivel)
        {
            switch(nivel)
            {
                case "JR": return 30;
                case "PL": return 45;
                case "SR": return 80;
                default: return 0; // new ArgumentException(); 
            }
        }
    }
}
