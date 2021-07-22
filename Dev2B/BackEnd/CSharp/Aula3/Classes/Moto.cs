namespace Aula3.Classes
{
    public class Moto : Veiculo
    {
        public bool PossuiCarenagem { get; set; }

        public override string ToString() =>
            "\nMoto\n\n" +
            base.ToString() +
            $"Possui Carenagem: {(PossuiCarenagem ? "Possui" : "Não")}";
    }
}
