using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    public class InstanciaAnimal
    {
        //public int RealizarCalculo(Soma soma)
        //{
        //    return soma.Calcular();
        //}
        //public int RealizarCalculo(Subtracao subtracao)
        //{
        //    return subtracao.Calcular();
        //}


        //todo sedã é carro
        public decimal RealizarCalculo(Calculo calculo)
        {
            return calculo.Calcular();
        }
    }
}
