using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("P1: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.Write("P2: ");
            double p2 = double.Parse(Console.ReadLine());


            Aluno aluno = new Aluno(nome);
            aluno.P1 = p1;
            aluno.P2 = p2;
            double media = aluno.GetMedia();
            bool passou = aluno.IsAprovado(media);


            if (passou)
            {
                Console.WriteLine("O aluno {0} passou com média {1}.", aluno.Nome, media);
            }else
            {
                Console.WriteLine("O aluno {0} NÃO passou com média {1}.", aluno.Nome, media);
            }
        }
    }
}
