namespace Aula2.Classes
{
    public class Empregado
    {
        private decimal _salario;
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal Salario
        {
            get { return _salario; }
            set
            {
                if (value < 0)
                    _salario = 0;
                else
                    _salario = value;
            }
        }

        public Empregado(string nome, string sobrenome, decimal salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            _salario = salario;
        }

        public decimal CalcularSalarioAtual() => _salario * 12;

        public void ReajustarSalario(decimal porcentagem) => _salario += _salario * porcentagem;
    }
}
