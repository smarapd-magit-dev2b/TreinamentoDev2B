namespace Domain.Classes.Veiculo
{
    class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }
        public bool PossuiStep { get; set; }
        public bool PossuiTracaoTraseira { get; set; }
    }
}
