using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoras
{
    class Calculadora
    {
        private double num1;
        private double num2;
        private string operador;

        public Calculadora(double num1, double num2, string operador)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.operador = operador;
        }


        public double GetResultado()
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
        
    }
}
