namespace Aula3.Exercicio3.Classes
{
    public class Aviao : Veiculo
    {
        public Aviao(string cor, decimal valocidadeMaxima, string tipoCombustivel,
            string marca, int quantidadeMaxPassageiros, int quantidadeRodas, int quantidadePilotos, string porte)
            : base(cor, valocidadeMaxima, tipoCombustivel, marca, quantidadeMaxPassageiros, quantidadeRodas)
        {
            QuantidadePilotos = quantidadePilotos;
            Porte = porte;
        }

        public int QuantidadePilotos { get; set; }
        public string Porte { get; set; }

        public override string ImprimeInformacoes()
        {
            return $"{base.ImprimeDadosBase()}" +
                $"\nQuantidade de pilotos: {QuantidadePilotos}" +
                $"\nPorte: {Porte}";
        }
    }
}
