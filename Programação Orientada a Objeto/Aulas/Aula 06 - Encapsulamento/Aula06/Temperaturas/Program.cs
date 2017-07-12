using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("°C: ");
            double c = double.Parse(Console.ReadLine());

            TemperaturaCelsius temperatura = new TemperaturaCelsius(c);

            Console.WriteLine("{0}°C = {1}°F ", temperatura.C, temperatura.F);

        }
    }
}
