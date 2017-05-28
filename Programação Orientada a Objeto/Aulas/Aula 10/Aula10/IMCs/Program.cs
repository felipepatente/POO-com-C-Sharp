using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua altura (em m): ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu peso em (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            IMC imc = new IMC(new Pessoa(nome),altura,peso);

            string[] categoria = {"abaixo do peso","peso normal","acima do peso","obesidade"};

            Console.WriteLine("{0} está com Índice de Massa Corporal {1} ({2})",
                imc.GetNomePessoa(), imc.GetMassaCorporal(), categoria[imc.GetCategoria()]);
        }
    }
}
/*Escreva um algoritmo que lê o nome, o peso (em kg) e a altura (em m) de uma pessoa e que mostra a 
 * seguinte mensagem: “Nome da Pessoa está com Índice de Massa Corporal IMC da Pessoa (Categoria do IMC)”.
O cálculo do IMC se dá pela seguinte fórmula: IMC = PESO / (ALTURA * ALTURA).
 */
