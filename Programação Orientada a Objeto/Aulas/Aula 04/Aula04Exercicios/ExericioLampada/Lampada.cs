using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericioLampada
{
    class Lampada
    {
        public bool situacao;

        public bool GetLampada(string lampada)
        {
            this.situacao = false;

            if (lampada == "L")
            {
                this.situacao = true;
            }

            return this.situacao;
        }
    }
}
