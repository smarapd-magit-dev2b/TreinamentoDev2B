using Domain;

namespace Aula2
{
    public class Empregado : PessoaFisica
    {
        public decimal Salario {
            get { return Salario; }
            set {
                if (value < 0)
                    Salario = 0;
                else
                    Salario = value;
            }
        }

        public Empregado(string nome, string sobrenome, decimal salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Salario = salario;
        }
        public decimal CalcularSalarioAtual()
        {
            return Salario * 12;
        }
        public void ReajustarSalario(decimal porcentagem)
        {
            Salario += Salario * porcentagem;
        }
    }
}
