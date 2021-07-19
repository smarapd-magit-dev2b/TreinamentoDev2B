using Common.Interfaces;

namespace Common.Classes.Operacao
{
    public class Subtracao : Operacao, IOperacao
    {
        public Subtracao(decimal valor1, decimal valor2):
            base(valor1, valor2)
        { }
        public decimal Calcular()
        {
            return Valor1 - Valor2;
        }
    }
}
