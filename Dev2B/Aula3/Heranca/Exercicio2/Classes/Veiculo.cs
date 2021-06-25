namespace Aula3.Exercicio3.Classes
{
    public abstract class Veiculo
    {
        public string Cor { get; set; }
        public decimal ValocidadeMaxima { get; set; }
        public string TipoCombustivel { get; set; }
        public string Marca { get; set; }
        public int QuantidadeMaxPassageiros { get; set; }
        public int QuantidadeRodas { get; set; }

        protected Veiculo(string cor, decimal valocidadeMaxima, string tipoCombustivel, string marca, int quantidadeMaxPassageiros, int quantidadeRodas)
        {
            Cor = cor;
            ValocidadeMaxima = valocidadeMaxima;
            TipoCombustivel = tipoCombustivel;
            Marca = marca;
            QuantidadeMaxPassageiros = quantidadeMaxPassageiros;
            QuantidadeRodas = quantidadeRodas;
        }

        protected string ImprimeDadosBase()
        {
            return $"Cor: {Cor}" +
                $"\nValocidade Maxima: {ValocidadeMaxima}" +
                $"\nTipo de Combustivel: {TipoCombustivel}" +
                $"\nMarca: {Marca}" +
                $"\nQuantidade Maxima de Passageiros: {QuantidadeMaxPassageiros}" +
                $"\nQuantidade de Rodas: {QuantidadeRodas}";
        }

        public abstract string ImprimeInformacoes();

    }
}
