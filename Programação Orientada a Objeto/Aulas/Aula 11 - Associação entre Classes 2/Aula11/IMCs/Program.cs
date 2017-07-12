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

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura: ");
            double altura = double.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, peso, altura);
            Imc imc = pessoa.GetImc();

            Console.WriteLine("A pessoa {0} com peso {1} e altura {2} tem IMC {3} ({4}).",
                pessoa.GetNome(), pessoa.GetPeso(), pessoa.GetAltura(), imc.GetValor(), imc.GetCategoria());

        }
    }
}
