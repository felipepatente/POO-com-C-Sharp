using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskaraAsAvessas
{
    class BhaskaraAsAvessa
    {
        private double x1;
        private double x2;
        private double _c;

        public BhaskaraAsAvessa(double x1, double x2, double c)
        {
            this.x1 = x1;
            this.x2 = x2;
            this._c = c;
        }


        public double GetSomaRaiz()
        {
            return x1 + x2;
        }

        public double GetMultRaiz()
        {
            return x1 * x2;
        }

        public double GetA(double multRaiz)
        {
           return multRaiz / multRaiz;
        }

        public double GetB(double somaRaiz, double a)
        {
            return (somaRaiz / a) * -1;
        }

        public double C
        {
            get
            {
                return this._c;
            }
        }
    }
}
