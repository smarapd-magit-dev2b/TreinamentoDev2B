using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Classes
{
    public class ItemVenda
    {
        private int Id { get; set; }
        private string Descricao { get; set; }
        private decimal valorUnitario { get; set; }
        private int qntdVendida { get; set; }

        public ItemVenda(int id, string descricao, decimal vlrUnitario, int vendidos)
        {
            Id = id;
            Descricao = descricao;
            valorUnitario = vlrUnitario;
            qntdVendida = vendidos;
        }

        private void ValidateVenda()
        {
            if (qntdVendida < 0)
            {
                qntdVendida = 0;

            }


        }
        private void ValidateValor()
        {
            if (valorUnitario < 0)
            {
                valorUnitario = 0.0m;
            }
        }

        public void getId()
        {
            Console.WriteLine("ID do produto: " + Id);
        }
        public void getDescricao()
        {
            Console.WriteLine($"Nome do produto: {Descricao}");
        }
        public void getVlr()
        {
            Console.WriteLine($"O {Descricao} esta custando {valorUnitario} a unidade.");
        }

        public void getQntd()
        {
            decimal vlrTotal;
            vlrTotal = qntdVendida * valorUnitario;
            Console.WriteLine($"A quantidade vendida foi de {qntdVendida} no valor de {valorUnitario}, totalizando {vlrTotal} ");
        }

        public void dados()
        {
            getId();
            getDescricao();
            getVlr();
            getQntd();
        }
        public void validacoes()
        {
            ValidateVenda();
            ValidateValor();
        }
    }
}
