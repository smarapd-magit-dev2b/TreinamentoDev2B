namespace Aula3.Classes
{
    public class Aviao : Veiculo
    {
        public int QuantidadePilotos { get; set; }
        public int QuantidadeAcentos { get; set; }
        public string Porte { get; set; }

        public override string ToString() =>
            "\nAvião\n\n" +
            base.ToString() +
            $"Quantidade de Pilotos: {QuantidadePilotos}\n" +
            $"Quantidade de Acentos: {QuantidadeAcentos}\n" +
            $"Porte: {Porte}";
    }
}
