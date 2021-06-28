using System;

namespace Aula3.Interfaces.InterfacesExe04 {
    public interface IContaBancaria {
        void ImprimeExtrato(string nome);
        decimal Sacar();
        decimal Deposito(decimal deposito);
    }
}
