using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampadas
{
    class Lampada
    {
        private bool _acessa;

        public bool Acessa
        {
            get
            {
                return this._acessa;
            }
        }

        public void AcenderLampada()
        {
            if (!this._acessa)
            {
                if (this.EstaQueimada())
                {
                    this._acessa = false;
                }
                else
                {
                    this._acessa = true;
                }
            }
            
        }

        public void ApagarLampada()
        {
            this._acessa = false;
        }

        public bool EstaQueimada()
        {
            Random rand = new Random();
            int queimada = rand.Next(5) + 1;
            bool estaQueimada = false;
            
            if (queimada == 5)
            {
                estaQueimada = true;
            }

            return estaQueimada;
        }

    }
}
