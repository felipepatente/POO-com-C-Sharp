using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu nível: ");
            int nivel = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            double qtdHoras = double.Parse(Console.ReadLine());

            Console.WriteLine("Vai querer ter promoção (S/N): ");
            string promocao = Console.ReadLine();

            PlanosCarrera plano = new PlanosCarrera(nome);
            plano.Nivel = nivel;
            plano.QtdHoras = qtdHoras;
            
            Console.WriteLine("O funcionário {0} trabalhou {1} horas por R$ {2} (Nível {3}) e deve receber R$ {4}",
                plano.Nome, plano.QtdHoras, plano.GetValorHora(), plano.Nivel, plano.GetSalario());

            if (promocao == "S")
            {
                plano.Nivel = nivel + 1;
                Console.WriteLine("O funcionário {0} teve promoção, trabalhou {1} horas por R$ {2} (Nível {3}) " + 
                    "e o seu novo salário é de R$ {4}.",
                    plano.Nome, plano.QtdHoras, plano.GetValorHora(), plano.Nivel, plano.GetSalario());
            }
        }
    }
}

/*Escreva um algoritmo que lê o nome de um funcionário, o seu nível dentro do plano de carreira da empresa, 
 * a quantidade de horas que ele trabalhou e se ele vai ter promoção. O algoritmo deve calcular o valor do salário 
 * a ser pago e mostrar a seguinte mensagem: “O funcionário Nome do Funcionário trabalhou Horas Trabalhadas horas 
 * por R$ Valor da Hora (Nível Nível do Funcionário) e deve receber R$ Valor do Salário“. Após essa mensagem, se o 
 * funcionário teve promoção, a seguinte mensagem deve ser exibida: “O funcionário Nome do Funcionário teve 
 * promoção, trabalhou Horas Trabalhadas horas por R$ Valor da Hora (Nível Nível do Funcionário) e o seu novo 
 * salário é de R$ Valor do Salário“.*/
