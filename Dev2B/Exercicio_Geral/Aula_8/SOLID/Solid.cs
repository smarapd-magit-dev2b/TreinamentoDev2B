using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_8.SOLID
{
    public class Solid
    {
       public void Executar_Aula8()
        {
            var lampada = new Lampada();
            ControleUniversal.Ligar(lampada);
            ImprimirStatus.Imprimir(lampada);
            ControleUniversal.Desligar(lampada);
            ImprimirStatus.Imprimir(lampada);

            var televisao = new Televisao();
            ControleUniversal.Ligar(televisao);
            ImprimirStatus.Imprimir(televisao);
            ControleUniversal.Desligar(televisao);
            ImprimirStatus.Imprimir(televisao);

            var carro = new Carro();
            ControleUniversal.Ligar(carro);
            ImprimirStatus.Imprimir(carro);
            ControleUniversal.Desligar(carro);
            ImprimirStatus.Imprimir(carro);


        }
    
    
    
    
    }
}
