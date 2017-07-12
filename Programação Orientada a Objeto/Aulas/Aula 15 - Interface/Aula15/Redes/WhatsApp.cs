using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redes
{
    public class WhatsApp : RedesSociais
    {
        private string nome;
        private string mensagem;

        public WhatsApp(string nome, string mensagem)
        {
            this.nome = nome;
            this.mensagem = mensagem;
        }

        public string ImprimirMensagem()
        {
            return string.Format("Mensagem {0} enviada no WhatsApp do(a) {1}", mensagem, nome);
        }
    }
}
