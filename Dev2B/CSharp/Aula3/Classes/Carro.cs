namespace Aula3.Classes
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }
        public bool PossuiStep { get; set; }
        public bool PossuiTracaoTraseira { get; set; }

        public override string ToString() =>
            "\nCarro\n\n" +
            base.ToString() +
            $"Quantidade de Portas: {QuantidadePortas}\n" +
            $"Possui Step: {(PossuiStep ? "Possui" : "Não")}\n" +
            $"Possui Tração Traseira: {(PossuiTracaoTraseira ? "Possui" : "Não")}";
    }
}
