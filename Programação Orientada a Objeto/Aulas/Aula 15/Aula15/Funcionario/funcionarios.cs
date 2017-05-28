using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    interface funcionarios
    {
        string GetNome();


        decimal GetValorHora();

        double GetQtdHoras();

        void SetValorHora(decimal valorHora);


        void SetQtdhoras(double qtdHoras);
        
    }
}
