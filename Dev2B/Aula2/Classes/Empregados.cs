using System;


namespace Aula02.Exercicio02 {
    class Empregados {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal Salario { get; set; }

        public Empregados(string nome, string sobrenome, decimal salario) {
            Nome = nome;
            Sobrenome = sobrenome;
            Salario = salario;
        }
        public void CalcularSalarioAtual() {
            Console.WriteLine("O salário anual é R$" + (Salario * 12).ToString("F2"));
        }
        public void CalcularReajuste(decimal reajuste) {
            Console.WriteLine("O salario mensal com o reajuste é R$" + (Salario += ((reajuste / 100) * Salario)).ToString("F2"));
        }
    }
}
