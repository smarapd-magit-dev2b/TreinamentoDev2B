using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_1
{
    public class ItemVenda
    {
        //Propriedades---------------------

        public int Numero { get; set; }
        public string Descrição { get; set; }
        public int Quantidade { get; set; }
        public decimal Preço { get; set; }
    
        //Construtor------------------------
        public ItemVenda(int numero, string descricao, int quantidade, decimal preço)
        {
            Numero = numero;
            Descrição = descricao;
            Quantidade = quantidade;
            Preço = preço;

            if (quantidade < 0)
                
                Quantidade = 0;

            else
                
                Quantidade = quantidade;

            Quantidade = quantidade;

            if (preço < 0)
                
                Preço = 0;

            else

                Quantidade = quantidade;
        }

        //Metodo----------------------------
        public decimal ValorFatura()
        {
            return Preço * Quantidade;
        }
    
    
    }
}
    