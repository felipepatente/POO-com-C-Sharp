namespace Math
{
    class Math
    {
        // quando você coloca static, volta-se ao paradigma procedimental (ou seja, não orientado a objetos)
        // static -> é só uma função...não está ligado a um objeto
        // com static, vc diz que o método só pertence a classe; você só vai conversa com a classe, e não com o objeto 
        // o método é sempre de um objeto, de uma instância

        // NÃO usar variáveis globais, pois você pode perder o controle sobre elas, se forem modificadas em alguma parte do código
        // public static readonly double PI = 3.141596535; --> se vc definir a variável como constante, ela não poderá ser alterada em nenhuma parrte do programa

        // constante é quando você dá um nome a um valor dentro do seu programa
        public const double PI = 3.14159635; // toda const é static por padrão
        public static double max(double a, double b)
        {
            return a > b ? a : b;
        }
    }
}
