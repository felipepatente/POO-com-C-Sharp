using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string continua;

            Faxineiro faxineiro = new Faxineiro("",0.0m);
            Vendedor vendedor = new Vendedor(0, "");
            Gerente gerente = new Gerente(0.0d,0.0m,"");
            Programador programador = new Programador("", "", 0.0d);

            do
            {
                Console.Write("\nDigite o nome do funcionario: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a função");
                Console.WriteLine("1 - Faxineiro");
                Console.WriteLine("2 - Vendedor");
                Console.WriteLine("3 - Gerente");
                Console.Write("4 - Programador\n->");
                string funcao = Console.ReadLine();

                switch (funcao)
                {
                    case "1":
                        Console.Write("Digite o valor fixo: ");
                        decimal valorFixo = decimal.Parse(Console.ReadLine());
                        faxineiro.GetFaxineiro().Add(new Faxineiro (nome, valorFixo));
                        break;
                    case "2":
                        Console.Write("Digite o valor das suas vendas: ");
                        decimal valorVendas = decimal.Parse(Console.ReadLine());
                        vendedor.GetVendedor().Add(new Vendedor(valorVendas, nome));
                        break;
                    case "3":
                        Console.Write("Digite a quantidade de horas trabalhadas: ");
                        double qtdHoras = double.Parse(Console.ReadLine());

                        Console.Write("Digite o bônus fixo: ");
                        decimal bonusFixo = decimal.Parse(Console.ReadLine());

                        gerente.GetGerente().Add(new Gerente(qtdHoras,bonusFixo,nome));

                        break;
                    case "4":

                        Console.Write("Digite a quantidade de horas trabalhadas: ");
                        qtdHoras = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o nivel");
                        Console.WriteLine("1 - Júnior");
                        Console.WriteLine("2 - Pleno");
                        Console.Write("3 - Sênior\n->");
                        string nivel = Console.ReadLine();
                        programador.GetProgramdor().Add(new Programador(nivel,nome,qtdHoras));

                        break;
                }

                Console.Write("Deseja continuar cadastrando funcionarios (S/N): ");
                continua = Console.ReadLine();

            } while (continua.ToUpper() == "S");


            Console.WriteLine("\n\nNome do funcionario              Valor a Receber");
            faxineiro.Mostrar();
            vendedor.Mostrar();
            gerente.Mostrar();
            programador.Mostrar();

            decimal valorTotalFuncionairos = faxineiro.GetValorTotalFaxineiro() + vendedor.GetValorTotalVendedor() +
                gerente.GetValorTotalGerente() + programador.GetValorTotalProgramdor();

            Console.WriteLine("Valor total a ser pagos para os funcionarios: {0}", valorTotalFuncionairos);
        }
    }
}
