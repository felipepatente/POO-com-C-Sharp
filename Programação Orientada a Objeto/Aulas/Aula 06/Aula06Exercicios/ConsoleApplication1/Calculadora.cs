using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Calculadora
    {

        private double num1;
        private double num2;

        public Calculadora(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double GetCalculo(string operador)
        {

            double resultado = 0;

            switch (operador)
            {
                case "*":
                    resultado = this.num1 * this.num2;
                    break;
                case "-":
                    resultado = this.num1 - this.num2;
                    break;
                case "+":
                    resultado = this.num1 + this.num2;
                    break;
                case "/":
                    resultado = this.num1 / this.num2;
                    break;
            }
            return resultado;
        }

    }
}

