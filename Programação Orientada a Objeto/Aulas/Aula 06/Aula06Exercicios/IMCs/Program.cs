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
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());

            IMC imc = new IMC(nome);
            imc.SetPeso(peso);
            imc.SetAltura(altura);
            double massaCorporal =  imc.GetMassaCorporal();
            string[] categoria = { "Abaixo do Peso", "Peso Normal", "Acima do Peso", "Obesidade"};
            int index = imc.GetCategoria();

            Console.WriteLine("{0} está com Índice de Massa Corporal {1} ({2})",
                imc.GetNome(), massaCorporal, categoria[index]);
        }
    }
}
/*Escreva um algoritmo que lê o nome, o peso (em kg) e a altura (em m) de uma pessoa e que mostra a seguinte 
 * mensagem: “Nome da Pessoa está com Índice de Massa Corporal IMC da Pessoa (Categoria do IMC)”.*/
