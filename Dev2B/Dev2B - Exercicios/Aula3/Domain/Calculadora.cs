using System;

namespace Domain
{
    public abstract class Calculadora
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
        public decimal ValorTotal { get; set; }

        public abstract void Calcular();
        
    }
}
