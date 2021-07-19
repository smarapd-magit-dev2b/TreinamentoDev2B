namespace Aula3.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public int QuantidadeFilhos { get; set; }
        public string EstadoCivil { get; set; }

        public override string ToString() =>
            base.ToString() +
            $"CPF: {Cpf}\n" +
            $"Quantidade de filhos: {Cpf}\n" +
            $"Estado Civil: {Cpf}";
    }
}
