using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoras
{
    class Calculadora
    {
        public double _num1;
        public double _num2;
        public string _operacao;

        public Calculadora(double num1, double num2, string operacao)
        {
            this._num1 = num1;
            this._num2 = num2;
            this._operacao = operacao;
        }

        public Calculadora(double num1, double num2) : this(num1, num2, "+"){}
        public Calculadora(string operacao) : this(0.0,0.0,operacao){}
        public Calculadora() : this(0.0,0.0,"+") {}

        public double GetCalculo(double num1, double num2, string operacao)
        {
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }

            return resultado;
        }


        public double GetCalculo(double num1, double num2)
        {
            return this.GetCalculo(num1, num2, this._operacao);
        }

        public double GetCalculo(string operacao)
        {
            return this.GetCalculo(this._num1,this._num2, operacao);
        }

        public double GetCalculo()
        {
            return this.GetCalculo(this._num1, this._num2, this._operacao);
        }

        public double Num1 {

            get
            {
                return _num1;
            }

            set
            {
                this._num1 = value;
            }

        }


        public double Num2
        {

            get
            {
                return _num2;
            }

            set
            {
                this._num2 = value;
            }

        }

        public string Operacao
        {
            get
            {
                return this._operacao;
            }

            set
            {
                this._operacao = value;
            }
        }
    }
}

