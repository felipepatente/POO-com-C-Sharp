using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatoriais
{
    class Fatorial
    {
        private double _numero;

        public double Numero
        {
            get
            {
                return this._numero;
            }

            set
            {
                if (value >= 0)
                {
                    this._numero = value;
                }
            }
        }

        public double GetFatorial()
        {
            int fatorial = 0;

            if (this._numero >= 0)
            {
                fatorial = 1;

                for (int i = 1; i <= this._numero; i++)
                {
                    fatorial *= i;
                }
            }

            return fatorial;
        }

    }
}
