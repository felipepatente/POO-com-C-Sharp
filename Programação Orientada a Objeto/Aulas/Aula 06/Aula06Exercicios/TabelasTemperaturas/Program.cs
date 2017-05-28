using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = -10;

            Console.WriteLine("°C  para  °F");
            while (celsius <= 110)
            {
                Temperatura temperatura = new Temperatura(celsius);
                Console.WriteLine("{0}      {1}", temperatura.celsius, temperatura.GetFahrenheit());
                celsius += 0.5;
            }
            
        }
    }
}
/*
Escreva um algoritmo que mostra uma tabela de conversão de temperaturas de °C para °F, começando com -10°C e 
indo até 110°C em passos de 0,5°C.
 */
