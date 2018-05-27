using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_Crianca_Adulto_Idoso.Modelo
{
    public class Validacao: absPropriedades
    {
        public Validacao(String pessoa): base (pessoa)
        {
            
        }
        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.idade = Convert.ToDouble(this.pessoa);
            }
            catch (FormatException e)
            {

                this.mensagem = " Erro de conversão";
            }
        }

    }
}
