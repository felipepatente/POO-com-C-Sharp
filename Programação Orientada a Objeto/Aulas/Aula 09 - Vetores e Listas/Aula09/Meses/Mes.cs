using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meses
{
    public class Mes
    {
        private int numero;

        public void SetNumero(int numero)
        {
            numero--;
            if (numero >= 0 && numero <= 11)
            {
                this.numero = numero;
            }
        }

        public int GetDias()
        {
            int mes = this.numero;
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return dias[mes];
        }

        public string GetMes()
        {
            string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            return mes[this.numero];
        }
    }
}
