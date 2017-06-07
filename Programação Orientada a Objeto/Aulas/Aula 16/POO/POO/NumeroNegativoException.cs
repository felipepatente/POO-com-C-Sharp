namespace Fatorial
{
    class NumeroNegativoException : FatorialException
    {
        public NumeroNegativoException(int n)
            : base(n, "Usuário, por favor, entre com um número inteiro NÃO-NEGATIVO!")
        {
        }
    }
}
