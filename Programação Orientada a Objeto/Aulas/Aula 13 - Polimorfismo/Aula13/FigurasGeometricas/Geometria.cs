﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Geometria
    {
        private double coordenadaX;
        private double coordenadaY;

        public Geometria(double coordenadaX, double coordenadaY)
        {
            this.coordenadaX = coordenadaX;
            this.coordenadaY = coordenadaY;
        }


        public virtual double GetPerimetro()
        {
            return 0;
        }

        public virtual double GetArea()
        {
            return 0;
        }
    }
}
