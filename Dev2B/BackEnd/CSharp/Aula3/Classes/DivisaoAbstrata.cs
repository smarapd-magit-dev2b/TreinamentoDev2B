namespace Aula3.Classes
{
    public class DivisaoAbstrata : Operacao
    {
        public DivisaoAbstrata(decimal valor1, decimal valor2): base(valor1, valor2) { }

        public decimal Calcular() => Valor1 / Valor2;
    }
}
