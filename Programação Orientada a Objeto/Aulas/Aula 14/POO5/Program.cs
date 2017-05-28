using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerente f1 = new Gerente("Maria", 1000, 160);
            //Programador f2 = new Programador("José", "JR", 176);
            //Programador f3 = new Programador("Augusto", "PL", 160);
            //Programador f4 = new Programador("Alice", "SR", 120);
            //Vendedor f5 = new Vendedor("Ana", 720);
            //FaxineiroDiurno f6 = new FaxineiroDiurno("Ana", 720);
            //FaxineiroNoturno f7 = new FaxineiroNoturno("João", 680);

            // torna-se... 
            List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Gerente("Maria", 1000, 160),
                new Programador("José", "JR", 176),
                new Programador("Augusto", "PL", 160),
                new Programador("Alice", "SR", 128),
                new Vendedor("Ana", 720),
                new FaxineiroDiurno("Ana", 720),
                new FaxineiroNoturno("João", 680)
            };

            // a variável, que neste caso é do tipo Funcionario, me diz 
            // que métodos posso usar, ou seja, apenas os da classe funcionario
            // a variável é uma interface entre você programador e o objeto
            decimal total = 0;
            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine("Funcionário {0} irá receber {1}", f.getNome(), f.getSalario());
                total += f.getSalario();
            }
            Console.WriteLine("Total da folha: {0}", total);

        }
    }
}
