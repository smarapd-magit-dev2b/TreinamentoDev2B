using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aula5;
using Aula5.Classes;
using Aula5.Exercicio3Classes;
using Aula5.Exercicio4Classes;
using Aula5.Exercicio5Classes;
using Aula5.Exercicio6Classes;

namespace Aula5
{
    public class ColecoesListas
    {
        public void Execute()
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
        }
        private void Exercicio1()
        {
            var listaPessoas = new List<Pessoas>
            {
                new Pessoas
                {
                    Nome = "Filipe",
                    Sobrenome = "Cardoso",
                    Cpf = "123.456.789-91",
                    DataNascimento = new DateTime(1996, 11, 18)
                },

                new Pessoas
                {
                    Nome = "Joao",
                    Sobrenome = "Silva",
                    Cpf = "321.654.987-01",
                    DataNascimento = new DateTime(1997, 12, 20)
                }
            };
            foreach (var item in listaPessoas)
            {
                Console.WriteLine($"Nome: { item.Nome}");
                Console.WriteLine($"Sobrenome:  {item.Sobrenome}");
                Console.WriteLine($"CPF: {item.Cpf}");
                Console.WriteLine($"Data de Nascimento: {item.DataNascimento.ToString("dd/MM/yyyy")}");
                Console.WriteLine();
            }
        }
        private void Exercicio2()
        {
            var listaPessoa18 = new List<Pessoa18>
            {
                new Pessoa18
                {
                    Nome = "Filipe",
                    Sobrenome = "Cardoso",
                    Telefone = "111515151",
                    DatNascimento = new DateTime(1996, 11, 18)
                },
                new Pessoa18
                {
                    Nome = "Bruno",
                    Sobrenome = "Cardoso",
                    Telefone = "48484851",
                    DatNascimento = new DateTime(1997, 10, 11)
                },
                new Pessoa18
                {
                    Nome = "Eduardo",
                    Sobrenome = "Camargo",
                    Telefone = "1544481",
                    DatNascimento = new DateTime(2002, 1, 21)
                },
                new Pessoa18
                {
                    Nome = "Filipe",
                    Sobrenome = "Dias",
                    Telefone = "4599556",
                    DatNascimento = new DateTime(2012, 06, 25)
                }
            };

            foreach (var pessoa in listaPessoa18)
            {
                Console.WriteLine(pessoa);
            }

            var pessoasMaioresIdade = listaPessoa18.Where(x => new DateTime((DateTime.Now - x.DatNascimento).Ticks).Year >= 18);
            foreach (var pessoa in pessoasMaioresIdade)
            {
                pessoa.Sobrenome += " (maior de idade)";
            }

            Console.WriteLine("\n\nPessoas com sobrenome ajustado");
            foreach (var pessoa in listaPessoa18)
            {
                Console.WriteLine(pessoa);
            }
        }
        private void Exercicio3()
        {
            var listaPessoa = new List<Pessoa>();

            var cadastro = ObterOpcaoUsuario();

            while (cadastro.ToUpper() != "N")
            {
                Console.WriteLine("Informe o nome: ");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe o número de telefone: ");
                var telefone = Console.ReadLine();

                Console.WriteLine("Informe a data de nascimento: ");
                var datNasc = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Informe o salário: ");
                var salario = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de filhos: ");
                var qtdFilhos = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura: ");
                var altura = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe o peso: ");
                var peso = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe o nome do pai: ");
                var nomePai = Console.ReadLine();

                Console.WriteLine("Informe o nome da mãe: ");
                var nomeMae = Console.ReadLine();

                Console.Clear();

                listaPessoa.Add(new Pessoa(nome, telefone, datNasc, salario, qtdFilhos,
                    altura, peso, nomePai, nomeMae));

                cadastro = ObterOpcaoUsuario();
            }
            Console.Clear();
            foreach (var pessoa in listaPessoa)
            {
                Console.WriteLine(pessoa);
            }
            static string ObterOpcaoUsuario()
            {
                Console.WriteLine("Deseja cadastrar pessoa (S/N): ");
                var cadastro = Console.ReadLine();
                while (cadastro.ToUpper() != "S" && cadastro.ToUpper() != "N")
                {
                    Console.WriteLine("Opção Inválida");
                    Console.WriteLine("Informe S para Sim ou N para Não");
                    cadastro = Console.ReadLine();
                }
                return cadastro;
            }

        }
        private void Exercicio4()
        {
            var listaCarro = new List<Carro>();

            var opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "4")
            {
                Console.Clear();
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o ID do carro: ");
                        var id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a marca do carro: ");
                        var marca = Console.ReadLine();

                        Console.WriteLine("Informe a cor do carro: ");
                        var cor = Console.ReadLine();

                        Console.WriteLine("Informe o ano de fabricaçao do carro: ");
                        var anoFabricacao = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o preço do carro: ");
                        var preco = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de portas do carro: ");
                        var qtdPortas = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a kilometragem do carro: ");
                        var km = Console.ReadLine();

                        listaCarro.Add(new Carro(id, marca, cor, anoFabricacao, preco, qtdPortas, km));
                        break;
                    case "2":
                        Console.WriteLine("\nLista de todos os carros cadastrados");
                        if (listaCarro != null)
                        {
                            foreach (var carro in listaCarro)
                            {
                                Console.WriteLine(carro);
                            }
                            Console.ReadLine();
                        }
                        else
                            Console.WriteLine("Não existem carros cadastrados.");
                        break;
                    case "3":
                        Console.WriteLine("\nExcluir carros");
                        Console.WriteLine("Informe o id do carro que deseja excluir: ");
                        var idRemover = int.Parse(Console.ReadLine());
                        var excluirCarro = listaCarro.Where(x => x.Id == idRemover).FirstOrDefault();
                        listaCarro.Remove(excluirCarro);
                        Console.WriteLine("Carro Excluido.");
                        break;
                    default:
                        Console.WriteLine("Opcão Inválida");
                        Console.WriteLine(ObterOpcaoUsuario());
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
                Console.Clear();
            }
            Console.WriteLine("\nPrograma encerrado");

            static string ObterOpcaoUsuario()
            {
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Cadastrar novo carro");
                Console.WriteLine("2 - Listar todos os carros");
                Console.WriteLine("3 - Excluir carro");
                Console.WriteLine("4 - Sair");
                var opcaoUsuario = Console.ReadLine();
                return opcaoUsuario;
            }
        }
        private void Exercicio5()
        {
            var listaAluno = new List<Aluno>();

            var opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "6")
            {
                Console.Clear();
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o ID do aluno: ");
                        var idAluno = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o nome do aluno: ");
                        var nome = Console.ReadLine();

                        Console.WriteLine("Informe a idade do aluno: ");
                        var idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o nome do pai do aluno: ");
                        var nomePai = Console.ReadLine();

                        Console.WriteLine("Informe o nome da mae do aluno: ");
                        var nomeMae = Console.ReadLine();

                        Console.WriteLine("Informe o RA do aluno: ");
                        var ra = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a data de nascimento do aluno: ");
                        var datNasc = DateTime.Parse(Console.ReadLine());

                        listaAluno.Add(new Aluno(idAluno, nome, idade, nomePai, nomeMae, ra, datNasc));
                        break;
                    case "2":
                        Console.WriteLine("\nLista de todos os alunos cadastrados");
                        foreach (var aluno in listaAluno)
                        {
                            Console.WriteLine(aluno.AlunoToString());
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("\nPesquisar aluno");
                        Console.WriteLine("Informe o id ou nome do aluno: ");
                        var idPesquisar = Console.ReadLine();
                        var listarAluno = listaAluno.Where(x => x.Id == int.Parse(idPesquisar) || x.Nome == idPesquisar).FirstOrDefault();
                        Console.WriteLine(listarAluno.AlunoToString());

                        break;
                    case "4":
                        Console.WriteLine("\nExcluir aluno");
                        Console.WriteLine("Informe o id ou nome do aluno: ");
                        var idRemover = Console.ReadLine();
                        var excluirAluno = listaAluno.FirstOrDefault(x => x.Id == int.Parse(idRemover) || x.Nome == idRemover);
                        listaAluno.Remove(excluirAluno);
                        Console.WriteLine("Aluno Excluido.");
                        break;

                    case "5":
                        Console.WriteLine("\nAlterar ");
                        Console.WriteLine("Informe o id ou nome do aluno: ");
                        var idAlterar = Console.ReadLine();


                        Console.WriteLine("\nInforme o novo nome do aluno: ");
                        var nomeAlterado = Console.ReadLine();
                        var alterarAluno = listaAluno.FirstOrDefault(x => x.Id == int.Parse(idAlterar) || x.Nome == idAlterar);
                        alterarAluno.Nome = nomeAlterado;
                        Console.WriteLine("Nome alterado.");


                        break;
                    default:
                        Console.WriteLine("Opcão Inválida");
                        Console.WriteLine(ObterOpcaoUsuario());
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
                Console.Clear();
            }
            Console.WriteLine("\nPrograma encerrado");


            static string ObterOpcaoUsuario()
            {
                Console.WriteLine("\nInforme a opção desejada: ");
                Console.WriteLine("1 - Cadastrar novo aluno");
                Console.WriteLine("2 - Listar todos os alunos");
                Console.WriteLine("3 - Pesquisar aluno");
                Console.WriteLine("4 - Excluir aluno");
                Console.WriteLine("5 - Alterar nome do aluno");
                Console.WriteLine("6 - Sair");
                var opcaoUsuario = Console.ReadLine();
                return opcaoUsuario;
            }

        }
        private void Exercicio6()
        {
            var listaVenda = new List<Venda>();

            var opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "9")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Informe o ID da venda: ");
                        var idVenda = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a data da venda: ");
                        var dataVenda = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o nome do vendedor: ");
                        var vendedor = Console.ReadLine();

                        Console.WriteLine("Informe o ID do item: ");
                        var idItem = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a descrição do item: ");
                        var descricao  = Console.ReadLine();

                        Console.WriteLine("Informe a quantidade de itens: ");
                        var quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o preço unitário: ");
                        var precoUnit = decimal.Parse(Console.ReadLine());

                        var venda = new Venda(idVenda, dataVenda, vendedor);
                        listaVenda.Add(venda);
                        var itensV = new ItemVenda(idItem, descricao, quantidade, precoUnit);
                        venda.Itens.Add(itensV);
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("\nLista de todas as vendas");
                        foreach (var vendas in listaVenda)
                        {
                            Console.WriteLine($"\nID da venda: {vendas.Id}");
                            Console.WriteLine($"Data da venda: {vendas.DataVenda.ToString("dd/MM/yyyy")}");
                            Console.WriteLine($"Nome do vendedor: {vendas.Vendedor}");

                            foreach (var itemV in vendas.Itens )
                            {
                                Console.WriteLine($"ID do item: {itemV.IdItem}");
                                Console.WriteLine($"Descrição do item: {itemV.Descricao}");
                                Console.WriteLine($"Quantidade: {itemV.Quantidade}");
                                Console.WriteLine($"Preço Unitário: {itemV.PrecoUnitario}");
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("\nExcluir venda");
                        Console.WriteLine("Informe o id da venda: ");
                        var idRemover = Console.ReadLine();
                        var excluirVenda = listaVenda.FirstOrDefault(x => x.Id == int.Parse(idRemover));
                        listaVenda.Remove(excluirVenda);
                        Console.WriteLine("Venda Excluida.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("\nExcluir item da venda");
                        Console.WriteLine("Informe o id da venda: ");
                        var idVendaRemover = Console.ReadLine();
                        Console.WriteLine("Informe o id do item: ");
                        var idItemRemover = Console.ReadLine();
                        var listarVendas = listaVenda.FirstOrDefault(x => x.Id == int.Parse(idVendaRemover));
                        var excluirItem = listarVendas.Itens.FirstOrDefault(x => x.IdItem == int.Parse(idItemRemover));
                        if (excluirItem != null)
                        {
                            listarVendas.Itens.Remove(excluirItem);
                            Console.WriteLine("Item Excluido.");
                        }        
                        else
                            Console.WriteLine("Item não encontrado");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("\nPesquisar venda por data");
                        Console.WriteLine("\nInforme a data: ");
                        var dataPesquisar = DateTime.Parse(Console.ReadLine());
                        var listarData = listaVenda.Where(x => x.DataVenda == dataPesquisar);
                        if (listarData != null)
                        {
                            foreach (var vendas in listarData)
                            {
                                Console.WriteLine($"\nID da venda: {vendas.Id}");
                                Console.WriteLine($"Data da venda: {vendas.DataVenda.ToString("dd/MM/yyyy")}");
                                Console.WriteLine($"Nome do vendedor: {vendas.Vendedor}");

                                foreach (var itemV in vendas.Itens)
                                {
                                    Console.WriteLine($"ID do item: {itemV.IdItem}");
                                    Console.WriteLine($"Descrição do item: {itemV.Descricao}");
                                    Console.WriteLine($"Quantidade: {itemV.Quantidade}");
                                    Console.WriteLine($"Preço Unitário: {itemV.PrecoUnitario}");
                                }
                            }
                        }
                        else
                            Console.WriteLine("Data não encontrada");
                        
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "6":
                        Console.WriteLine("\nPesquisar venda por periodo");
                        Console.WriteLine("\nInforme a data inicial: ");
                        var dataInicial = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("\nInforme a data final: ");
                        var dataFinal = DateTime.Parse(Console.ReadLine());
                        var periodo = listaVenda.Where(x => x.DataVenda > dataInicial && x.DataVenda < dataFinal);

                        foreach (var vendas in periodo)
                        {
                            Console.WriteLine($"\nID da venda: {vendas.Id}");
                            Console.WriteLine($"Data da venda: {vendas.DataVenda.ToString("dd/MM/yyyy")}");
                            Console.WriteLine($"Nome do vendedor: {vendas.Vendedor}");

                            foreach (var itemV in vendas.Itens)
                            {
                                Console.WriteLine($"ID do item: {itemV.IdItem}");
                                Console.WriteLine($"Descrição do item: {itemV.Descricao}");
                                Console.WriteLine($"Quantidade: {itemV.Quantidade}");
                                Console.WriteLine($"Preço Unitário: {itemV.PrecoUnitario}");
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "7":
                        Console.WriteLine("\nPesquisar venda por vendedor");
                        Console.WriteLine("\nInforme o nome do vendedor: ");
                        var nomeVendedor = Console.ReadLine();
                        var pesquisaVendedor = listaVenda.Where(x => x.Vendedor == nomeVendedor);
                        foreach (var vendas in pesquisaVendedor)
                        {
                            Console.WriteLine($"\nID da venda: {vendas.Id}");
                            Console.WriteLine($"Data da venda: {vendas.DataVenda.ToString("dd/MM/yyyy")}");
                            Console.WriteLine($"Nome do vendedor: {vendas.Vendedor}");

                            foreach (var itemV in vendas.Itens)
                            {
                                Console.WriteLine($"ID do item: {itemV.IdItem}");
                                Console.WriteLine($"Descrição do item: {itemV.Descricao}");
                                Console.WriteLine($"Quantidade: {itemV.Quantidade}");
                                Console.WriteLine($"Preço Unitário: {itemV.PrecoUnitario}");
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "8":
                        Console.WriteLine("\nAlterar quantidade do item");
                        Console.WriteLine("\nInforme o ID da venda: ");
                        var idVendaAlterar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o ID do item: ");
                        var idItemAlterar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a nova quantidade do item: ");
                        var idQuantidadeAlterada = int.Parse(Console.ReadLine()) ;

                        var listarVendasQ = listaVenda.FirstOrDefault(x => x.Id == idVendaAlterar);
                        var alterarQuantidade = listarVendasQ.Itens.FirstOrDefault(x => x.IdItem == idItemAlterar);
                        alterarQuantidade.Quantidade = idQuantidadeAlterada;
                        Console.WriteLine("Quantidade alterada");

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        Console.ReadLine();
                        Console.WriteLine(ObterOpcaoUsuario());
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
                Console.Clear();
            }
            Console.WriteLine("\nPrograma encerrado");
            static string ObterOpcaoUsuario()
            {
                Console.WriteLine("\nInforme a opção desejada: ");
                Console.WriteLine("1 - Cadastrar nova venda");
                Console.WriteLine("2 - Listar todos as vendas");
                Console.WriteLine("3 - Excluir venda");
                Console.WriteLine("4 - Excluir item da venda");
                Console.WriteLine("5 - Pesquisar venda por Data");
                Console.WriteLine("6 - Pesquisar venda por Periodo");
                Console.WriteLine("7 - Pesquisar venda por Vendedor");
                Console.WriteLine("8 - Alterar a quantidade do item");
                Console.WriteLine("9 - Sair");
                var opcaoUsuario = Console.ReadLine();
                return opcaoUsuario;
            }
        }
    }

}
