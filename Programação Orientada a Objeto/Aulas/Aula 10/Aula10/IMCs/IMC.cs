using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCs
{
    public class IMC
    {
        private Pessoa nomePessoa;
        private double altura;
        private double peso;

        public IMC(Pessoa nomePessoa, double altura, double peso)
        {
            this.nomePessoa = nomePessoa;
            this.altura = altura;
            this.peso = peso;
        }


        public string GetNomePessoa()
        {
            return this.nomePessoa.Nome;
        }

        public double GetMassaCorporal()
        {
            return this.peso / Math.Pow(this.altura, 2);
        }

        public int GetCategoria()
        {
            double massaCorporal = this.GetMassaCorporal();
            int categoria = 0;

            if (massaCorporal >= 18.5 && massaCorporal < 25)
            {
                categoria = 1;
            }
            else if(massaCorporal >= 25 && massaCorporal < 30)
            {
                categoria = 2;
            }else if (massaCorporal >= 30)
            {
                categoria = 3;
            }

            return categoria;
        }
    }
}
