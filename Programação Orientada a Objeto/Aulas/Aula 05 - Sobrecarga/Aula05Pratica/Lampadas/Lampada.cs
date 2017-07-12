using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampadas
{
    class Lampada
    {
        public bool acesa;
        public bool queimada;

        public void SetAcender()
        {

            if (this.acesa == false)
            {
                this.acesa = this.GetLampadaQueimada()? false : true;
            }
        }

        public void SetApagar()
        {
            this.acesa = false;
        }

        public bool GetEstado()
        {
            return this.acesa;
        }

        private bool GetLampadaQueimada()
        {
            Random rand = new Random();
            int aleatorio = rand.Next(5) + 1;
            Console.WriteLine("Aleatorio: {0}", aleatorio);

            if (aleatorio == 5)
            {
                this.queimada = true;
            }else
            {
                this.queimada = false;
            }

            return this.queimada;
        }
    }
}
