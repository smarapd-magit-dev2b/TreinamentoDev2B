using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Classes;
using Aula3.Domain;
using Aula3.Exercicio1;

namespace Aula3
{
    public class Herancas
    {
        public void Execute()
        {
            Aula3();
            Ex1();
            Ex2();
        }
        private void Aula3()
        {
            PessoaFisica fisica = new PessoaFisica("Filipe", "168485875", "Rua Treze");
            PessoaJuridica juridica = new PessoaJuridica("Smarapd", "16844841", "Rua Quinze");

            fisica.CPF = "";
            juridica.Nome = "";

            juridica.EscreverInformacoes();
            fisica.EscreverInformacoes();

            Console.ReadLine();
        }

        private void Ex1()
        {
            Console.WriteLine("Informe o nome do cliente: ");
            var nomeCl = Console.ReadLine();

            Console.WriteLine("Informe o endereco do cliente: ");
            var enderecoCl = Console.ReadLine();

            Console.WriteLine("Informe o telefone do cliente: ");
            var telefoneCl = Console.ReadLine();

            Console.WriteLine("Informe o CPF do cliente: ");
            var cpfCl = Console.ReadLine();

            Cliente cliente = new Cliente(nomeCl, enderecoCl, telefoneCl, cpfCl)
            {

            };

            Console.WriteLine("----------------------------");

            Console.WriteLine("Informe o nome do funcionário: ");
            var nomeFun = Console.ReadLine();

            Console.WriteLine("Informe o endereco do funcionário: ");
            var enderecoFun = Console.ReadLine();

            Console.WriteLine("Informe o telefone do funcionário: ");
            var telefoneFun = Console.ReadLine();

            Console.WriteLine("Informe o CPF funcionário: ");
            var cpfFun = Console.ReadLine();

            Funcionario funcionario = new Funcionario(nomeFun, enderecoFun, telefoneFun, cpfFun)
            {

            };

            Console.WriteLine("----------------------------");

            Console.WriteLine("Informe o nome do fornecedor: ");
            var nomeFor = Console.ReadLine();

            Console.WriteLine("Informe o endereco do fornecedor: ");
            var enderecoFor = Console.ReadLine();

            Console.WriteLine("Informe o telefone do fornecedor: ");
            var telefoneFor = Console.ReadLine();

            Console.WriteLine("Informe o CPF do fornecedor: ");
            var cnpjFor = Console.ReadLine();

            Console.WriteLine("Informe o segmento do fornecedor: ");
            var segmentoFor = Console.ReadLine();

            Console.WriteLine("Informe o produto do fornecedor: ");
            var produtoFor = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(nomeFor, enderecoFor, telefoneFor, cnpjFor, segmentoFor, produtoFor)
            {

            };


            Console.Clear();

            Console.WriteLine("\nInformacoes Cliente");
            cliente.EscreverInformacoes();
            Console.WriteLine("\nInformacoes Funcionário");
            funcionario.EscreverInformacoes();
            Console.WriteLine("\nInformacoes Fornecedor");
            fornecedor.EscreverInformacoes();
            
            Console.ReadLine();
        }

        private void Ex2()
        {
            Console.WriteLine("Informe a velocidade máxima do avião: ");
            var vmaxAv = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de combustível do avião: ");
            var tipoCombustivelAv = Console.ReadLine();

            Console.WriteLine("Informe a marca do avião: ");
            var marcaAv = Console.ReadLine();

            Aviao aviao = new Aviao(vmaxAv, tipoCombustivelAv, marcaAv)
            {

            };

            Console.WriteLine("Informe a velocidade máxima do carro: ");
            var vmaxCar = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de combustível do carro: ");
            var tipoCombustivelCar = Console.ReadLine();

            Console.WriteLine("Informe a marca do carro: ");
            var marcaCar = Console.ReadLine();

            Carro carro = new Carro(vmaxCar, tipoCombustivelCar, marcaCar)
            {

            };

            Console.WriteLine("Informe a velocidade máxima da moto: ");
            var vmaxMot = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de combustível da moto: ");
            var tipoCombustivelMot = Console.ReadLine();

            Console.WriteLine("Informe a marca da moto: ");
            var marcaMot = Console.ReadLine();

            Moto moto = new Moto(vmaxMot, tipoCombustivelMot, marcaMot)
            {

            };

            Console.Clear();

            Console.WriteLine("\nInformações Avião");
            aviao.EscreverInformacoes();
            Console.WriteLine("\nInformações Carro");
            carro.EscreverInformacoes();
            Console.WriteLine("\nInformações Moto");
            moto.EscreverInformacoes();

            Console.ReadLine();
        }

        
    }
}
