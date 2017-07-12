using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Programador : Funcionario
    {

        private string nivel;
        private List<Programador> programador;
        private decimal valorTotal;

        public Programador(string nivel,string nome,double qtdHoras) : base(0.0m, "Programador",nome,qtdHoras)
        {
            this.nivel = nivel;
            programador = new List<Programador>();
            this.valorHoraProgramador();
        }

        public List<Programador> GetProgramdor()
        {
            return programador;
        }

        public void valorHoraProgramador()
        {
            switch (nivel)
            {
                case "1":
                    SetValorHora(30);
                    break;
                case "2":
                    SetValorHora(45);
                    break;
                case "3":
                    SetValorHora(80);
                    break;
            }
        }


        public override decimal GetValorTotal()
        {
            return GetValorHora() * Convert.ToDecimal(GetQtdHoras());
        }

        public void Mostrar()
        {
            valorTotal = 0m;
            for (int i = 0; i < programador.Count; i++)
            {
                Console.WriteLine("{0}                            {1}",
                    programador[i].GetNome(), programador[i].GetValorTotal());
                valorTotal += programador[i].GetValorTotal();
            }
        }
     
        public decimal GetValorTotalProgramdor()
        {
            return valorTotal;
        }
           
    }
}
