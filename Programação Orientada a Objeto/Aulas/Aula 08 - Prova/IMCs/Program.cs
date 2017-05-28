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

            Console.Write("Digite seu peso (em Kg): ");
            double kg = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (em m): ");
            double altura = double.Parse(Console.ReadLine());

            IMC imc = new IMC(nome);
            imc.SetKg(kg);
            imc.SetAltura(altura);
            string[] categoria = { "Abaixo do Peso", "Peso normal", "Acima do Peso", "Obesidade" };

            Console.WriteLine("{0} está com Índice de Massa Corporal {1:f2} ({2})", 
                imc.GetNome(), imc.GetMassaCorporal(), categoria[imc.GetCategoria()]);
        }
    }
}
/*Escreva um algoritmo que lê o nome, o peso (em kg) e a altura (em m) de uma pessoa e que mostra a seguinte 
 * mensagem: “Nome da Pessoa está com Índice de Massa Corporal IMC da Pessoa (Categoria do IMC)”.*/
