// esta classe foi criada para que possamos tratar erros de classes diferentes para não dar conflito
// quando precisarmos tratar a mesma exceção mais de uma vez

namespace Fatorial
{
    class EstouroException : FatorialException
    {
        public EstouroException(int n)
            : base(n, "Não consigo calcular o fatorial de " + n + "!")
        {
        }
    }
}
