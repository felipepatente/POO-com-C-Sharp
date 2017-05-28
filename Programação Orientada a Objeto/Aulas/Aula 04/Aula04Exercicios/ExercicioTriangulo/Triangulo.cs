using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTriangulo
{
    class Triangulo
    {
        public int medida1;
        public int medida2;
        public int medida3;

        public Triangulo(int medida1, int medida2, int medida3)
        {
            this.medida1 = medida1;
            this.medida2 = medida2;
            this.medida3 = medida3;
        }

        public bool GetETriangulo()
        {
            return medida1 < (medida2 + medida3) && medida2 < (medida1 + medida3) && medida3 < (medida1 + medida2);
        }

        public string GetTipoTriangulo()
        {
            string tipo = "";

            if (this.GetETriangulo())
            {
                if (medida1 == medida2 && medida2 == medida3)
                {
                    tipo = "Equilátero";
                }else if (medida1 == medida2 || medida1 == medida3 || medida2 == medida3)
                {
                    tipo = "Isóceles";
                }
                else
                {
                    tipo = "Escaleno";
                }
            }

            return tipo;
        }
    }
}
