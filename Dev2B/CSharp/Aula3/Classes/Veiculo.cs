namespace Aula3.Classes
{
    public class Veiculo
    {
        public string Cor { get; set; }
        public decimal VelocidadeMaxima { get; set; }
        public string TipoCombustivel { get; set; }
        public string Marca { get; set; }
        public int QuantidadeRodas { get; set; }
        public int QuantidadeMaximaPassageiros { get; set; }

        public override string ToString() =>
            $"Cor: {Cor}\n" +
            $"Velocidade Máxima: {VelocidadeMaxima}Km/s" +
            $"Tipo de Combustível: {TipoCombustivel}\n" +
            $"Marca: {Marca}\n" +
            $"Quantidade de Rodas: {QuantidadeRodas}\n" +
            $"Quantidade máxima de Passageiros: {QuantidadeMaximaPassageiros}";
    }
}
