namespace Aula3.Exercicio2.Domain.Interfaces
{
    public class Multiplicar : ICalcular
    {
        public decimal Calcular(decimal valor1, decimal valor2)
        {
            return valor1 * valor2;
        }
    }
}
