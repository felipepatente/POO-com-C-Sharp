using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacoes2Grau
{
    public class Equacao
    {
        private double _a;
        private double _b;
        private double _c;


        
        public Equacao(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public Equacao() : this(0.0,0.0,0.0)
        {

        }

        
        public double GetDelta()
        {
            return Math.Pow(_b, 2) - 4 * _a * _c;
        }

        public double GetDelta(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;

            return Math.Pow(b, 2) - 4 * a * c;
        }


        public double GetX1()
        {
            return this.GetX1(this.GetDelta());
        }

        public double GetX1(double delta)
        {
            return (-this._b + Math.Sqrt(delta)) / (2 * _a);
        }


        public double GetX2()
        {
            return this.GetX2(this.GetDelta());
        }

        public double GetX2(double delta)
        {
            return (-this._b - Math.Sqrt(delta)) / (2 * _a);
        }



        public Double A
        {
            get
            {
                return _a;
            }

            set
            {
                this._a = value;
            }
        }

        public double B
        {
            get
            {
                return this._b;
            }

            set
            {
                this._b = value;
            }
        }

        public double C
        {
            get
            {
                return this._c;
            }

            set
            {
                this._c = value;
            }
        }
    }
}
