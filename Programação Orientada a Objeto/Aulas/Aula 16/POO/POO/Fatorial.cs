using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Fatorial
    {
        int n = 0;
        public Fatorial(int n)
        {
            if (n < 0)
            {
                throw new NumeroNegativoException(n);
            }
            this.n = n;
        }

        public int getResultado()
        {
            if ( n == 0 )
            {
                return 1;
            }
            else
            {
                Fatorial f = new Fatorial(n - 1);
                int resultado = n * f.getResultado();

                if (resultado <= 0)
                {
                    throw new EstouroException(n);
                }

                return resultado;
            }
        }
    }
}
