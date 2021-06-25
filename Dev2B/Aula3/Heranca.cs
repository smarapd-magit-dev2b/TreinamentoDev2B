using Aula3.Domain;
using Aula3.Exercicio3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    public class Heranca
    {
        public void Execute()
        {
            Exercicio1();
            Exercicio2();
        }
        private void Exercicio1()
        {
            Console.WriteLine("Fornecedor");
            PessoaJuridica fornecedor = new PessoaJuridica("Coca Cola", "Rua nao sei", "2516", "123", "15616516516516");
            Console.WriteLine(fornecedor.InprimirInformacoes());

            Console.WriteLine("\n\nCliente");
            Cliente cliente = new Cliente("Teste", "Rua 1", "132", "321", "789", "654", 0, "Solteiro");
            Console.WriteLine(cliente.InprimirInformacoes());

            Console.WriteLine("\n\nFuncionario");
            Funcionario funcionario = new Funcionario("Funcionario teste", "Rua qualquer", "123456", "987654", "561651", "16516", 0, "Casado", 1, "asdasd", DateTime.Now);
            Console.WriteLine(funcionario.InprimirInformacoes());
        }
        private void Exercicio2()
        {
            Console.WriteLine("\n\nCarro");
            Carro carro = new Carro("Azul", 673.3m, "Gasolina", "BMW", 4, 4, true, true, 2);
            Console.WriteLine(carro.ImprimeInformacoes());


            Console.WriteLine("\n\nMoto");
            Moto moto = new Moto("Vermelha", 312m, "Gasolina", "Honda", 2, 2, false);
            Console.WriteLine(moto.ImprimeInformacoes());


            Console.WriteLine("\n\nAviao");
            Aviao aviao = new Aviao("Branco", 1122m, "V-GAS", "Embraer", 25, 7, 2, "Medio");
            Console.WriteLine(aviao.ImprimeInformacoes());

        }
    }
}
