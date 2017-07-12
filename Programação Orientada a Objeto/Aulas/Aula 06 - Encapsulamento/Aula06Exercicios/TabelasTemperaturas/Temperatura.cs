using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasTemperaturas
{
    public class Temperatura
    {
        public double celsius { get; set; }

        public Temperatura(double celsius)
        {
            this.celsius = celsius;
        }

        public double GetFahrenheit()
        {
            return (9 / 5d) * this.celsius + 32;
        }
        
    }
}
