using Aula3.Classes;
using Common.Interfaces;
using System;

namespace Aula3.Exercicios.Heranca
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            Cliente cliente = new Cliente()
            {
                Nome = "Joelma",
                Cpf = "57643192875",
                Celular = "91494239482",
                Endereco = "Rua Euclides, Ribeirão Preto - SP",
                EstadoCivil = "Solteira",
                QuantidadeFilhos = 2,
                Telefone = "832190740"
            };

            Console.WriteLine(cliente);

            Fornecedor fornecedor = new Fornecedor()
            {
                Nome = "Roberto Materiais",
                Celular = "5723891522",
                Endereco = "Rua Gustavo Lima, Ribeirão Preto - SP",
                Telefone = "502423442",
                Produto = "Pastel",
                Segmento = "Alimentício"
            };

            Console.WriteLine(fornecedor);

            Funcionario funcionario = new Funcionario()
            {
                Nome = "Douglas",
                Cpf = "1592389523",
                Celular = "0981952342",
                Endereco = "Rua Romeu, Ribeirão Preto - SP",
                EstadoCivil = "Casado",
                QuantidadeFilhos = 0,
                Telefone = "9587213894",
                DataAdmissao = new DateTime(2004, 05, 12),
                Cnh = "47329843212",
                Rg = "40321288732",
                Salario = 1532.2m
            };

            Console.WriteLine(funcionario);
        }
    }
}
