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
            double c = -10;

            Temperatura temp = new Temperatura();
            temp.C = c;

            Console.WriteLine("Celsius   para     Fahrenheit");
            while (temp.C <= 110){
                Console.WriteLine("{0}                 {1}", temp.C, temp.GetFahrenheit());
                temp.C += 0.5;
            }
        }
    }
}

/*Escreva um algoritmo que mostra uma tabela de conversão de temperaturas de °C para °F, 
 * começando com -10°C e indo até 110°C em passos de 0,5°C.*/
