using Aula03.Exercicio01;


namespace Aula03.Exercicio03 {
    public abstract class Atributos {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public abstract decimal Calcular(decimal a, decimal b);
    }
}
