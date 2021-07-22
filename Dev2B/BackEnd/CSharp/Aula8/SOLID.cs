using System;

namespace Aula8
{
    class SOLID
    {
        static void Main(string[] args)
        {
            if (args is null)
                throw new ArgumentNullException(nameof(args));

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
