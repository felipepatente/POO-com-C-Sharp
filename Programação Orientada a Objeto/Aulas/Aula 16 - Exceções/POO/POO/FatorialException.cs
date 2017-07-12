using System;

namespace Fatorial
{
    class FatorialException : Exception
    {
        private int n = 0;

        // aqui estou passando a mensagem para a Exception (classe base)
        public FatorialException(int n, string msg)
            : base(msg)
        {
            this.n = n;
        }

        public int getN()
        {
            return n;
        }
    }
}
