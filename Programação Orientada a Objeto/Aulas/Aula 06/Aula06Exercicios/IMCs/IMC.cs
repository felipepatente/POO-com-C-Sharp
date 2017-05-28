using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCs
{
    public class IMC
    {
        private string nome;
        private double peso;
        private double altura;

        public IMC(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetPeso(double peso)
        {
            if (peso >= 0)
            {
                this.peso = peso;
            }
        }

        public void SetAltura(double altura)
        {
            if (altura >= 0)
            {
                this.altura = altura;
            }
        }

        public double GetMassaCorporal()
        {
            return this.peso / (Math.Pow(this.altura, 2));
        }

        public int GetCategoria()
        {
            double massaCorporal = this.GetMassaCorporal();
            int categoria = 3;

            if (massaCorporal < 18.5)
            {
                categoria = 0;
            }else if (massaCorporal >= 18.5 && massaCorporal < 25)
            {
                categoria = 1;
            }else if (massaCorporal >= 25 && massaCorporal < 30)
            {
                categoria = 2;
            }
            
            return categoria;
        }
    }
}
