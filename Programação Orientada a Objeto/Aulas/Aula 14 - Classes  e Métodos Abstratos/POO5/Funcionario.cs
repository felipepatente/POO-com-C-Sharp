using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    class Funcionario
    {
        private string nome;

        public Funcionario(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        // ativando o polimorfismo -> virtual
        public virtual decimal getSalario()
        {
            return 0;
        }
    }
}
