using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redes
{
    public class Facebook : RedesSociais
    {
        private string nome;
        private string mensagem;

        public Facebook(string nome, string mensagem)
        {
            this.nome = nome;
            this.mensagem = mensagem;
        }

        public string ImprimirMensagem()
        {
            return string.Format("Mensagem {0} enviada no Facebook do(a) {1}", mensagem, nome);
        }
    }
}
