using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Triangulo
    {
        private double _medida1;
        private double _medida2;
        private double _medida3;

        public double Medida1
        {
            get
            {
                return this._medida1;
            }

            set
            {
                if (value >= 0)
                {
                    this._medida1 = value;
                }
            }
        }

        public double Medida2
        {
            get
            {
                return this._medida2;
            }

            set
            {
                if (value >= 0)
                {
                    this._medida2 = value;
                }
            }
        }

        public double Medida3
        {
            get
            {
                return this._medida3;
            }

            set
            {
                if (value >= 0)
                {
                    this._medida3 = value;
                }
            }
        }
        
        public bool ETriangulo()
        {
            return (this._medida1 + this.Medida2) > this._medida3 && (this._medida2 + this.Medida3) > this.Medida2
                && (this.Medida2 + this.Medida3) > this.Medida1;
        }

        public int GetTipo()
        {
            int tipo = 2;

            if (this.ETriangulo())
            {
                if (this._medida1 == this.Medida2 && this.Medida2 == this.Medida3)
                {
                    tipo = 0;
                }else if (this.Medida1 != this.Medida2 && this.Medida1 != this.Medida3 && this.Medida2 != this.Medida3)
                {
                    tipo = 1;
                }
            }

            return tipo;
        }

    }
}
