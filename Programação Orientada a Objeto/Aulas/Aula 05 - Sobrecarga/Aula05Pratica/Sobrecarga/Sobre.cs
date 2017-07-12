using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Sobre
    {
        public Sobre()
        {
            Console.WriteLine("Nenhum Construtor");
        }

        public Sobre(int um)
        {
            Console.WriteLine("1 Construtor");
        }

        public Sobre(int um, int dois)
        {
            Console.WriteLine("2 Construtor");
        }

        public Sobre(int um, int dois, int tres)
        {
            Console.WriteLine("3 Construtor");
        }
    }
}
