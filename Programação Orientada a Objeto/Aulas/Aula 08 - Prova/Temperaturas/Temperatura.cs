using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    class Temperatura
    {
        private double _c;
        
        public double C
        {
            get
            {
                return this._c;
            }

            set
            {
                this._c = value;
            }
        }


        public double GetFahrenheit()
        {
            return (9 / 5d) * _c + 32;
        }

    }
}
