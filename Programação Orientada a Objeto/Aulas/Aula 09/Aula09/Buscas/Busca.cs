using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscas
{
    public class Busca
    {
        private int numero;

        public void SetNumero(int numero)
        {
            if (numero >= 0 && numero <= 100)
            {
                this.numero = numero;
            }
        }

        public int GetNumero()
        {
            return this.numero;
        }


        public int GetPosicao()
        {
            int[] vetor = new int[100];
            Random rand = new Random();
            int posicao = -1;

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(10) + 1;
                if (this.numero == vetor[i])
                {
                   posicao = i;
                   break;
                }
            }

            return posicao;
        }
    }
}
