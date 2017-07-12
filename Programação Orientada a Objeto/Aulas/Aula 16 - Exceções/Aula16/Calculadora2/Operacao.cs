using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
   abstract class Operacao
    {

        private static Operacao[] operacoes = new Operacao[] {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
            new Divisao(),
            new Resto(),
            new Exponenciacao()
        };

        public static Operacao[] GetOperacoes()
        {
            return operacoes;
        }

        public static Operacao GetOperacao(string simbolo)
        {
            foreach (Operacao operacao in operacoes)
            {
                if (operacao.GetSimbolo() == simbolo)
                {
                    return operacao;
                }
            }

            throw new OperacaoInvalidaException();
        }

        public abstract double Calcula(double n1, double n2);

        public abstract string GetSimbolo();

    }
}
