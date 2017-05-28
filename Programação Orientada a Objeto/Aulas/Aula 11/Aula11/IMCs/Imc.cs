using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCs
{
    public class Imc
    {
        private double peso, altura;

        public Imc(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double GetValor()
        {
            return peso / (altura * altura);
        }


        public string GetCategoria()
        {
            string categoria;
            double imc = this.GetValor();

            if (imc < 18.5)
            {
                categoria = "Abaixo do peso";
            }else if (imc < 25)
            {
                categoria = "Peso normal";
            }else
            {
                categoria = "Acima do peso";
            }

            return categoria;
        }









    }
}
