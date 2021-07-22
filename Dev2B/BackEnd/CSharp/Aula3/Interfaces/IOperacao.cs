namespace Aula3.Interfaces
{
    public interface IOperacao
    {
        decimal Valor1 { get; set; }
        decimal Valor2 { get; set; }

        decimal Calcular();
    }
}
