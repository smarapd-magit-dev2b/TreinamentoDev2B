namespace Aula3.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public override string ToString() =>
            $"Nome: {Nome}\n" +
            $"Endereço: {Endereco}\n" +
            $"Telefone: {Telefone}\n" +
            $"Celular: {Celular}\n";
    }
}
