using System;

namespace Aula_3.Exercicio_1
{
    public class Heranca_1
    {
        public void Executar_Aula3Ex1()
        {
            //Cadastro Fornecedor----------------

            Console.WriteLine(" Cadastro de dados Fornecedor ");

            Console.WriteLine("Informe o Nome: ");
            var fnome = Console.ReadLine();

            Console.WriteLine("Informe o Endereço: ");
            var fendereço = Console.ReadLine();

            Console.WriteLine("Informe o Telefone: ");
            var ftelefone = Console.ReadLine();

            Fornecedor f = new Fornecedor(fnome, fendereço, ftelefone);

            //Cadastro Funcionario---------------

            Console.WriteLine(" Cadastro de dados Funcionario ");

            Console.WriteLine("Informe o Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe o Endereço: ");
            var endereço = Console.ReadLine();

            Console.WriteLine("Informe o Telefone: ");
            var telefone = Console.ReadLine();

            Fornecedor p = new Fornecedor(nome, endereço, telefone);

        }




    }
}
