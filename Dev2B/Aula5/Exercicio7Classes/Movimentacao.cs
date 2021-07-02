using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio7Classes
{
    public class Movimentacao
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Movimentacao(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
