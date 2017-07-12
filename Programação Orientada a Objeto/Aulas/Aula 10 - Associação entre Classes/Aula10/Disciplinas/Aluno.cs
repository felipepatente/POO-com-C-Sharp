using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disciplinas
{
    public class Aluno
    {
        private string nome;
        private List<Disciplina> disciplina;

        public Aluno(string nome, Disciplina disciplina)
        {
            this.nome = nome;
            this.disciplina = new List<Disciplina>();
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
        }

        public List<Disciplina> GetDisciplina()
        {
            return this.disciplina;
        }
    }
}
