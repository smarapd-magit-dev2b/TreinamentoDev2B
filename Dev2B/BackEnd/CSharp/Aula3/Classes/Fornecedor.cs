namespace Aula3.Classes
{
    public class Fornecedor : Pessoa
    {
        public string Segmento { get; set; }
        public string Produto { get; set; }

        public override string ToString() =>
            "\nFornecedor\n\n" +
            base.ToString() +
            $"Segmento = {Segmento}\n" +
            $"Produto = {Produto}";
    }
}
