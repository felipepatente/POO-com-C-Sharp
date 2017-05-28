using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarAlunos
{
    class OrdenarPorMedia : IComparer<Aluno>
    {
        public int Compare(Aluno x, Aluno y)
        {
            if (x.GetMedia() > y.GetMedia())
            {
                return 1;
            }
            else if (x.GetMedia() < y.GetMedia())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
