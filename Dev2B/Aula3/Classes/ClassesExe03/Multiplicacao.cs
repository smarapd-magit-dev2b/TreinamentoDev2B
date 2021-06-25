using Aula3.Interfaces;
using System;

namespace Aula3.Classes.ClassesExe03 {
    public class Multiplicacao : InterfacesExe03 {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public Multiplicacao(decimal n1, decimal n2) {
            Valor1 = n1;
            Valor2 = n2;
        }

        public void Calcular() {
            Console.WriteLine($"{Valor1} * {Valor2} = {Valor1 * Valor2}");

        }
    }
}

