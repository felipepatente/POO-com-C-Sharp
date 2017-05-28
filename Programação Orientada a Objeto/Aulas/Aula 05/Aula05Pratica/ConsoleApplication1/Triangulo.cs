using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangulo
    {
        public double lado1;
        public double lado2;
        public double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }


        public bool GetIgual(Triangulo outro)
        {


            bool situacao1 = this.lado1 == outro.lado1 && this.lado2 == outro.lado2 && this.lado3 == outro.lado3;
            bool situacao2 = this.lado1 == outro.lado2 && this.lado2 == outro.lado3 && this.lado3 == outro.lado1;
            bool situacao3 = this.lado1 == outro.lado3 && this.lado2 == outro.lado1 && this.lado3 == outro.lado2;

            bool situacao4 = this.lado1 == outro.lado1 && this.lado2 == outro.lado3 && this.lado3 == outro.lado2;
            bool situacao5 = this.lado2 == outro.lado2 && this.lado3 == outro.lado1 && this.lado1 == outro.lado3;
            bool situacao6 = this.lado3 == outro.lado3 && this.lado1 == outro.lado2 && this.lado2 == outro.lado1;

            return situacao1 || situacao2 || situacao3|| situacao4 || situacao5 || situacao6;
            
        }

    }
}
