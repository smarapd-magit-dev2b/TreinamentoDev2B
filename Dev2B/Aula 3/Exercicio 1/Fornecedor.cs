using System;
using System.Collections.Generic;
using System.Text;

namespace Herança1
{
   public class Fornecedor : Mãe
    {
        //Construtor-------------------------
        public Fornecedor(string nome, string telefone, string endereço) : base(nome, telefone, endereço)
        {
       
        }
        
        public string Cnpj { get; set; }
        
        public string Produto { get; set; }

        public string Segmento { get; set; }



    
    
    
    
    
    
    }
}
