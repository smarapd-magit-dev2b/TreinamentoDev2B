using System;

namespace Aula8
{
    //Princípio da Responsabilidade única (SRP)
    public static class ImprimirStatus
    {
        public static void Imprimir(Dispositivo dispositivo) =>
            Console.WriteLine($"O(a) {dispositivo.GetType().Name} está {(dispositivo.Status ? "Ligado" : "Desligado")}(a)");
    }
}
