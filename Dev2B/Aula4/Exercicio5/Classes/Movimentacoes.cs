using Aula4.Exercicio5.Enum;

namespace Aula4.Exercicio5.Classes
{
    public class Movimentacoes
    {
        public Movimentacoes(decimal valor, EnumDescricao descricao, EnumTipoMovimentacao tipoMovimentacao)
        {
            this.tipoMovimentacao = tipoMovimentacao;
            Descricao = descricao;
            Valor = valor;
        }

        public EnumTipoMovimentacao tipoMovimentacao { get; set; }
        public EnumDescricao Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}