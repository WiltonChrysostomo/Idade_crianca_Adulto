using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_Crianca_Adulto_Idoso.Modelo
{
    public class Categoria:absPropriedades
    {
        public Categoria(Double idade): base (idade)
        { 

        }

        public override void Executar()
        {
            if(this.idade >= 60)
            {
                this.resposta = " Você é idoso";
            }                                                                          
                                         
            
            else 
            {
                if (this.idade <= 17)
                {
                    this.resposta =" Você é uma criança ou adolecente";
                }
                else
                {
                    this. resposta = "Você é adulto";
                }
            }
        }
        
    }
}
