using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_Crianca_Adulto_Idoso.Modelo
{
    public class Controle:absPropriedades
    {
        public Controle(String pessoa): base (pessoa)
        {

        }

        public override void Executar()
        {
            this.mensagem = "";

            absPropriedades validacao = new Validacao(this.pessoa);

            if (validacao.mensagem.Equals(""))
            {
                absPropriedades categoria = new Categoria(validacao.idade);

                this.resposta = categoria.ToString();
            }
            else
            {
                this.resposta = validacao.mensagem;
            }
        }
    }
}
