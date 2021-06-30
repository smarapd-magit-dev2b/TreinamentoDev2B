using Domain.Classes.Pessoa.Fisica;
using Domain.Classes.Pessoa.Juridica;
using Domain.Interfaces;
using System;

namespace Aula3.Exercicios.Heranca
{
    public class Exercicio2 : IExecute
    {
        public void Cadastrar()
        {
            //Cliente
            Cliente cliente = new Cliente();

            Console.Write("Exercício 1\n\nDigite o Nome do Cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Digite o CPF do Cliente: ");
            cliente.Cpf = Console.ReadLine();

            Console.Write("Digite o RG do Cliente: ");
            cliente.Rg = Console.ReadLine();

            Console.Write("Digite a Rua do Cliente: ");
            cliente.Endereco.Rua = Console.ReadLine();

            Console.Write("Digite a Cidade do Cliente: ");
            cliente.Endereco.Cidade = Console.ReadLine();

            Console.Write("Digite o Estado do Cliente: ");
            cliente.Endereco.Estado = Console.ReadLine();

            Console.Write("Digite o Quantitade de filhos do Cliente: ");
            cliente.QuantidadeFilhos = int.Parse(Console.ReadLine());

            Console.Write("Digite o Estado Civil do Cliente: ");
            cliente.EstadoCivil = Console.ReadLine();

            Console.Write("Digite o Telefone do Cliente: ");
            cliente.Telefone = int.Parse(Console.ReadLine());

            Console.Write("Digite o Celular do Cliente: ");
            cliente.Celular = int.Parse(Console.ReadLine());

            cliente.ImprimirDadosEssenciais();

            //Fornecedor
            Fornecedor fornecedor = new Fornecedor();

            Console.Write("Digite o Nome do Fornecedor: ");
            fornecedor.Nome = Console.ReadLine();

            Console.Write("Digite o CNPJ do Fornecedor: ");
            fornecedor.Cnpj = Console.ReadLine();

            Console.Write("Digite a Rua do Fornecedor: ");
            fornecedor.Endereco.Rua = Console.ReadLine();

            Console.Write("Digite a Cidade do Fornecedor: ");
            fornecedor.Endereco.Cidade = Console.ReadLine();

            Console.Write("Digite o Estado do Fornecedor: ");
            fornecedor.Endereco.Estado = Console.ReadLine();

            Console.Write("Digite o Telefone do Fornecedor: ");
            fornecedor.Telefone = int.Parse(Console.ReadLine());

            Console.Write("Digite o Celular do Fornecedor: ");
            fornecedor.Celular = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segmento do Fornecedor: ");
            fornecedor.Segmento = Console.ReadLine();

            Console.Write("Digite o Produto do Fornecedor: ");
            fornecedor.Produto = Console.ReadLine();

            fornecedor.ImprimirDadosEssenciais();

            //Funcionário
            Funcionario funcionario = new Funcionario();

            Console.Write("Digite o Nome do Funcionario: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o CPF do Funcionario: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Digite o RG do Funcionario: ");
            funcionario.Rg = Console.ReadLine();

            Console.Write("Digite o CNH do Funcionario: ");
            funcionario.Cnh = Console.ReadLine();

            Console.Write("Digite a Rua do Funcionario: ");
            funcionario.Endereco.Rua = Console.ReadLine();

            Console.Write("Digite a Cidade do Funcionario: ");
            funcionario.Endereco.Cidade = Console.ReadLine();

            Console.Write("Digite o Estado do Funcionario: ");
            funcionario.Endereco.Estado = Console.ReadLine();

            Console.Write("Digite o Quantitade de filhos do Funcionario: ");
            funcionario.QuantidadeFilhos = int.Parse(Console.ReadLine());

            Console.Write("Digite o Estado Civil do Funcionario: ");
            funcionario.EstadoCivil = Console.ReadLine();

            Console.Write("Digite o Telefone do Funcionario: ");
            funcionario.Telefone = int.Parse(Console.ReadLine());

            Console.Write("Digite o Celular do Funcionario: ");
            funcionario.Celular = int.Parse(Console.ReadLine());

            funcionario.ImprimirDadosEssenciais();
        }
    }
}
