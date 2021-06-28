using System;

namespace Aula2.Classes.ClassesDes01 {
    class Carro {
        private string Cor { get; set; }
        private int Chassi { get; set; }
        private string Proprietário { get; set; }
        private int VelocidadeMAX { get; set; }
        private int VelocidadeAtual { get; set; }
        private int NumPortas { get; set; }
        private bool TetoSolar { get; set; }
        private int NumMarcha { get; set; }
        private bool TemCabio { get; set; }
        private int VolCombustivel { get; set; }
        public Proprietario Proprietario { get; set; }

        public Carro() {
            Proprietario = new Proprietario();
        }

        public void Acelerar() {
            VelocidadeAtual += 1;
        }
        public void Freio() {
            VelocidadeAtual = 0;
        }
        public void SubirMarcha() {
            if (NumMarcha > 5)
                Console.WriteLine("Impossivel trocar de Marcha");
            else
                NumMarcha += 1;
        }
        public void DescerMarcha() {
            if (NumMarcha < 0 || NumMarcha > 5)
                Console.WriteLine("Impossivel trocar de Marcha");
            else
                NumMarcha -= 1;
        }
        public void MarcharRe() {
            if (VelocidadeAtual == 0)
                NumMarcha = -1;
            else
                Console.WriteLine("Impossivel colocar marcha ré com o carro em movimento...");
        }
        public void Autonomia(int velocidadeatual) {
            if (velocidadeatual > 0 && velocidadeatual < 20) {
                Console.WriteLine("Veículo faz 8Km/h com 1L de combustivel");
                VolCombustivel -= 1;
            }
            else if (velocidadeatual >= 20 && velocidadeatual < 40) {
                Console.WriteLine("Veículo faz 10Km/h com 1L de combustivel");
                VolCombustivel -= 1;
            }
            else if (velocidadeatual >= 40 && velocidadeatual < 60) {
                Console.WriteLine("Veículo faz 12Km/h com 1L de combustivel");
                VolCombustivel -= 1;
            }
            else if (velocidadeatual >= 60) {
                Console.WriteLine("Veículo faz 15Km/h com 1L de combustivel");
                VolCombustivel -= 1;
            }
            else
                Console.WriteLine("Velocidade invalida...");
        }
        public void EncherCombustivel(int encher) {
            VolCombustivel = 100;
        }
        public int VolumeCombustivel(int volumecombustivel) {
            return volumecombustivel;
        }
    }
}
