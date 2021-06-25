namespace Aula3.Exercicio3.Classes
{
    public class Moto : Veiculo
    {
        public Moto(string cor, decimal valocidadeMaxima, string tipoCombustivel,
            string marca, int quantidadeMaxPassageiros, int quantidadeRodas, bool possuiCarenagem)
            : base(cor, valocidadeMaxima, tipoCombustivel, marca, quantidadeMaxPassageiros, quantidadeRodas)
        {
            PossuiCarenagem = possuiCarenagem;

        }

        public bool PossuiCarenagem { get; set; }

        public override string ImprimeInformacoes()
        {
            return $"{base.ImprimeDadosBase()}" +
                $"\nPossui Carenagem: {PossuiCarenagem}";
        }
    }
}
