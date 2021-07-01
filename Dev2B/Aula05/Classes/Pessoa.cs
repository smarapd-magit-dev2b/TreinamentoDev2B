using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public int QuantidadeFilhos { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public void adicionarNovaPessoa() { }

        public void listarTodasAsPessoas() { }
    }
}
