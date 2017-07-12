using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    class Lampada
    {
        public bool acesa;

        public Lampada() {
            acesa = false;
        }

        public string GetEstado() {
            return acesa ? "Acesa": "Apagada";
        }

        public void Acender() {
            acesa = true;
        }


        public void Apagar() {
            acesa = false;
        }
    }
}
