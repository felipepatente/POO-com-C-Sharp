using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTriangulo2
{
    class Triangulo
    {
        public int triangulo1Medida1;
        public int triangulo1Medida2;
        public int triangulo1Medida3;
        public int triangulo2Medida1;
        public int triangulo2Medida2;
        public int triangulo2medida3;

        public Triangulo(int triangulo1Medida1, int triangulo1Medida2, int triangulo1Medida3, int triangulo2Medida1,
            int triangulo2Medida2, int triangulo2Medida3)
        {
            this.triangulo1Medida1 = triangulo1Medida1;
            this.triangulo1Medida2 = triangulo1Medida2;
            this.triangulo1Medida3 = triangulo1Medida3;
            this.triangulo2Medida1 = triangulo2Medida1;
            this.triangulo2Medida2 = triangulo2Medida2;
            this.triangulo2medida3 = triangulo2Medida3;
        }


        public bool GetEIgual()
        {
            bool eTriangulo = false;

            if (triangulo1Medida1 == triangulo2Medida1 && triangulo1Medida2 == triangulo2Medida2 &&
                triangulo1Medida3 == triangulo2medida3)
            {
                eTriangulo = true;
            }

            return eTriangulo;
        }
    }
}
