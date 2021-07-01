using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4.Classes.ClassesExe02 {
    public class Carro {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public decimal Preco { get; set; }
        public int QtdPortas { get; set; }
        public int Kilometragem { get; set; }

        public override string ToString() {
            return $"ID: {ID}\nMarca: {Marca}\nAno de fabricação: {AnoFabricacao.ToString("dd/MM/yyyy")}\n" +
                   $"Preço: {Preco}\nQuantidade de Portas: {QtdPortas}\nKilometragem: {Kilometragem}\n\n";
        }

    }
}
