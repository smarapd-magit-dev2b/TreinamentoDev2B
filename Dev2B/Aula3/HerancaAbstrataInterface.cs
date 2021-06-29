using Aula3.Exercicio1Abstrata;
using Aula3.Exercicio1HerancaClasses;
using Aula3.Exercicio1Interface;
using Aula3.Exercicio2Abstrata;
using Aula3.Exercicio2HerancaClasses;
using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Exercicio2Interface;

namespace Aula3
{
   public class HerancaAbstrataInterface
   {
        private void Exercicio1Heranca()
        {
            Console.WriteLine("----- INFORMAR OS DADOS CLIENTE -----");
            Console.Write("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Digite o endereço do cliente: ");
            string enderecoCliente = Console.ReadLine();
            Console.Write("Digite o telefone do cliente: ");
            string telefoneCliente = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("----- INFORMAR OS DADOS FUNCIONÁRIO -----");
            Console.Write("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Digite o endereço do funcionário: ");
            string enderecoFuncionario = Console.ReadLine();
            Console.Write("Digite o telefone do funcionário: ");
            string telefoneFuncionario = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("----- INFORMAR OS DADOS FORNECEDOR -----");
            Console.Write("Digite o nome do fornecedor: ");
            string nomeFornecedor = Console.ReadLine();
            Console.Write("Digite o endereço do fornecedor: ");
            string enderecoFornecedor = Console.ReadLine();
            Console.Write("Digite o telefone do fornecedor: ");
            string telefoneFornecedor = Console.ReadLine();

            Cliente cliente = new Cliente(nomeCliente, enderecoCliente, telefoneCliente);
            Funcionario funcionario = new Funcionario(nomeFuncionario, enderecoFuncionario, telefoneFuncionario);
            Fornecedor fornecedor = new Fornecedor(nomeFornecedor, enderecoFornecedor, telefoneFornecedor);

            Console.Clear();
            Console.WriteLine("----- DADOS GERAIS -----\n");
            Console.WriteLine("----- Dados Cliente -----");
            cliente.EscreverInformacoes();

            Console.WriteLine("----- Dados Funcionário -----");
            funcionario.EscreverInformacoes();

            Console.WriteLine("----- Dados Fornecedor -----");
            fornecedor.EscreverInformacoes();
        }

        private void Exercicio2Heranca()
        {
            Console.WriteLine("----- INFORMAR DADOS CARRO -----");
            Console.Write("Modelo: ");
            string modeloCarro = Console.ReadLine();
            Console.Write("Cor: ");
            string corCarro = Console.ReadLine();
            Console.Write("Velocidade máxima: ");
            decimal velocidadeMaximaCarro = decimal.Parse(Console.ReadLine());
            Console.Write("Tipo Combustível: ");
            string tipoCombustivelCarro = Console.ReadLine();
            Console.Write("Quantidade máxima de passageiros: ");
            int qntMaximaPassageirosCarro = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de Rodas: ");
            int qntRodasCarro = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("----- INFORMAR DADOS MOTO -----");
            Console.Write("Modelo: ");
            string modeloMoto = Console.ReadLine();
            Console.Write("Cor: ");
            string corMoto = Console.ReadLine();
            Console.Write("Velocidade máxima: ");
            decimal velocidadeMaximaMoto = decimal.Parse(Console.ReadLine());
            Console.Write("Tipo Combustível: ");
            string tipoCombustivelMoto = Console.ReadLine();
            Console.Write("Quantidade máxima de passageiros: ");
            int qntMaximaPassageirosMoto = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de Rodas: ");
            int qntRodasMoto = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("----- INFORMAR DADOS CARRO -----");
            Console.Write("Modelo: ");
            string modeloAviao = Console.ReadLine();
            Console.Write("Cor: ");
            string corAviao = Console.ReadLine();
            Console.Write("Velocidade máxima: ");
            decimal velocidadeMaximaAviao = decimal.Parse(Console.ReadLine());
            Console.Write("Tipo Combustível: ");
            string tipoCombustivelAviao = Console.ReadLine();
            Console.Write("Quantidade máxima de passageiros: ");
            int qntMaximaPassageirosAviao = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de Rodas: ");
            int qntRodasAviao = int.Parse(Console.ReadLine());

            Carro carro = new Carro(modeloCarro, corCarro, velocidadeMaximaCarro, tipoCombustivelCarro, qntMaximaPassageirosCarro, qntRodasCarro);
            Moto moto = new Moto(modeloMoto, corMoto, velocidadeMaximaMoto, tipoCombustivelMoto, qntMaximaPassageirosMoto, qntRodasMoto);
            Aviao aviao = new Aviao(modeloAviao, corAviao, velocidadeMaximaAviao, tipoCombustivelAviao, qntMaximaPassageirosAviao, qntRodasAviao);

            Console.Clear();
            Console.WriteLine("----- DADOS GERAIS -----\n");
            Console.WriteLine("----- Dados Carro -----");
            carro.EscreverInformacoes();

            Console.WriteLine("----- Dados Moto -----");
            moto.EscreverInformacoes();

            Console.WriteLine("----- Dados Avião -----");
            aviao.EscreverInformacoes();
        }

        private void Exercicio1Abstrata()
        {
            Console.WriteLine("----- INFORMAÇÕES DA CONTA CORRENTE -----");
            Console.Write("Número da conta: ");
            string numeroContaC = Console.ReadLine();
            Console.Write("Agência: ");
            string agenciaC = Console.ReadLine();
            Console.Write("Saldo: ");
            decimal saldoC = decimal.Parse(Console.ReadLine());
            Console.Write("Quantia a depositar: ");
            decimal depositarC = decimal.Parse(Console.ReadLine());
            Console.Write("Quantia a sacar: ");
            decimal saqueC = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("----- INFORMAÇÕES DA CONTA POUPANÇA -----");
            Console.Write("Número da conta: ");
            string numeroContaP = Console.ReadLine();
            Console.Write("Agência: ");
            string agenciaP = Console.ReadLine();
            Console.Write("Saldo: ");
            decimal saldoP = decimal.Parse(Console.ReadLine());
            Console.Write("Quantia a depositar: ");
            decimal depositarP = decimal.Parse(Console.ReadLine());
            Console.Write("Quantia a sacar: ");
            decimal saqueP = decimal.Parse(Console.ReadLine());

            Exercicio1Abstrata.ContaCorrente contaCorrente = new Exercicio1Abstrata.ContaCorrente(numeroContaC, saqueC, depositarC, agenciaC, saldoC);
            Exercicio1Abstrata.ContaPoupanca contaPoupanca = new Exercicio1Abstrata.ContaPoupanca(numeroContaP, saqueP, depositarP, agenciaP, saldoP);

            Console.Clear();

            contaCorrente.ImpreExtrato();
            contaPoupanca.ImpreExtrato();
        }

        private void Exercicio1Interface()
        {
            Console.WriteLine("----- INFORMAÇÕES DA CONTA CORRENTE -----");
            Console.Write("Número da conta: ");
            string numeroContaC = Console.ReadLine();
            Console.Write("Agência: ");
            string agenciaC = Console.ReadLine();
            Console.Write("Saldo: ");
            decimal saldoC = decimal.Parse(Console.ReadLine());
            Console.Write("Quantia a depositar: ");
            decimal depositarC = decimal.Parse(Console.ReadLine());
            Console.Write("Quantia a sacar: ");
            decimal saqueC = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("----- INFORMAÇÕES DA CONTA POUPANÇA -----");
            Console.Write("Número da conta: ");
            string numeroContaP = Console.ReadLine();
            Console.Write("Agência: ");
            string agenciaP = Console.ReadLine();
            Console.Write("Saldo: ");
            decimal saldoP = decimal.Parse(Console.ReadLine());
            Console.Write("Quantia a depositar: ");
            decimal depositarP = decimal.Parse(Console.ReadLine());
            Console.Write("Quantia a sacar: ");
            decimal saqueP = decimal.Parse(Console.ReadLine());

            Exercicio1Interface.ContaCorrente contaCorrente = new Exercicio1Interface.ContaCorrente(numeroContaC, saqueC, depositarC, agenciaC, saldoC);
            Exercicio1Interface.ContaPoupanca contaPoupanca = new Exercicio1Interface.ContaPoupanca(numeroContaP, saqueP, depositarP, agenciaP, saldoP);

            Console.Clear();

            contaCorrente.ImpreExtrato();
            contaPoupanca.ImpreExtrato();
        }

        private void Exercicio2Abstrata()
        {
            Console.Write("Digite o valor do primerio número: ");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor do segundo número: ");
            decimal valor2 = decimal.Parse(Console.ReadLine());

            Exercicio2Abstrata.Soma soma = new Exercicio2Abstrata.Soma(valor1, valor2);
            Exercicio2Abstrata.Subtracao subtracao = new Exercicio2Abstrata.Subtracao(valor1, valor2);
            Exercicio2Abstrata.Multiplicacao multiplicacao = new Exercicio2Abstrata.Multiplicacao(valor1, valor2);
            Exercicio2Abstrata.Divisao divisao = new Exercicio2Abstrata.Divisao(valor1, valor2);

            Console.WriteLine("\n ----- RESULTADOS -----");
            Console.WriteLine($"Soma = {soma.Calcular(valor1, valor2)}");
            Console.WriteLine($"Subtracao = {subtracao.Calcular(valor1, valor2)}");
            Console.WriteLine($"Multiplicação = {multiplicacao.Calcular(valor1, valor2)}");
            Console.WriteLine($"Divisão = {divisao.Calcular(valor1, valor2)}");
        }

        private void Exercicio2Interface()
        {
            Console.Write("Digite o valor do primerio número: ");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor do segundo número: ");
            decimal valor2 = decimal.Parse(Console.ReadLine());

            Exercicio2Interface.Soma soma = new Exercicio2Interface.Soma(valor1, valor2);
            Exercicio2Interface.Subtracao subtracao = new Exercicio2Interface.Subtracao(valor1, valor2);
            Exercicio2Interface.Multiplicacao multiplicacao = new Exercicio2Interface.Multiplicacao(valor1, valor2);
            Exercicio2Interface.Divisao divisao = new Exercicio2Interface.Divisao(valor1, valor2);

            Console.WriteLine("\n ----- RESULTADOS -----");
            Console.WriteLine($"Soma = {soma.Calcular(valor1, valor2)}");
            Console.WriteLine($"Subtracao = {subtracao.Calcular(valor1, valor2)}");
            Console.WriteLine($"Multiplicação = {multiplicacao.Calcular(valor1, valor2)}");
            Console.WriteLine($"Divisão = {divisao.Calcular(valor1, valor2)}");
        }

        public void Executar()
        {
            Exercicio1Heranca();
            Exercicio2Heranca();
            Exercicio1Abstrata();
            Exercicio1Interface();
            Exercicio2Abstrata();
            Exercicio2Interface();
        }
    }
}
