using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nivel do funcionario: ");
            int nivel = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas trabalhadas: ");
            double qtdHora = double.Parse(Console.ReadLine());

            Console.Write("Vai desejar promoção (S/N): ");
            string promocao = Console.ReadLine();

            Funcionario f = new Funcionario(nome,nivel,qtdHora);

            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} "
               + "(Nível {3}) e deve receber R$ {4}",
               f.nome, f.qtdHora, f.GetValorHora(), f.nivel, f.GetSalario());

            if (promocao == "S")
            {
                f.aumentarNivel();
                Console.WriteLine("O funcionário {0} teve promoção, trabalhou {1} horas "
               + " por R$ {2}(Nível {3}) e o seu novo salário é de R$ {4}",
               f.nome, f.qtdHora, f.GetValorHora(), f.nivel, f.GetSalario());
            }
        }
    }
}
/*
Escreva um algoritmo que lê o nome de um funcionário, o seu nível dentro do plano de carreira da empresa, a 
quantidade de horas que ele trabalhou e se ele vai ter promoção. O algoritmo deve calcular o valor do salário a ser 
pago e mostrar a seguinte mensagem: “O funcionário Nome do Funcionário trabalhou Horas Trabalhadas horas por 
R$ Valor da Hora (Nível Nível do Funcionário) e deve receber R$ Valor do Salário“. Após essa mensagem, se o 
funcionário teve promoção, a seguinte mensagem deve ser exibida: “O funcionário Nome do Funcionário teve promoção, 
trabalhou Horas Trabalhadas horas por R$ Valor da Hora (Nível Nível do Funcionário) e o seu novo salário é de 
R$ Valor do Salário“. 
*/
