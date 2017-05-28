using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertes
{
    public class Inverte
    {
        private string[] palavras;

        public Inverte(string[] palavras)
        {
            this.palavras = palavras;
        }

        public string[] GetInverter()
        {
            string[] inverter = new string[10];
            int j = 9;
            for (int i = 0; i < 10; i++)
            {
                inverter[j] = this.palavras[i];
                j--;
            }

            return inverter;
        }
    }
}
