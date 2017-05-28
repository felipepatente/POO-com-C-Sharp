using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formigas
{
    public class Tabuleiro
    {
        private int linhas;
        private int colunas;
        private int linhaInicial;
        private int colunaInicial;
        private string direcao;
        private string[,] tabuleiro;

        public Tabuleiro(int linhas, int colunas, int linhaInicial, int colunaInicial, string direcao)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.linhaInicial = linhaInicial;
            this.colunaInicial = colunaInicial;
            this.direcao = direcao;
            this.tabuleiro = new string[linhas, colunas];
            this.Preencher();
            this.ColocarDirecao();
        }

        public int GetColunas()
        {
            return this.colunas;
        }
        
        private void Preencher()
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    tabuleiro[i, j] = ".";
                }
            }
        }

        public void ColocarDirecao()
        {
            switch (this.direcao.ToUpper())
            {
                case "N":
                    tabuleiro[linhaInicial, colunaInicial] = "^";
                    break;
                case "S":
                    tabuleiro[linhaInicial, colunaInicial] = "v";
                    break;
                case "L":
                    tabuleiro[linhaInicial, colunaInicial] = ">";
                    break;
                case "O":
                    tabuleiro[linhaInicial, colunaInicial] = "<";
                    break;
            }
        }

        public void MostarTabuleiro()
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(tabuleiro[i, j]);
                }
                Console.WriteLine();
            }
        }
        
        public void MovimentoFormiga()
        {
            //Processo de virar para direira
            if (tabuleiro[linhaInicial, colunaInicial + 1] != "#" && tabuleiro[linhaInicial, colunaInicial] == "^")
            {
                tabuleiro[linhaInicial, colunaInicial] = "#";
                colunaInicial++;
                tabuleiro[linhaInicial, colunaInicial] = ">";
            }
            else if (tabuleiro[linhaInicial + 1, colunaInicial] != "#" && tabuleiro[linhaInicial, colunaInicial] == ">")
            {
                tabuleiro[linhaInicial, colunaInicial] = "#";
                linhaInicial++;
                tabuleiro[linhaInicial, colunaInicial] = "v";
            }
            else if (tabuleiro[linhaInicial, colunaInicial - 1] != "#" && tabuleiro[linhaInicial, colunaInicial] == "v")
            {
                tabuleiro[linhaInicial, colunaInicial] = "#";
                colunaInicial--;
                tabuleiro[linhaInicial, colunaInicial] = "<";
            }
            else if (tabuleiro[linhaInicial - 1, colunaInicial] != "#" && tabuleiro[linhaInicial, colunaInicial] == "<")
            {
                tabuleiro[linhaInicial, colunaInicial] = "#";
                linhaInicial--;
                tabuleiro[linhaInicial, colunaInicial] = "^";

            }
            else
            {
                MovivemtarEsquerda();
            }



        }

        private void MovivemtarEsquerda()
        {
            if (tabuleiro[linhaInicial, colunaInicial] == "<" && tabuleiro[linhaInicial - 1, colunaInicial] == "#")
            {
                tabuleiro[linhaInicial, colunaInicial] = "#";
                tabuleiro[linhaInicial - 1, colunaInicial] = ".";
                linhaInicial--;
                colunaInicial--;
                tabuleiro[linhaInicial, colunaInicial] = "<";

            }
            else if (tabuleiro[linhaInicial, colunaInicial] == ">" && tabuleiro[linhaInicial + 1, colunaInicial] == "#")
            {
                tabuleiro[linhaInicial, colunaInicial] = "#";
                tabuleiro[linhaInicial + 1, colunaInicial] = ".";
                linhaInicial++;
                colunaInicial++;
                tabuleiro[linhaInicial, colunaInicial] = ">";

            }
            else if (tabuleiro[linhaInicial, colunaInicial] == "^" && tabuleiro[linhaInicial, colunaInicial + 1] == "#")
            {
                tabuleiro[linhaInicial, colunaInicial] = "#";
                tabuleiro[linhaInicial, colunaInicial + 1] = ".";
                linhaInicial--;
                colunaInicial++;
                tabuleiro[linhaInicial, colunaInicial] = "^";
            }
            else if (tabuleiro[linhaInicial, colunaInicial] == "v" && tabuleiro[linhaInicial, colunaInicial - 1] == "#")
            {
                tabuleiro[linhaInicial, colunaInicial] = "#";
                tabuleiro[linhaInicial, colunaInicial - 1] = ".";
                linhaInicial++;
                colunaInicial--;
                tabuleiro[linhaInicial, colunaInicial] = "v";
            }
        }

    }
}
