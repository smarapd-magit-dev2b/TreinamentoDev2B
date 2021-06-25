using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Classes
{
    public class ItemVenda
    {
        private int NumeroItem { get; set; }
        private string Descricao { get; set; }
        private int QtdComprada { get; set; }
        private decimal PrecoUnit { get; set; }

        public ItemVenda(int numeroitem, string descricao, int quantidade, decimal preco)
        {
            if (QtdComprada < 0)
                QtdComprada = 0;
            else
                QtdComprada = quantidade;
            if (PrecoUnit < 0)
                PrecoUnit = 0;
            else
                PrecoUnit = preco;
            NumeroItem = numeroitem;
            Descricao = descricao;
            QtdComprada = quantidade;
            PrecoUnit = preco;
        }
        public decimal calcularValorTotal()
        {
            return PrecoUnit * QtdComprada;
        }

        public void EscreverInformacoes()
        {
            Console.WriteLine($"Número do item: {NumeroItem}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Quantidade: {QtdComprada} ");
            Console.WriteLine($"Preço Unitário: {PrecoUnit} ");
            Console.WriteLine($"Valor total: {calcularValorTotal()} ");
        }
    }
}
