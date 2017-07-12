using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            int um = 0, dois = 0, tres = 0;
            Sobre sobre = new Sobre();
            Sobre sobre1 = new Sobre(um);
            Sobre sobre2 = new Sobre(um, dois);
            Sobre sobre3 = new Sobre(um, dois, tres);
        }
    }
}
