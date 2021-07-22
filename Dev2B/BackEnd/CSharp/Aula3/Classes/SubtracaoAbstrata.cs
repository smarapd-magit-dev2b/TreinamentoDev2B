namespace Aula3.Classes
{
    public class SubtracaoAbstrata : Operacao
    {
        public SubtracaoAbstrata(decimal valor1, decimal valor2): base(valor1, valor2) { }

        public decimal Calcular() => Valor1 - Valor2;
    }
}
