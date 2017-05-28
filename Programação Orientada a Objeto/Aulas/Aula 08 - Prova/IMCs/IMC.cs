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
        private double kg;
        private double altura;

        public IMC(string nome)
        {
            this.nome = nome;
        }

        public void SetKg(double kg)
        {
            if (kg > 0)
            {
                this.kg = kg;
            }
        }

        public void SetAltura(double altura)
        {
            if (altura > 0)
            {
                this.altura = altura;
            }
        }
        
        public string GetNome()
        {
            return this.nome;
        }

        public double GetMassaCorporal()
        {
            return kg / (Math.Pow(altura, 2));
        }

        public int GetCategoria()
        {
            int categoria = 0;
            double massa = GetMassaCorporal();

            if (massa >= 18.5 && massa < 25.00)
            {
                categoria = 1;
            }else if (massa >= 25.00 && massa < 30)
            {
                categoria = 2;
            }else if (massa >= 30)
            {
                categoria = 3;
            }

            return categoria;
        }
    }
}


            