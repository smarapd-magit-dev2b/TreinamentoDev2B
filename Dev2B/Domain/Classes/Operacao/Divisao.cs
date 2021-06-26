using Domain.Interfaces;

namespace Domain.Classes.Operacao
{
    public class Divisao : Operacao, IOperacao
    {
        public Divisao(decimal valor1, decimal valor2):
            base(valor1, valor2)
        { }
        public decimal Calcular()
        {
            return Valor1 / Valor2;
        }
    }
}
