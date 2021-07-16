using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_8.SOLID
{
    //Princípio da Responsabilidade única (SRP)
    public static class ImprimirStatus
    {
        public static void Imprimir(IStatus unidade) =>
            Console.WriteLine($"O(a) {unidade.GetType().Name} está {(unidade.Status ? "Ligado" : "Desligado")}(a)");
    }
}
