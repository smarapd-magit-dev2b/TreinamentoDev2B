namespace Aula3.Exercicio3.Classes
{
    public class Carro : Veiculo
    {
        public Carro(string cor, decimal valocidadeMaxima, string tipoCombustivel,
            string marca, int quantidadeMaxPassageiros, int quantidadeRodas, bool tracaoTraseira, bool step, int quantidadePortas)
            : base(cor, valocidadeMaxima, tipoCombustivel, marca, quantidadeMaxPassageiros, quantidadeRodas)
        {
            TracaoTraseira = tracaoTraseira;
            Step = step;
            QuantidadePortas = quantidadePortas;
        }

        public bool TracaoTraseira { get; set; }
        public bool Step { get; set; }
        public int QuantidadePortas { get; set; }

        public override string ImprimeInformacoes()
        {
            return $"{base.ImprimeDadosBase()}" +
                $"\nQuantidade de Portas: {QuantidadePortas}" +
                $"\nPossui Step: {Step}" +
                $"\nPossui Tracao Traseira: {TracaoTraseira}";
        }

    }
}
