using System;

namespace Aula3.Classes.ClassesExe02 {
    public class Moto : Veiculo {
       public bool PossuiCarenagem { get; set; }

        public Moto(string cor, int velmaxia, string tipocombustivel, string marca, int qntrodas, int qntmaximapassageiro, bool carenagem)
            : base(cor, velmaxia, tipocombustivel, marca, qntrodas, qntmaximapassageiro) {
            PossuiCarenagem = carenagem;
        }
    }
}
