using Aula03.Heranca;
using System;

namespace Aula03
{
    public class Herancas
    {
        public void Exercicio01()
        {
            Pessoa pessoa = new Pessoa();
            Cliente cliente = new Cliente();
            Fornecedor fornecedor = new Fornecedor();
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("");
            Console.WriteLine("==============( Informe as Informações do Cliente )==============");
            Console.WriteLine("");

            Console.WriteLine("Informe o Nome do cliente: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Endereço do cliente: ");
            cliente.Endereco = Console.ReadLine();

            Console.WriteLine("Informe o Telefone do cliente: ");
            cliente.Telefone = Console.ReadLine();

            Console.WriteLine("Informe o CPF do cliente: ");
            cliente.CPF = Console.ReadLine();

            Console.WriteLine("Informe o RG do cliente: ");
            cliente.RG = Console.ReadLine();

            Console.WriteLine("Informe a Quantidade de Filhos do cliente(INT): ");
            cliente.QuantidadeFilhos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Estado Civil do cliente: ");
            cliente.EstadoCivil = Console.ReadLine();

            Console.WriteLine("Informe o Celular do cliente:");
            cliente.Celular = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("==============( Informe as Informações do Fornecedor )==============");
            Console.WriteLine("");

            Console.WriteLine("Informe o Nome do fornecedor: ");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Endereço do fornecedor: ");
            fornecedor.Endereco = Console.ReadLine();

            Console.WriteLine("Informe o Telefone do forncedor: ");
            fornecedor.Endereco = Console.ReadLine();

            Console.WriteLine("Informe o CNPF do fornecedor: ");
            fornecedor.CNPJ = Console.ReadLine();

            Console.WriteLine("Informe o celular do fornecedor: ");
            fornecedor.Celular = Console.ReadLine();

            Console.WriteLine("Informe o Segmento: ");
            fornecedor.Segmento = Console.ReadLine();

            Console.WriteLine("Informe o Produdo de venda do forcedor: ");
            fornecedor.Produto = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("==============( Informe as Informações do Funcionário )==============");
            Console.WriteLine("");

            Console.WriteLine("Informe o Nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Endereço do funcionário: ");
            funcionario.Endereco = Console.ReadLine();

            Console.WriteLine("Informe o Telefone do funcionário: ");
            funcionario.Telefone = Console.ReadLine();

            Console.WriteLine("Informe o CPF do funcionário: ");
            funcionario.CPF = Console.ReadLine();

            Console.WriteLine("Informe o RG do funcionário: ");
            funcionario.RG = Console.ReadLine();

            Console.WriteLine("Informe a CNH do funcionário: ");
            funcionario.CNH = Console.ReadLine();

            Console.WriteLine("Informe a Quantidade de filhos do funcionáio(INT):");
            funcionario.QuantidadeFilhos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o estado civil do funcionário: ");
            funcionario.EstadoCivil = Console.ReadLine();

            Console.WriteLine("Informe o Celular do funcionário: ");
            funcionario.Celular = Console.ReadLine();

            Console.WriteLine("Informe o Salário do funcionário(DECIMAL): ");
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Data de Admissão do funcionário(DATE): ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("__________________( Informações do cliente )_____________________");
            cliente.MostrarInformacoes();
            Console.WriteLine("CPF: " + cliente.CPF);
            Console.WriteLine("RG: " + cliente.RG);
            Console.WriteLine("Quantidade de Filhos: " + cliente.QuantidadeFilhos);
            Console.WriteLine("Estado Civil: " + cliente.EstadoCivil);
            Console.WriteLine("Celular: " + cliente.Celular);


            Console.WriteLine("");
            Console.WriteLine("____________________( Informações do Fornecedor )________________");
            fornecedor.MostrarInformacoes();
            Console.WriteLine("CNPJ: " + fornecedor.CNPJ);
            Console.WriteLine("Celular: " + fornecedor.Celular);
            Console.WriteLine("Segmento: " + fornecedor.Segmento);
            Console.WriteLine("Produto: " + fornecedor.CNPJ);


            Console.WriteLine("");
            Console.WriteLine("_____________________( Informações do Funcionário )_______________");
            funcionario.MostrarInformacoes();
            Console.WriteLine("CPF: " + funcionario.CPF);
            Console.WriteLine("RG: " + funcionario.RG);
            Console.WriteLine("CNH: " + funcionario.CNH);
            Console.WriteLine("Quantidade de Filhos: " + funcionario.QuantidadeFilhos);
            Console.WriteLine("Estado Civil: " + funcionario.EstadoCivil);
            Console.WriteLine("Celular: " + funcionario.Celular);
            Console.WriteLine("Salário: " + funcionario.Salario);
            Console.WriteLine("Data de Admissão: " + funcionario.DataAdmissao);
        }

        public void Exercicio02()
        {
            Veiculo veiculo = new Veiculo();
            Moto moto = new Moto();
            Carro carro = new Carro();
            Aviao aviao = new Aviao();

            Console.WriteLine("");
            Console.WriteLine("==============( Informe as Informações da Moto )==============");
            Console.WriteLine("");

            Console.WriteLine("Informe a cor da moto: ");
            moto.Cor = Console.ReadLine();

            Console.WriteLine("Informe a Velocidade Máxima da moto(INT): ");
            moto.VelocidadeMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Tipo de Combustível da moto: ");
            moto.TipoCombustivel = Console.ReadLine();

            Console.WriteLine("Informe a Marca da moto: ");
            moto.Marca = Console.ReadLine();

            Console.WriteLine("Informe a Quantidade de rodas da moto(INT): ");
            moto.QuantidadeRodas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade máxima de passageiros da moto(INT): ");
            moto.QuantidadeMaximaPassageros = int.Parse(Console.ReadLine());

            Console.WriteLine("A Moto possui Carenagem ?(Bollean): ");
            moto.PossuiCarenagem = Boolean.Parse(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("==============( Informe as Informações do Carro )==============");
            Console.WriteLine("");


            Console.WriteLine("Informe a cor do carro: ");
            carro.Cor = Console.ReadLine();

            Console.WriteLine("Informe a Velocidade Máxima do carro(INT): ");
            carro.VelocidadeMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Tipo de Combustível do carro: ");
            carro.TipoCombustivel = Console.ReadLine();

            Console.WriteLine("Informe a Marca do carro: ");
            carro.Marca = Console.ReadLine();

            Console.WriteLine("Informe a Quantidade de rodas do carro (INT): ");
            carro.QuantidadeRodas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade de Portas do carro(INT): ");
            carro.QuantidadePortas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade Máxima de passageiros(INT): ");
            carro.QuantidadeMaximaPassageiros = int.Parse(Console.ReadLine());

            Console.WriteLine("O Carro possui Step? (BOLLEAN): ");
            carro.PossuiStep = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("O Carro possui Tração Traseira? (BOLLEAN): ");
            carro.PossuiTracaoTraseira = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("==============( Informe as Informações do Avião )==============");
            Console.WriteLine("");

            Console.WriteLine("Informe a cor do avião: ");
            aviao.Cor = Console.ReadLine();

            Console.WriteLine("Informe a Velocidade Máxima do avião(INT): ");
            aviao.VelocidadeMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Tipo de Combustível do avião: ");
            aviao.TipoCombustivel = Console.ReadLine();

            Console.WriteLine("Informe a Marca do avião: ");
            aviao.Marca = Console.ReadLine();

            Console.WriteLine("Informe a Quantidade de rodas do avião (INT): ");
            aviao.QuantidadeRodas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade de Pilotos(INT): ");
            aviao.QuantidadePilotos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade de acentos no avião(INT): ");
            aviao.QuantidadeAcentos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Porte do avião: ");
            aviao.Porte = Console.ReadLine();

            Console.WriteLine("Informe a Quantidade Máxima de Passageiros no avião(INT): ");
            aviao.QuantidadeMaximaPassageiros = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("__________________( Informações da Moto )_____________________");
            moto.MostrarInformacoes();
            Console.WriteLine("Quantidade Máxima de Passageiros: " + moto.QuantidadeMaximaPassageros);
            Console.WriteLine("Possui Carenagem: " + moto.PossuiCarenagem);


            Console.WriteLine("");
            Console.WriteLine("__________________( Informações do Carro )_____________________");
            carro.MostrarInformacoes();
            Console.WriteLine("Quantidade de Portas: " + carro.QuantidadePortas);
            Console.WriteLine("Quantidade Máxima de Passageiros: " + carro.QuantidadeMaximaPassageiros);
            Console.WriteLine("Possui Step: " + carro.PossuiStep);
            Console.WriteLine("Possui Tração Traseira: " + carro.PossuiTracaoTraseira);


            Console.WriteLine("");
            Console.WriteLine("__________________( Informações do Carro )_____________________");
            aviao.MostrarInformacoes();
            Console.WriteLine("Quantidade de Pilotos: " + aviao.QuantidadePilotos);
            Console.WriteLine("Quantidade de Acentos: " + aviao.QuantidadeAcentos);
            Console.WriteLine("Porte: " + aviao.Porte);
            Console.WriteLine("Quantidade Máxima de Passageiros: " + aviao.QuantidadeMaximaPassageiros);

        }

        public void Execute()
        {
            //Exercicio01();
            //Exercicio02();
        }
    }
}
