namespace Domain
{
    public class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal Salario { get; set; }

        public Empregado(string nome, string sobrenome, decimal salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            if (salario < 0)
                Salario = 0;
            Salario = salario;
        }
        public decimal CalcularSalarioAtual()
        {
            return Salario * 12;
        }
        public void reajustarSalario(decimal porcentagem)
        {
            Salario += Salario * porcentagem;
        }
    }
}
