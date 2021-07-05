using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Classes
{
    public class Carro
    {

        public string ID { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadePortas { get; set; }
        public decimal Kilometragem { get; set; }

        public void cadastraNovoCarro() { }
        public void listarTodosCarros() { }
        public void excluirCarroPeloId() { }
    }
}
