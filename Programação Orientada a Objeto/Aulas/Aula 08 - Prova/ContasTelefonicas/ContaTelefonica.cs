using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasTelefonicas
{
    class ContaTelefonica
    {

        private readonly double assinatura = 23.32;
        private readonly double locais = 0.09;
        private readonly double interurbanas = 0.26;
        private readonly double internacionais = 0.86;


        private double ligacoesLocais;
        private double ligacoesInterurbanas;
        private double ligacoesInternacionais;


        public void SetLocais(double ligacoesLocais)
        {
            if (ligacoesLocais > 0)
            {
                this.ligacoesLocais = ligacoesLocais;
            }
        }

        public void SetInterurbanas(double ligacoesInterurbanas)
        {
            if (ligacoesInterurbanas > 0)
            {
                this.ligacoesInterurbanas = ligacoesInterurbanas;
            }
        }

        public void SetInternacionais(double ligacoesInternacionais)
        {
            if (ligacoesInternacionais > 0)
            {
                this.ligacoesInternacionais = ligacoesInternacionais;
            }
        }

        public double GetValorLocais()
        {
            return this.ligacoesLocais * this.locais;
        }
        
        public double GetValorInterurbanas()
        {
            return this.ligacoesInterurbanas * this.interurbanas;
        }

        public double GetValorInternacionais()
        {
            return this.ligacoesInternacionais * this.internacionais;
        }


        public double GetValorTotal()
        {
            return this.GetValorInternacionais() + this.GetValorInterurbanas() + this.GetValorLocais();
        }
    }
}
