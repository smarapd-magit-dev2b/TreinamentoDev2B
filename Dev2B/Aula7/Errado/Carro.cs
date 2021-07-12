namespace Aula7.Errado
{
    public class Carro
    {
        public string Marca { get; set; }
        public int AnoLancamento { get; set; }
        public string Cor { get; set; }
        public decimal ValorCarro { get; set; }

        public Carro(string marca, int anoLancamento, string cor, decimal valorCarro)
        {
            Marca = marca;
            AnoLancamento = anoLancamento;
            Cor = cor;
            ValorCarro = valorCarro;
        }

        public decimal ValorIpva(Carro carro)
        {
            if (carro is Fusca)
            {
                return carro.ValorCarro * .1m;
            }
            else if (carro is Gol)
            {
                return carro.ValorCarro * 5m;
            }
            else if (carro is Palio)
            {
                return carro.ValorCarro * 3m;
            }

            return 5;
        }

    }
}
