using Aula05_Lista.ClassesAula05;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Aula05_Lista
{
    public class ExerciciosAula05
    {
        public void Execute()
        {
            //Exemplo01();
            //Exemplo02();
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
        }
        private void Exemplo01()
        // Criar a classe PESSOA. Cadastrar uma nova pessoa e listar o nome de todas as pessoas cadastradas e formatar a data de nascimento para dia/mes/ano

        {

            var listpessoa = new List<ExemploPessoa>
            {
                new ExemploPessoa{Nome = "Lucas", Sobrenome = "Capalbo", CPF = "48407816809", Nascimento = new DateTime(1997,11,10)},
                new ExemploPessoa{Nome = "Anderson", Sobrenome = "Luiz Capalbo", CPF = "15625162808", Nascimento = new DateTime(1973,06,28)},
                new ExemploPessoa{Nome = "Patricia", Sobrenome = "Capalbo", CPF = "1234678901", Nascimento = new DateTime(1974,03,18)},

        };
            foreach (var pessoa in listpessoa)
            {
                Console.WriteLine($"Nome: {pessoa.Nome} {pessoa.Sobrenome}");
                Console.WriteLine($"CPF: {pessoa.CPF}");
                Console.WriteLine($"Data de Nascimento: {pessoa.Nascimento.ToString("dd/MM/yyyy")}");
            }
        }
        private void Exemplo02()
        //Buscar as pessoas maiores que 18 anos e no sobrenome concatenar "maior de idade"
        {

            var listPessoa = new List<ExemploPessoa>
            {
                new ExemploPessoa{Nome = "Pessoa01", Sobrenome = "Sobrenome01", CPF = "45127894630", Nascimento = new DateTime(1991,12,04)},
                new ExemploPessoa{Nome = "Pessoa02", Sobrenome = "Sobrenome02", CPF = "12457913402", Nascimento = new DateTime(1975,05,03)},
                new ExemploPessoa{Nome = "Pessoa03", Sobrenome = "Sobrenome03", CPF = "78495124630", Nascimento = new DateTime(1997,11,10)},
                new ExemploPessoa{Nome = "Pessoa04", Sobrenome = "Sobrenome04", CPF = "78945031642", Nascimento = new DateTime(2010,08,06)},
                new ExemploPessoa{Nome = "Pessoa05", Sobrenome = "Sobrenome05", CPF = "45784213469", Nascimento = new DateTime(2015,06,08)},
                new ExemploPessoa{Nome = "Pessoa06", Sobrenome = "Sobrenome06", CPF = "12450736025", Nascimento = new DateTime(2020,05,28)},
                new ExemploPessoa{Nome = "Pessoa07", Sobrenome = "Sobrenome07", CPF = "45127896340", Nascimento = new DateTime(2001,07,11)},
                new ExemploPessoa{Nome = "Pessoa08", Sobrenome = "Sobrenome08", CPF = "45787946123", Nascimento = new DateTime(2006,02,24)},
                new ExemploPessoa{Nome = "Pessoa09", Sobrenome = "Sobrenome09", CPF = "45784210452", Nascimento = new DateTime(2014,01,30)},
                new ExemploPessoa{Nome = "Pessoa10", Sobrenome = "Sobrenome10", CPF = "78451243769", Nascimento = new DateTime(2018,09,15)},
        };

            var pessoasMaioresDe18Anos = listPessoa.Where(x => new DateTime((DateTime.Now - x.Nascimento).Ticks).Year >= 18);
            foreach (var pessoa in pessoasMaioresDe18Anos)
            {
                pessoa.Sobrenome += " (maior de idade)";
            }

            Console.WriteLine("\n\nPessoas com sobrenome ajustado");
            foreach (var pessoa in listPessoa)
            {
                Console.WriteLine($"{pessoa.Nome} {pessoa.Sobrenome} {pessoa.CPF} {pessoa.Nascimento.ToString("dd/MM/yyyy")}");
            }
        }
        private void Exercicio01()
        //Implemente a seguinte classe:	
        //Pessoa
        //Atributos: Nome, Telefone, Data de Nascimento, Salário, Quantidade de Filhos, Altura, Peso, Nome do Pai, Nome da Mãe.
        //Escreva um aplicativo de teste onde seja possível cadastrar várias pessoas utilizando a classe mencionada acima.O aplicativo deverá ter os seguintes mecanismos:
        //-	Cadastrar uma nova pessoa
        //-	Listar o nome de todas as pessoas cadastradas
        //OBS: Para os exercícios sobre listas:
        //Refatorar menus com Enum
        //Deixar cada classe com sua responsabilidade
        //Tratar os caminhos não esperados pelo usuário(Um objeto que possa estar nulo)
        //Tratar valores de moedas: Permitir o usuário entrar com o valor que ele usa(100,00) e no seu código tratar esse valores e exibir como moeda brasileira
        {
            int opcao;
            var listPessoa = new List<Pessoa>();

            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------- MENU ------------------------------------ - n");
                Console.WriteLine("1 - Cadastrar nova pessoa");
                Console.WriteLine("2 - Exibir lista de pessoas cadastradas");
                Console.WriteLine("3 - Exibir informações completas");
                Console.WriteLine("0 - Sair");
                Console.Write("\n Digite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                EnumPessoa valorOpcao = (EnumPessoa)opcao;

                switch (valorOpcao)
                {
                    case EnumPessoa.CadastrarPessoa:
                        Console.Clear();
                        Console.Write("Digite o nome da pessoa: ");
                        string nome = (Console.ReadLine());
                        Console.Write("Digite o sobrenome da pessoa: ");
                        string sobrenome = (Console.ReadLine());
                        Console.Write("Digite o CPF da Pessoa: ");
                        string cpf = (Console.ReadLine());
                        Console.Write("Digite a data de nascimento da pessoa: ");
                        DateTime nascimento = DateTime.Parse(Console.ReadLine());
                        Console.Write("Digite o telefone da pessoa: ");
                        string telefone = (Console.ReadLine());
                        Console.Write("Digite o salário da pessoa: ");
                        decimal salario = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Digite a quantidade de filhos da pessoa: ");
                        int qtdFilhos = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a altura da pessoa: ");
                        decimal altura = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Digite o peso da pessoa: ");
                        decimal peso = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Digite o nome do pai da pessoa: ");
                        string nomePai = (Console.ReadLine());
                        Console.Write("Digite o nome da mãe da pessoa: ");
                        string nomeMae = (Console.ReadLine());

                        listPessoa.Add(new Pessoa(nome, sobrenome, cpf, nascimento, telefone, salario, qtdFilhos, altura, peso, nomePai, nomeMae));
                        Console.ReadKey();
                        break;

                    case EnumPessoa.MostrarPessoa:
                        Console.Clear();
                        if (listPessoa.Count == 0)
                        {
                            Console.WriteLine("----- LISTA DE PESSOAS CADASTRADAS -----\n");
                            Console.WriteLine("Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- LISTA DE PESSOAS CADASTRADAS -----\n");

                            foreach (var pessoa in listPessoa)
                            {
                                Console.WriteLine($"Nome: {pessoa.Nome} {pessoa.Sobrenome}");
                            }

                            Console.ReadKey();
                        }
                        break;

                    case EnumPessoa.MostrarListaCompleta:
                        Console.Clear();
                        Console.WriteLine("----- LISTA DE PESSOAS CADASTRADAS -----\n");

                        foreach (var pessoa in listPessoa)
                        {
                            Console.WriteLine($"Nome Completo: {pessoa.Nome}, {pessoa.Sobrenome}");
                            Console.WriteLine($"CPF: {pessoa.CPF}");
                            Console.WriteLine($"Data de nascimento: {pessoa.Nascimento}");
                            Console.WriteLine($"Telefone:,{pessoa.Telefone}");
                            Console.WriteLine($"Salário: {pessoa.Salario}");
                            Console.WriteLine($"Quantidade de filhos: {pessoa.QdtFilhos}");
                            Console.WriteLine($"Altura: {pessoa.Altura}");
                            Console.WriteLine($"Peso: {pessoa.Peso}");
                            Console.WriteLine($"Nome do pai: {pessoa.NomePai}");
                            Console.WriteLine($"Nome da mãe: {pessoa.NomeMae}\n");
                        }
                        Console.ReadKey();
                        break;

                    case EnumPessoa.Sair:
                        Console.Clear();
                        Console.WriteLine("Sair do programa");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }

        private void Exercicio02()
        //Implemente a seguinte classe:	
        //Carro
        //Atributos: Id, Marca, Cor, Ano de Fabricação, Preço, Quantidade de Portas, Kilometragem.
        //Escreva um aplicativo de teste onde seja possível cadastrar vários carros utilizando a classe mencionada acima.O aplicativo deverá ter os seguintes mecanismos:
        //-	Cadastrar um novo carro
        //-	Listar todos os carros cadastrados
        //-	Excluir carro (Pelo ID)
        //OBS: Para os exercícios sobre listas:
        //Refatorar menus com Enum
        //Deixar cada classe com sua responsabilidade
        //Tratar os caminhos não esperados pelo usuário(Um objeto que possa estar nulo)
        //Tratar valores de moedas: Permitir o usuário entrar com o valor que ele usa(100,00) e no seu código tratar esse valores e exibir como moeda brasileira
        {
            int opcao;
            var listCarro = new List<Carro>();

            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------- MENU ------------------------------------");
                Console.WriteLine("1 - Cadastrar novo carro");
                Console.WriteLine("2 - Exibir lista de carros cadastrados");
                Console.WriteLine("3 - Exibir informações completas");
                Console.WriteLine("4 - Excluir carro da lista");
                Console.WriteLine("0 - Sair");
                Console.Write("\n Digite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                EnumCarro valorOpcao = (EnumCarro)opcao;

                switch (valorOpcao)
                {
                    case EnumCarro.CadastrarCarro:
                        Console.Clear();
                        Console.Write("Digite o Id do carro: ");
                        string id = (Console.ReadLine());
                        Console.Write("Digite a marca do carro: ");
                        string marca = (Console.ReadLine());
                        Console.Write("Digite a cor do carro: ");
                        string cor = (Console.ReadLine());
                        Console.Write("Digite a data de fabricação: ");
                        DateTime anoFabricacao = DateTime.Parse(Console.ReadLine());
                        Console.Write("Digite o preco do carro: ");
                        decimal preco = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Digite a quantidade de portas que o carro tem: ");
                        int qtdPortas = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a kilometragem do carro: ");
                        int kilometragem = Convert.ToInt32(Console.ReadLine());

                        listCarro.Add(new Carro(id, marca, cor, anoFabricacao, preco, qtdPortas, kilometragem));
                        Console.ReadKey();
                        break;

                    case EnumCarro.MostrarCarro:
                        Console.Clear();
                        if (listCarro.Count == 0)
                        {
                            Console.WriteLine("----- LISTA DE CARROS CADASTRADOS -----\n");
                            Console.WriteLine("Lista Vazia");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- LISTA DE CARROS CADASTRADOS -----\n");

                            foreach (var carro in listCarro)
                            {
                                Console.WriteLine($"Carro: {carro.Id}");
                            }

                            Console.ReadKey();
                        }
                        break;

                    case EnumCarro.MostrarListaCompleta:
                        Console.Clear();
                        Console.WriteLine("----- LISTA DE CARROS CADASTRADAS -----\n");

                        foreach (var carro in listCarro)
                        {
                            Console.WriteLine($"ID: {carro.Id}");
                            Console.WriteLine($"Marca: {carro.Marca}");
                            Console.WriteLine($"Cor: {carro.Cor}");
                            Console.WriteLine($"Data de fabricação: {carro.AnoFabricacao}");
                            Console.WriteLine($"Preço: {carro.Preco}");
                            Console.WriteLine($"Quantidade de portas: {carro.QtdPortas}");
                            Console.WriteLine($"Kilometragem: {carro.Kilometragem}\n");
                        }
                        Console.ReadKey();
                        break;

                    case EnumCarro.ExcluirCarro:
                        if (listCarro.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Lista Vazia");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Digite o Id do carro a ser removido da lista:");
                            string idInformado = Console.ReadLine();

                            var removerCarro = listCarro.FirstOrDefault(carro => carro.Id == idInformado);
                            listCarro.Remove(removerCarro);

                            Console.ReadKey();

                            Console.WriteLine("----- LISTA DE CARROS CADASTRADAS -----\n");
                            foreach (var carro in listCarro)
                            {
                                Console.WriteLine($"ID: {carro.Id}");
                                Console.WriteLine($"Marca: {carro.Marca}");
                                Console.WriteLine($"Cor: {carro.Cor}");
                                Console.WriteLine($"Data de fabricação: {carro.AnoFabricacao}");
                                Console.WriteLine($"Preço: {carro.Preco}");
                                Console.WriteLine($"Quantidade de portas: {carro.QtdPortas}");
                                Console.WriteLine($"Kilometragem: {carro.Kilometragem}\n");
                            }
                        }
                        Console.ReadKey();
                        break;

                    case EnumCarro.Sair:
                        Console.Clear();
                        Console.WriteLine("Sair do programa");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }
        private void Exercicio03()
        //Implemente a seguinte classe:	
        //Aluno
        //Atributos: Id, Nome, Idade, Nome do Pai, Nome da Mãe, RA, Data de Nascimento.
        //Escreva um aplicativo de teste onde seja possível cadastrar vários alunos utilizando a classe mencionada acima.O aplicativo deverá ter os seguintes mecanismos:
        //- Cadastrar um novo aluno
        //-	Listar todos os alunos cadastrados
        //-	Pesquisar aluno (Pelo ID ou Nome)
        //-	Excluir aluno(Pelo ID ou Nome)
        //-	Alterar nome do aluno(Pesquisa feita para alteração por Id Ou Nome)
        //OBS: Para os exercícios sobre listas:
        //Refatorar menus com Enum
        //Deixar cada classe com sua responsabilidade
        //Tratar os caminhos não esperados pelo usuário(Um objeto que possa estar nulo)
        //Tratar valores de moedas: Permitir o usuário entrar com o valor que ele usa(100,00) e no seu código tratar esse valores e exibir como moeda brasileira

        {
            var listaAlunos = new List<Aluno>();
            int opcao;

            do
            {
                Console.Clear();
                Console.Write("------------------------------------- MENU ------------------------------------ - n" +
                                    "1 - Cadastrar\n" +
                                    "2 - Listar todos\n" +
                                    "3 - Pesquisar aluno (nome ou ID)\n" +
                                    "4 - Excluir aluno (nome ou ID)\n" +
                                    "5 - Alterar nome aluno (nome ou ID)\n" +
                                    "0 - Sair\n" +
                                    "\n Digite a opção desejada: ");

                Console.WriteLine("Escolha a opção");
                opcao = Convert.ToInt32(Console.ReadLine());
                EnumAluno valorOpcao = (EnumAluno)opcao;

                switch (valorOpcao)
                {
                    case EnumAluno.CadastrarAluno:
                        Console.Write("\nEntre com o ID");
                        string id = Console.ReadLine();
                        Console.Write("Entre com o nome");
                        string nome = Console.ReadLine();
                        Console.Write("Entre com a idade");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Entre com o nome do pai");
                        string nomePai = Console.ReadLine();
                        Console.Write("Entre com o nome da mãe");
                        string nomeMae = Console.ReadLine();
                        Console.Write("Entre com o ra");
                        string ra = Console.ReadLine();
                        Console.Write("Entre com a data de nascimento");
                        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("");

                        listaAlunos.Add(new Aluno(id, nome, idade, nomePai, nomeMae, ra, dataNascimento));
                        break;

                    case EnumAluno.MostrarAluno:
                        foreach (var aluno in listaAlunos)
                        {

                            Console.WriteLine($"ID:{aluno.Id} " +
                                              $"Nome:{aluno.Nome} " +
                                              $"Idade:{aluno.Idade} " +
                                              $"Nome Pai:{aluno.NomePai} " +
                                              $"Nome Mãe:{aluno.NomeMae} " +
                                              $"RA:{aluno.Ra} " +
                                              $"Data Nascimento:{aluno.DataNascimento} "
                                              );
                        }
                        Console.WriteLine("");
                        break;

                    case EnumAluno.PesquisarAluno:
                        Console.WriteLine("Insira o id ou nome que deseja pesquisar");
                        string idNomeAluno = Console.ReadLine();

                        var alunoPesquisado = listaAlunos.FirstOrDefault(aluno => aluno.Id == idNomeAluno || aluno.Nome == idNomeAluno);

                        if (alunoPesquisado != null)
                        {
                            Console.WriteLine($"ID:{alunoPesquisado.Id} " +
                                              $"Nome:{alunoPesquisado.Nome} " +
                                              $"Idade:{alunoPesquisado.Idade} " +
                                              $"Nome Pai:{alunoPesquisado.NomePai} " +
                                              $"Nome Mãe:{alunoPesquisado.NomeMae} " +
                                              $"RA:{alunoPesquisado.Ra} " +
                                              $"Data Nascimento:{alunoPesquisado.DataNascimento} "
                                              );
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;

                    case EnumAluno.ExcluirAluno:
                        Console.WriteLine("Insira o id ou nome que quer deletar.");
                        idNomeAluno = Console.ReadLine();
                        var alunoExcluir = listaAlunos.FirstOrDefault(aluno => aluno.Id == idNomeAluno || aluno.Nome == idNomeAluno);
                        if (alunoExcluir != null)
                        {
                            listaAlunos.Remove(alunoExcluir);
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;

                    case EnumAluno.AlterarNomeAluno:
                        Console.WriteLine("Insira o id ou nome do aluno que deseja alterar o nome.");
                        idNomeAluno = Console.ReadLine();
                        var alunoAlterar = listaAlunos.FirstOrDefault(aluno => aluno.Id == idNomeAluno || aluno.Nome == idNomeAluno);
                        if (alunoAlterar != null)
                        {
                            Console.WriteLine("Insira o novo nome do aluno.");
                            alunoAlterar.Nome = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;
                    case EnumAluno.Sair:
                        Console.WriteLine("\nEncerrando o programa");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }

            } while (!(opcao != 0));

        }

        private void Exercicio04()
        //Implemente as seguintes classes:
        //Venda
        //Atributos: Id, Data Venda, Vendedor
        //Item Venda
        //Atributos: Id, Descrição, Quantidade, Preço Unitário
        //Escreva um aplicativo de teste onde seja possível cadastrar várias vendas utilizando a classe mencionada acima.Para cada venda, indique pelo menos um item.
        //O aplicativo deverá ter os seguintes mecanismos:
        //-	Cadastrar um nova venda com os seus respectivos itens
        //-	Listar todas vendas com os seus respectivos itens
        //-	Excluir venda (Pelo ID)
        //-	Excluir item da venda pelo (Pelo ID) - Primeiro informar o ID da Venda e depois o ID do item que será excluído
        //-	Pesquisar venda (Por Data)
        //-	Pesquisar venda (Por Período)
        //-	Pesquisar venda (Por Vendedor)
        //-	Alterar a Quantidade do item - Primeiro informar o ID da Venda e depois o ID do Item
        //OBS: Para os exercícios sobre listas:
        //Refatorar menus com Enum
        //Deixar cada classe com sua responsabilidade
        //Tratar os caminhos não esperados pelo usuário(Um objeto que possa estar nulo)
        //Tratar valores de moedas: Permitir o usuário entrar com o valor que ele usa(100,00) e no seu código tratar esse valores e exibir como moeda brasileira
        {
            var listaVendas = new List<Venda>();

            int opcao;

            do
            {
                Console.WriteLine("Menu\n\n" +
                                  "1 - Cadastrar venda\n" +
                                  "2 - Listar todos\n" +
                                  "3 - Excluir venda (ID)\n" +
                                  "4 - Excluir item de uma venda (IDs)\n" +
                                  "5 - Pesquisar venda (data)\n" +
                                  "6 - Pesquisar venda (período)\n" +
                                  "7 - Pesquisar venda (vendedor)\n" +
                                  "8 - Alterar quantidade do item de uma venda (IDs)\n" +
                                  "0 - Sair\n"
                                  );

                //Console.Clear();
                //listaCarro.Any() ver se tem pelo menos um elemento na lista
                //moedas

                Console.WriteLine("Escolha a opção");
                opcao = Convert.ToInt32(Console.ReadLine());
                EnumVendas valorOpcao = (EnumVendas)opcao;
                switch (valorOpcao)
                {
                    case EnumVendas.CadastrarItem:
                        Console.WriteLine("\nEntre com o ID da venda");
                        string id = Console.ReadLine();
                        Console.WriteLine("Entre com a data de venda");
                        DateTime dataVenda = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Entre com o vendedor");
                        string vendedor = Console.ReadLine();

                        listaVendas.Add(new Venda(id, dataVenda, vendedor));

                        string adicionar = "S";

                        do
                        {
                            Console.WriteLine("\nEntre com o ID do item");
                            string idItem = Console.ReadLine();
                            Console.WriteLine("Entre com a descricao");
                            string descricao = Console.ReadLine();
                            Console.WriteLine("Entre com a quantidade");
                            int quantidade = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Entre com o preço");
                            decimal precoUnitario = Convert.ToDecimal(Console.ReadLine());

                            listaVendas.Last().Itens.Add(new ItemVenda(idItem, descricao, quantidade, precoUnitario));

                            Console.WriteLine("\nDeseja adicionar mais itens? S ou N");
                            adicionar = Console.ReadLine().ToUpper();

                        } while (adicionar == "S");

                        Console.WriteLine("");
                        break;

                    case EnumVendas.MostrarTodasVendas:
                        foreach (var venda in listaVendas)
                        {
                            Console.WriteLine("\n-----------\n");
                            Console.WriteLine($"ID Venda:{venda.Id} " +
                                              $"Data Venda:{venda.DataVenda} " +
                                              $"Vendedor:{venda.Vendedor} "
                                              );
                            foreach (var item in venda.Itens)
                            {
                                Console.WriteLine($"ID Item:{item.Id} " +
                                                  $"Descricao:{item.Descricao} " +
                                                  $"Quantidade:{item.Quantidade} " +
                                                  $"Preço unitário:{item.PrecoUnitario} "
                                                  );

                            }

                            Console.WriteLine("\n-----------\n");
                        }
                        Console.WriteLine("");
                        break;

                    case EnumVendas.ExcluirVenda:
                        Console.WriteLine("Insira o id da venda que quer deletar.");
                        string idVendaExcluir = Console.ReadLine();
                        var vendaExcluir = listaVendas.FirstOrDefault(venda => venda.Id == idVendaExcluir);
                        if (vendaExcluir != null)
                        {
                            listaVendas.Remove(vendaExcluir);
                        }
                        else
                        {
                            Console.WriteLine("Venda não encontrada.");
                        }
                        break;

                    case EnumVendas.ExcluirItemVenda:
                        Console.WriteLine("Insira o id da venda que quer deletar um item.");
                        idVendaExcluir = Console.ReadLine();
                        vendaExcluir = listaVendas.FirstOrDefault(venda => venda.Id == idVendaExcluir);
                        if (vendaExcluir != null)
                        {
                            Console.WriteLine("Insira o id do item que deseja excluir.");
                            string idItemExcluir = Console.ReadLine();
                            var itemExcluir = vendaExcluir.Itens.FirstOrDefault(item => item.Id == idItemExcluir);
                            if (itemExcluir != null)
                            {
                                vendaExcluir.Itens.Remove(itemExcluir);
                            }
                            else
                            {
                                Console.WriteLine("Item não encontrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Venda não encontrada.");
                        }
                        break;

                    case EnumVendas.PesquisarVendaData:
                        Console.WriteLine("Entre com a data que deseja pesquisar");
                        DateTime dataPesquisa = Convert.ToDateTime(Console.ReadLine());
                        var vendasData = listaVendas.Where(venda => venda.DataVenda == dataPesquisa);

                        if (vendasData != null)
                        {
                            foreach (var venda in vendasData)
                            {
                                Console.WriteLine("\n-----------\n");
                                Console.WriteLine($"ID Venda:{venda.Id} " +
                                                  $"Data Venda:{venda.DataVenda} " +
                                                  $"Vendedor:{venda.Vendedor} "
                                                  );
                                foreach (var item in venda.Itens)
                                {
                                    Console.WriteLine($"ID Item:{item.Id} " +
                                                      $"Descricao:{item.Descricao} " +
                                                      $"Quantidade:{item.Quantidade} " +
                                                      $"Preço unitário:{item.PrecoUnitario} "
                                                      );
                                }

                                Console.WriteLine("\n-----------\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Venda não encontrada.");
                        }
                        Console.WriteLine("");
                        break;

                    case EnumVendas.PesquisarVendaPeriodo:
                        Console.WriteLine("Entre com a data inicial que deseja pesquisar");
                        DateTime dataPesquisaInicial = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Entre com a data final que deseja pesquisar");
                        DateTime dataPesquisaFinal = Convert.ToDateTime(Console.ReadLine());
                        vendasData = listaVendas.Where(venda => venda.DataVenda >= dataPesquisaInicial && venda.DataVenda <= dataPesquisaFinal).ToList();


                        if (vendasData != null)
                        {
                            foreach (var venda in vendasData)
                            {
                                Console.WriteLine("\n-----------\n");
                                Console.WriteLine($"ID Venda:{venda.Id} " +
                                                  $"Data Venda:{venda.DataVenda} " +
                                                  $"Vendedor:{venda.Vendedor} "
                                                  );
                                foreach (var item in venda.Itens)
                                {
                                    Console.WriteLine($"ID Item:{item.Id} " +
                                                      $"Descricao:{item.Descricao} " +
                                                      $"Quantidade:{item.Quantidade} " +
                                                      $"Preço unitário:{item.PrecoUnitario} "
                                                      );
                                }

                                Console.WriteLine("\n-----------\n");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Venda não encontrada.");
                        }
                        Console.WriteLine("");
                        break;

                    case EnumVendas.PesquisarVendaVendedor:
                        Console.WriteLine("Entre com o vendedor que deseja pesquisar");
                        string vendedorPesquisa = Console.ReadLine();
                        var vendasVendedor = listaVendas.Where(venda => venda.Vendedor == vendedorPesquisa);

                        if (vendasVendedor != null)
                        {
                            foreach (var venda in vendasVendedor)
                            {
                                Console.WriteLine("\n-----------\n");
                                Console.WriteLine($"ID Venda:{venda.Id} " +
                                                  $"Data Venda:{venda.DataVenda} " +
                                                  $"Vendedor:{venda.Vendedor} "
                                                  );
                                foreach (var item in venda.Itens)
                                {
                                    Console.WriteLine($"ID Item:{item.Id} " +
                                                      $"Descricao:{item.Descricao} " +
                                                      $"Quantidade:{item.Quantidade} " +
                                                      $"Preço unitário:{item.PrecoUnitario} "
                                                      );
                                }

                                Console.WriteLine("\n-----------\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Venda não encontrada.");
                        }
                        Console.WriteLine("");
                        break;

                    case EnumVendas.AlterarQtdItemVenda:
                        Console.WriteLine("Insira o id da venda que quer alterar um item.");
                        string idVendaAlterar = Console.ReadLine();
                        var vendaAlterar = listaVendas.FirstOrDefault(venda => venda.Id == idVendaAlterar);
                        if (vendaAlterar != null)
                        {
                            Console.WriteLine("Insira o id do item que deseja alterar.");
                            string idItemAlterar = Console.ReadLine();
                            var itemAlterar = vendaAlterar.Itens.FirstOrDefault(item => item.Id == idItemAlterar);
                            if (itemAlterar != null)
                            {
                                Console.WriteLine("Entre com a nova quantidade");
                                int novaQuantidade = Convert.ToInt32(Console.ReadLine());
                                itemAlterar.Quantidade = novaQuantidade;
                            }
                            else
                            {
                                Console.WriteLine("Item não encontrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Venda não encontrada.");
                        }
                        break;

                    case EnumVendas.Sair:
                        Console.WriteLine("\nEncerrando o programa");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }

            } while (!(opcao != 0));
        }
        private void Exercicio05()
        //Identifique as classes, atributos e métodos necessários para modelar e implementar:	
        //a) Uma conta    corrente que possui um número, um saldo, um status que informa se ela é especial ou não, um limite e um conjunto de movimentações.
        //b) Uma movimentação que possui uma descrição, um valor e uma informação se ela é uma movimentação de crédito ou débito.
        //c) Um banco  que armazene um conjunto de contas e forneça métodos que permitam que  sejam feitos criações de conta, exclusão de contas,
        //c)saques(uma conta corrente só pode fazer saques desde que o valor não exceda o limite de saque‐limite  + saldo negativo), depósitos,  emissão de saldo e extrato e transferência entre contas.
        //Escreva um aplicativo de teste que demonstra as capacidades das classes.
        //OBS: Para os exercícios sobre listas:
        //Refatorar menus com Enum
        //Deixar cada classe com sua responsabilidade
        //Tratar os caminhos não esperados pelo usuário(Um objeto que possa estar nulo)
        //Tratar valores de moedas: Permitir o usuário entrar com o valor que ele usa(100,00) e no seu código tratar esse valores e exibir como moeda brasileira
        {

        }

    }
}



