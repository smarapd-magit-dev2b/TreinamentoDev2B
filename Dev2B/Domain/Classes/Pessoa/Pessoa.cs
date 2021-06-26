namespace Domain.Classes.Pessoa
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Nacionalidade { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public Pessoa()
        {
            Endereco = new Endereco();
        }
    }
}
