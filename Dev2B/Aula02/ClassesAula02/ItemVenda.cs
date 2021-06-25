using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class ItemVenda
    {
        private int NumeroItem { get; set; }
        private string Descricao { get; set; }
        private int QtdComprada { get; set; }
        private decimal PrecoUnit { get; set; }

        public ItemVenda(int numeroItem, string descricao, int qtdComprada, decimal precoUnit)//Construtor
        {
            NumeroItem = numeroItem;
            Descricao = descricao;
            QtdComprada = qtdComprada;
            PrecoUnit = precoUnit;


            if (QtdComprada < 0)
                QtdComprada = 0;

            if (PrecoUnit < 0)
                PrecoUnit = 0;
        }

        public void calculaValorTotal()
        {
            decimal valorTotal = (PrecoUnit * QtdComprada);
            Console.WriteLine($"\n          Formulário Final            ");
            Console.WriteLine($"Valor Total: {valorTotal}");

        }
        public void EscreverValores()
        {
            Console.WriteLine($"Número do item: {NumeroItem}");
            Console.WriteLine($"Descrição do item: {Descricao}");
            Console.WriteLine($"Quanttidade comprada deste item: {QtdComprada}");
            Console.WriteLine($"Valor unitário do item: {PrecoUnit}");
        }
    }
}
