using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_Crianca_Adulto_Idoso.Modelo
{
    public abstract class absPropriedades
    {
        public String pessoa;        
        public Double idade;
        public String resposta;
        public String mensagem;

        public absPropriedades( String pessoa)
        {
            this.pessoa = pessoa;
            Executar();

        }
        public absPropriedades(Double idade)
        {
            this.idade = idade;
            Executar();
        }

        public  virtual void Executar()
        {

        }

        public override string ToString()
        {
            return this.resposta;
        }
    }
}
