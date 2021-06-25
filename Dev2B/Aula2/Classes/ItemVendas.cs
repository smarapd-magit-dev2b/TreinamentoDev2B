using System;

namespace Aula02.Exercicio01 {
    class ItemVendas {
            public int Codigo { get; set; }
            public string Descricao { get; set; }
            public int QntComprada { get; set; }
            public decimal Preco { get; set; }

            public ItemVendas(int numitem, string descricao, int quantidade, decimal preco) {
                Codigo = numitem;
                Descricao = descricao;
                QntComprada = quantidade;
                Preco = preco;
            }

            public void CalcularValorTotal() {
                Console.WriteLine($"Código do item: {Codigo}\n" +
                                  $"Descrição do item: {Descricao}\n" +
                                  $"Valor Total: {QntComprada * Preco}");
            }
        }
    }

