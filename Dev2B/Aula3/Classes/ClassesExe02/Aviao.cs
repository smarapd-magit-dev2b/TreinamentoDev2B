using System;

namespace Aula3.Classes.ClassesExe02 {
    public class Aviao : Veiculo {
        public int QntPilotos { get; set; }
        public int QntAcentos { get; set; }
        public string Porte { get; set; }

        public Aviao(string cor, int velmaxia, string tipocombustivel, string marca, int qntrodas, int qntmaximapassageiro, int qntpilotos, int qntacentos, string porte) 
            :base(cor, velmaxia, tipocombustivel, marca, qntrodas, qntmaximapassageiro) {
            QntPilotos = qntpilotos;
            QntAcentos = qntacentos;
            Porte = porte;
        }
    }
}
