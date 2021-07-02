using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio7Classes
{
    public class Movimentacao
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string TipoMovimentacao { get; set; }

        public Movimentacao(string descricao, decimal valor, string tipoMovimentacao)
        {
            Descricao = descricao;
            Valor = valor;
            TipoMovimentacao = tipoMovimentacao;
        }
    }
}
