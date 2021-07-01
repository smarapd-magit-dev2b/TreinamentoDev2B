using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }
        public void MostrarInformacoes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Telefone: " + Telefone);
        }
    }
}
