using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosIMC
{
    class Imc
    {
        public string nome;
        public double peso;
        public double altura;

        public Imc(string nome, double peso, double altura)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
        }

        public double GetIndice()
        {
            return this.peso / (Math.Pow(this.altura, 2));
        }
        

        public int GetCategoria()
        {
            double indice = this.GetIndice();
            int categoria = 0;

            if (indice >= 18.5 && indice < 25)
            {
                categoria = 1;
            }else if (indice >= 25 && indice < 30)
            {
                categoria = 2;
            }else if (indice >= 30)
            {
                categoria = 3;
            }

            return categoria;
        }
    }
}
