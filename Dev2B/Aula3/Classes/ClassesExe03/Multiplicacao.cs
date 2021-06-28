﻿using Aula3.Interfaces;
using System;

namespace Aula3.Classes.ClassesExe03 {
    public class Multiplicacao : Valor, ICalcular {

        public Multiplicacao(decimal n1, decimal n2) {
            Valor1 = n1;
            Valor2 = n2;
        }

        public void Calcular() {
            Console.WriteLine($"{Valor1} * {Valor2} = {Valor1 * Valor2}");

        }
    }
}

