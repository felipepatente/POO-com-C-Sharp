using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaTelefonica
{
    class ContaTelefonica
    {
        
        public const decimal assinatura = 23.32M;
        public const decimal locais = 0.09M;
        public const decimal interurbanas = 0.26M;
        public const decimal internacionais = 0.86M;

        public double minutosLocais;
        public double minutosInterurbanas;
        public double minutosInternacionais;

        public ContaTelefonica(double minutosLocais, double minutosInterurbanas, double minutosInternacionais)
        {
            this.minutosLocais = minutosLocais;
            this.minutosInterurbanas = minutosInterurbanas;
            this.minutosInternacionais = minutosInternacionais;
        }

        public decimal GetAssinatura()
        {
            return assinatura;
        }

        public decimal GetValorLocais()
        {
            return Convert.ToDecimal(this.minutosLocais) * locais;
        }

        public decimal GetValorInterurbanos()
        {
            return Convert.ToDecimal(this.minutosInterurbanas) * interurbanas;
        }


        public decimal GetValorInternacionais()
        {
            return Convert.ToDecimal(this.minutosInternacionais) * internacionais;
        }

        public decimal GetValorTotal()
        {
            return this.GetValorInternacionais() + this.GetValorInterurbanos() + this.GetValorLocais();
        }
        
    }
}
