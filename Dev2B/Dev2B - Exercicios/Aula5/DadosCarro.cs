using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno
{
    public class DadosCarro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public DateTime Anofabricação { get; set; }
        public decimal Preco { get; set; }
        public int QntdPortas { get; set; }
        public decimal Kilometragem { get; set; }


        public override string ToString()
        {
            return $"ID: {Id}. Marca: {Marca}. Cor: {Cor}. Preço: {Preco}. Ano de Fabricação: {Anofabricação.ToString("yyyy")}." +
                   $"\nQuantidade de portas: {QntdPortas}. Kilometragem do veiculo: {Kilometragem}.";
        }
    }
}
