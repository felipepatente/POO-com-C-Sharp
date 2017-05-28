using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            Imc i = new Imc(nome,peso,altura);
            string[] categoria = {"Abaixo do Peso","Peso Normal","Acima do Peso","Obesidade"};
            

            Console.WriteLine("{0} está com Índice de Massa Corporal {1} ({2})",
                i.nome, i.GetIndice(), categoria[i.GetCategoria()]);
        }
    }
}
/*
Escreva um algoritmo que lê o nome, o peso (em kg) e a altura (em m) de uma pessoa e que mostra a 
seguinte mensagem: “Nome da Pessoa está com Índice de Massa Corporal IMC da Pessoa (Categoria do IMC)”.
 */
