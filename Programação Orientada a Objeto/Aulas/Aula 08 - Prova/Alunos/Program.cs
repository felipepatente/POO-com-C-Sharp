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
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a frequência do aluno: ");
            double frequencia = double.Parse(Console.ReadLine());

            Console.Write("Digite a 1° nota da prova: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 2° nota da prova: ");
            double nota2 = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome);
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Frequencia = frequencia;
            double media = aluno.GetMedia();

            if (media >= 6 && aluno.Frequencia >= 75)
            {
                Console.WriteLine("O aluno {0} passou com média {1:f2}",aluno.Nome, media);
            }else if (media <= 6)
            {
                Console.WriteLine("O aluno {0} não passou com média {1:f2}", aluno.Nome, media);
            }else
            {
                Console.WriteLine("O aluno {0} não passou com média {1:f2}, pois está com frequência de {2:f2}%",
                    aluno.Nome, media, aluno.Frequencia);
            }

        }
    }
}
/*Escreva um algoritmo que lê o nome, a frequência e as notas de duas provas de um aluno e que mostra a seguinte 
 * mensagem, caso ele tenha passado:

O aluno Nome do Aluno passou com média Média do Aluno

Ou, caso ele não tenha atingido a média mínima necessária, que é seis, a mensagem deve ser:

O aluno Nome do Aluno não passou com média Média do Aluno

Leve em conta que, se o aluno não tiver um mínimo de 75% de frequência, ele não passa, mesmo que tenha média acima 
de seis. Nesse caso, a mensagem deve ser:

O aluno Nome do Aluno não passou com média Média do Aluno, pois está com frequência Frequência do Aluno*/
