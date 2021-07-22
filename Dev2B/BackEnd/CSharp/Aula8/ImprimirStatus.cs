using System;

namespace Aula8
{
    //Princípio da Responsabilidade única (SRP)
    public static class ImprimirStatus
    {
        public static void Imprimir(IStatus unidade) =>
            Console.WriteLine($"O(a) {unidade.GetType().Name} está {(unidade.Status ? "Ligado" : "Desligado")}(a)");
    }
}
