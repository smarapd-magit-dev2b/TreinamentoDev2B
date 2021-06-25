using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio5__Extra_
{
    class Carro
    {
        public Carro(Proprietario proprietario, Marca marca)
        {
            Proprietario = proprietario;
            Marca = marca;
        }

        private string Modelo { get; set; }
        private string Cor { get; set; }
        private DateTime Ano { get; set; }
        private Marca Marca { get; set; }
        private string Chassi { get; set; }
        private Proprietario Proprietario { get; set; }
        private int VelMaxima { get; set; }
        private int VelAtual { get; set; }
        private int NrPortas { get; set; }
        private bool TetoSolar { get; set; }
        private int NrMarchas { get; set; }
        private bool CambioAutomatico { get; set; }
        private int VolumeCombustivel { get; set; }

        public void Acelera()
        {
            if(VelMaxima > VelAtual)
                VelMaxima = VelMaxima + 1;
        }
        public void Freia()
        {
            VelAtual = 0;
        }
        public int TrocaMarcha(int marcha)
        {
            if(marcha < NrMarchas)
                marcha = marcha + 1;

            return marcha;
        }
        public int ReduzMarcha(int marcha)
        {
            if (marcha > 0)
                marcha = marcha - 1;
            return marcha;
        }
        public int EngatarRe(int marcha)
        {
            if (marcha == 0)
                marcha = -1;
            return marcha;
        }
        public int Autonomia(int consumo)
        {
            return consumo * VolumeCombustivel;
        }
        public int GetVolume()
        {
            return VolumeCombustivel;
        }
    }
}
