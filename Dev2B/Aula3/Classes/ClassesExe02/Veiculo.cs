using System;

namespace Aula3.Classes.ClassesExe02 {
    public abstract class Veiculo {
        public string Cor { get; set; }
        public int VelMaxima { get; set; }
        public string TipoCombustivel { get; set; }
        public string Marca { get; set; }
        public int QntRodas { get; set; }
        public int QntMaximaPassageiro { get; set; }

        public Veiculo(string cor, int velmaxia, string tipocombustivel, string marca, int qntrodas, int qntmaximapassageiro) {
            Cor = cor;
            VelMaxima = velmaxia;
            TipoCombustivel = tipocombustivel;
            Marca = marca;
            QntRodas = qntrodas;
            QntMaximaPassageiro = qntmaximapassageiro;

        }

        public void FichaMecanica() {
            Console.WriteLine("Cor do Veiculo: "+ Cor);
            Console.WriteLine("Vel.Máxima do Veiculo: " + VelMaxima);
            Console.WriteLine("Tipo de Combustível: " + TipoCombustivel);
            Console.WriteLine("Marca do Veiculo: " + Marca);
            Console.WriteLine("Qnt. de Rodas: " + QntRodas);
            Console.WriteLine("Qnt. Máxima de Passageiros: " + QntMaximaPassageiro);
        }
    }
}
