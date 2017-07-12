using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCs
{
    public class Pessoa
    {
        private string nome;
        private double peso, altura;

        public Pessoa(string nome, double peso, double altura)
        {
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
        }

        public string GetNome()
        {
            return nome;
        }

        public double GetPeso()
        {
            return peso;
        }

        public double GetAltura()
        {
            return altura;
        }

        public Imc GetImc()
        {
            return new Imc(altura,peso);
        }













    }
}
