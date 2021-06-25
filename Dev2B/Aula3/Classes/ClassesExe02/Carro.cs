using System;

namespace Aula3.Classes.ClassesExe02 {
    public class Carro : Veiculo {
        public int QntPortas { get; set; }
        public bool PossuiStep { get; set; }
        public bool PossuiTracaoTraseira { get; set; }

        public Carro(string cor, int velmaxia, string tipocombustivel, string marca, int qntrodas, int qntmaximapassageiro, int qntportas, bool step, bool tracaotraseira)
            : base(cor, velmaxia, tipocombustivel, marca, qntrodas, qntmaximapassageiro) {
            QntPortas = qntportas;
            PossuiStep = step;
            PossuiTracaoTraseira = tracaotraseira;
        }
    }
}
