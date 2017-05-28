using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class TemperaturaCelsius
    {

        private double _c;

        public TemperaturaCelsius(double c)
        {
            this._c = c;
        }

        public double C
        {
            get { return _c; }
        }

        public double F
        {
            get
            {
                return (9.0 / 5.0) * C + 32;
            }
        }

    }
}
