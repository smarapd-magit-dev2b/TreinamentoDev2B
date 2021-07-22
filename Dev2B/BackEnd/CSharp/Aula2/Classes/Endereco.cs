namespace Aula2.Classes
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public override string ToString() =>
           "\nEndereço\n\n" +
            $"Rua: {Rua}\n" +
            $"Cidade: {Cidade}\n" +
            $"Estado{Estado}";
    }
}
