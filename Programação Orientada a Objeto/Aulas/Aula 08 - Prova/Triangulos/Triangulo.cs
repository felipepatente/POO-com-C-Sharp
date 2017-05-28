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
                if (value > 0)
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
                if (value > 0)
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
                if (value > 0)
                {
                    this._medida3 = value;
                }
            }
        }


        public bool ETriangulo()
        {
            return _medida1 < (_medida2 + _medida3) && _medida2 < (_medida1 + _medida3) && _medida3 < (_medida1 + _medida2);
        }

        public int GetTipo()
        {

            int etriangulo = -1;

            if (ETriangulo())
            {
                if (_medida1 == _medida2 && _medida2 == _medida3)
                {
                    etriangulo = 0;
                }else if (_medida1 != _medida2 && _medida2 != _medida3 && _medida1 != _medida3)
                {
                    etriangulo = 1;
                }else
                {
                    etriangulo = 2;
                }
            }

            return etriangulo;
        }
    }
}
            