using Aula05.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    public class Listas
    {
        public void Execute()
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            Exercicio5();
        }

        public void Exercicio1()
        {
            Pessoa pessoa = new Pessoa();

            var listaPessoas = new List<Pessoa>
            {
                new Pessoa {Nome = "Pessoa A", Telefone="11-11111111", DataNascimento = new DateTime(2001, 01, 01), Salario=1.500m, QuantidadeFilhos=1, Altura=1.74m, Peso=85.1m, NomePai="AAAA", NomeMae="AAAAA"},
                new Pessoa {Nome = "Pessoa B", Telefone="22-22222222", DataNascimento = new DateTime(2002, 02, 02), Salario=1.600m, QuantidadeFilhos=2, Altura=1.86m, Peso=65.3m, NomePai="BBBBB", NomeMae="BBBBB"},
                new Pessoa {Nome = "Pessoa C", Telefone="33-33333333", DataNascimento = new DateTime(2003, 03, 03), Salario=1.700m, QuantidadeFilhos=3, Altura=1.70m, Peso=75.4m, NomePai="CCCCC", NomeMae="CCCCC"},
                new Pessoa {Nome = "Pessoa D", Telefone="44-44444444", DataNascimento = new DateTime(2004, 04, 04), Salario=1.800m, QuantidadeFilhos=4, Altura=1.59m, Peso=68.6m, NomePai="DDDDD", NomeMae="DDDDD"},
                new Pessoa {Nome = "Pessoa E", Telefone="55-55555555", DataNascimento = new DateTime(2005, 05, 05), Salario=1.900m, QuantidadeFilhos=5, Altura=1.87m, Peso=80.7m, NomePai="EEEEE", NomeMae="EEEEE"},
            };




            int x;
            do
            {
                Console.WriteLine("1 - Listar Todas as Pessoas da lista");
                Console.WriteLine("2 - Adicionar uma Nova pessoa na lista");
                Console.WriteLine("3 - Sair ");
                Console.WriteLine("");

                bool result = int.TryParse(Console.ReadLine(), out x);

                switch (x)
                {

                    case 1:
                        {
                            listarTodasAsPessoas();
                            break;
                        }
                    case 2:
                        {
                            adicionarNovaPessoa();
                            break;
                        }
                    default:
                        {
                            if (x == 3)
                            {
                                Console.WriteLine("Thanks for using");
                            }
                            else
                            {
                                Console.WriteLine("Choose a numer from 1 to 3");
                            }
                            break;
                        }
                }
            } while (x != 3);

            void listarTodasAsPessoas()
            {
                Console.WriteLine("Mapeando todas as pessoas da lista");
                foreach (var pessoas in listaPessoas)
                {
                    Console.WriteLine("Nome: " + pessoas.Nome);
                }
            }
            //listarTodasAsPessoas();


            void adicionarNovaPessoa()
            {
                var adicionarNovaPessoa = new List<Pessoa>();

                Console.WriteLine("Nome da pessoa: ");
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Telefone: ");
                pessoa.Telefone = Console.ReadLine();

                Console.WriteLine("Data de Nascimento: ");
                pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Salário: ");
                pessoa.Salario = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de filhos: ");
                pessoa.QuantidadeFilhos = int.Parse(Console.ReadLine());

                Console.WriteLine("Altura: ");
                pessoa.Altura = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Peso: ");
                pessoa.Peso = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Nome do Pai: ");
                pessoa.NomePai = Console.ReadLine();

                Console.WriteLine("Nome do Mãe: ");
                pessoa.NomeMae = Console.ReadLine();


                listaPessoas.Add(new Pessoa
                {
                    Nome = pessoa.Nome,
                    Telefone = pessoa.Telefone,
                    DataNascimento = pessoa.DataNascimento,
                    Salario = pessoa.Salario,
                    QuantidadeFilhos = pessoa.QuantidadeFilhos,
                    Altura = pessoa.Altura,
                    Peso = pessoa.Peso,
                    NomePai = pessoa.NomePai,
                    NomeMae = pessoa.NomeMae,
                });
            }

            //adicionarNovaPessoa();


        }

        public void Exercicio2()
        {
            Carro carro = new Carro();

            var listaCarros = new List<Carro>
            {
                new Carro {ID = "111", Marca="Marca A", Cor = "Cor A", AnoFabricacao = new DateTime(2001, 01, 01), Preco=18.500m, QuantidadePortas=1, Kilometragem=100.174m},
                new Carro {ID = "222", Marca="Marca B", Cor = "Cor B", AnoFabricacao = new DateTime(2002, 02, 02), Preco=19.600m, QuantidadePortas=2, Kilometragem=91.806m},
                new Carro {ID = "333", Marca="Marca C", Cor = "Cor C", AnoFabricacao = new DateTime(2003, 03, 03), Preco=12.700m, QuantidadePortas=3, Kilometragem=81.070m},
                new Carro {ID = "444", Marca="Marca D", Cor = "Cor D", AnoFabricacao = new DateTime(2004, 04, 04), Preco=18.800m, QuantidadePortas=4, Kilometragem=71.509m},
                new Carro {ID = "555", Marca="Marca E", Cor = "Cor E", AnoFabricacao = new DateTime(2005, 05, 05), Preco=17.900m, QuantidadePortas=5, Kilometragem=61.807m},
            };

            int x;
            do
            {
                Console.WriteLine("1 - Listar Todas os Carros da lista");
                Console.WriteLine("2 - Adicionar um novo Carro na lista");
                Console.WriteLine("3 - Excluir um carro pelo ID");
                Console.WriteLine("4 - Sair ");
                Console.WriteLine("");
                Console.WriteLine("_____________________________________________");

                bool result = int.TryParse(Console.ReadLine(), out x);

                switch (x)
                {

                    case 1:
                        {
                            listarTodosOsCarros();
                            break;
                        }
                    case 2:
                        {
                            adicionarUmNovoCarro();
                            break;
                        }
                    case 3:
                            excluirUmCarroPeloId();
                            break;
                    default:
                        {
                            if (x == 4)
                            {
                                Console.WriteLine("Thanks for using");
                            }
                            else
                            {
                                Console.WriteLine("Choose a numer from 1 to 3");
                            }
                            break;
                        }
                }
            } while (x != 4);

            void listarTodosOsCarros()
            {
                Console.WriteLine("Mapeando todos os carros da lista");
                foreach (var carros in listaCarros)
                {
                    Console.WriteLine("Nome: " + carros.Marca);
                }
            }
            //listarTodasAsPessoas();


            void adicionarUmNovoCarro()
            {

                Console.WriteLine("ID: ");
                carro.ID = Console.ReadLine();

                Console.WriteLine("Marca: ");
                carro.Marca = Console.ReadLine();

                Console.WriteLine("Cor: ");
                carro.Cor = Console.ReadLine();

                Console.WriteLine("Ano de Fabricação: ");
                carro.AnoFabricacao = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Preço: ");
                carro.Preco = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de Portas: ");
                carro.QuantidadePortas = int.Parse(Console.ReadLine());

                Console.WriteLine("Kilometragem: ");
                carro.Kilometragem = decimal.Parse(Console.ReadLine());

                listaCarros.Add(new Carro
                {
                    ID = carro.ID,
                    Marca = carro.Marca,
                    Cor = carro.Cor,
                    AnoFabricacao = carro.AnoFabricacao,
                    Preco = carro.Preco,
                    QuantidadePortas = carro.QuantidadePortas,
                    Kilometragem = carro.Kilometragem,
                });
            }

            void excluirUmCarroPeloId()
            {
                Console.WriteLine("Insira o id do carro que quer deletar.");
                string idDelete = Console.ReadLine();

                var deletar = listaCarros.FirstOrDefault(carro => carro.ID == idDelete);

                if (deletar != null)
                {
                    listaCarros.Remove(deletar);
                }
                else
                {
                    Console.WriteLine("Carro não encontrado.");
                }
            }
        }

        public void Exercicio3()
        {
            Aluno aluno = new Aluno();

            var listaAlunos = new List<Aluno>
            {
                new Aluno {ID = "111", Nome="Aluno A", Idade= 12, NomePai="Pai A", NomeMae="Mae A", RA="1111" , DataNascimento = new DateTime(2009, 01, 01)},
                new Aluno {ID = "222", Nome="Aluno B", Idade= 13, NomePai="Pai B", NomeMae="Mae B", RA="2222" , DataNascimento = new DateTime(2008, 02, 02)},
                new Aluno {ID = "333", Nome="Aluno C", Idade= 14, NomePai="Pai C", NomeMae="Mae C", RA="3333" , DataNascimento = new DateTime(2007, 03, 03)},
                new Aluno {ID = "444", Nome="Aluno D", Idade= 15, NomePai="Pai D", NomeMae="Mae D", RA="4444" , DataNascimento = new DateTime(2006, 04, 04)},
                new Aluno {ID = "555", Nome="Aluno E", Idade= 16, NomePai="Pai E", NomeMae="Mae E", RA="5555" , DataNascimento = new DateTime(2005, 05, 05)},
            };

            int x;
            do
            {
                Console.WriteLine("\n_____________________________________________");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastrar um novo aluno");
                Console.WriteLine("2 - Listar todos os alunos");
                Console.WriteLine("3 - Pesquisar aluno (Nome ou ID)");
                Console.WriteLine("4 - Excluir aluno (Nome ou ID)");
                Console.WriteLine("5 - Alterar nome aluno (Nome ou ID)");
                Console.WriteLine("6 - SAIR");
                Console.WriteLine("\n\n_____________________________________________");

                bool result = int.TryParse(Console.ReadLine(), out x);

                switch (x)
                {

                    case 1:
                        {
                            cadastrarUmNovoAluno();
                            break;
                        }
                    case 2:
                        {
                            listarTodosOsAlunos();
                            break;
                        }
                    case 3:
                            pesquisarAluno();
                            break;
                    case 4:
                            excluirAluno();
                            break;
                    case 5:
                            alterarNomeAluno();
                            break;
                    default:
                        {
                            if (x == 6)
                            {
                                Console.WriteLine("Thanks for using");
                            }
                            else
                            {
                                Console.WriteLine("Choose a numer from 1 to 6");
                            }
                            break;
                        }
                }
            } while (x != 6);


            void cadastrarUmNovoAluno()
            {
                //var adicionarNovoCarro = new List<Carro>();
                //Atributos: Id, Nome, Idade, NomePai, NomeMae, RA, DataNascimento.


                Console.WriteLine("ID: ");
                aluno.ID = Console.ReadLine();

                Console.WriteLine("Nome: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Idade: ");
                aluno.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do Pai: ");
                aluno.NomePai = Console.ReadLine();

                Console.WriteLine("Nome da Mãe: ");
                aluno.NomeMae = Console.ReadLine();

                Console.WriteLine("RA: ");
                aluno.RA = Console.ReadLine();

                Console.WriteLine("Data Nascimento: ");
                aluno.DataNascimento = DateTime.Parse(Console.ReadLine());

                listaAlunos.Add(new Aluno
                {
                    ID = aluno.ID,
                    Nome = aluno.Nome,
                    Idade = aluno.Idade,
                    NomePai = aluno.NomePai,
                    NomeMae = aluno.NomeMae,
                    RA = aluno.RA,
                    DataNascimento = aluno.DataNascimento,
                });

               
            }


            void listarTodosOsAlunos() 
            {
                Console.WriteLine("todos os alunos da lista");
                foreach (var alunos in listaAlunos)
                {
                    Console.WriteLine("Nome: " + alunos.Nome);
                }
            }

            void pesquisarAluno() 
            {
                Console.WriteLine("_______Pesquisar aluno pelo (ID ou Nome)______");
                Console.WriteLine("Insira o Nome ou ID do aluno: ");
                string idBusca = Console.ReadLine();

                var alunoEncontrado = listaAlunos.FirstOrDefault(aluno => aluno.ID == idBusca || aluno.Nome == idBusca);

                if(alunoEncontrado != null)
                {        
                    Console.WriteLine("Nome: " + alunoEncontrado.Nome);
                    Console.WriteLine("Idade: " + alunoEncontrado.Idade);
                    Console.WriteLine("Nome Pai: " + alunoEncontrado.NomePai);
                    Console.WriteLine("Nome Mãe: " + alunoEncontrado.NomeMae);
                    Console.WriteLine("RA: " + alunoEncontrado.RA);
                    Console.WriteLine("Data Nascimento: " + alunoEncontrado.DataNascimento);
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado");
                }
            }

            void excluirAluno() 
            {
                Console.WriteLine("_______( Excluir aluno pelo ( ID ou Nome ))_______");
                Console.WriteLine("Insira o Nome ou ID do aluno: ");
                string idBusca = Console.ReadLine();

                var alunoEncontrado = listaAlunos.FirstOrDefault(aluno => aluno.ID == idBusca || aluno.Nome == idBusca);

                if(alunoEncontrado != null)
                {
                    listaAlunos.Remove(alunoEncontrado);
                    Console.WriteLine("O Aluno exluido foi: " + alunoEncontrado.Nome);
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado");
                }
            }

            void alterarNomeAluno()
            {
                Console.WriteLine("___________(Alterar nome do aluno pelo (ID ou Nome) )___________");
                Console.WriteLine("Insira o Nome ou ID do aluno: ");
                string idBusca = Console.ReadLine();

                var alunoEncontrado = listaAlunos.FirstOrDefault(aluno => aluno.ID == idBusca || aluno.Nome == idBusca);
                
                if(alunoEncontrado != null)
                {
                    Console.WriteLine("Informe o novo nome: ");
                    string novoNome = Console.ReadLine();

                    alunoEncontrado.Nome = novoNome;
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado");
                }
            }
        }

        public void Exercicio4()
        {
            var listaVendas = new List<Venda>();

            int x;
            do
            {
                Console.WriteLine("\n_____________________________________________");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastrar venda");
                Console.WriteLine("2 - Listar Todas as vendas");
                Console.WriteLine("3 - Excluir venda pelo ID");
                Console.WriteLine("4 - Excluir item de uma venda (ID)");
                Console.WriteLine("5 - Pesquisar venda 'data'");
                Console.WriteLine("6 - Pesquisar venda 'periodo'");
                Console.WriteLine("7 - Pesquisar venda 'vendedor'");
                Console.WriteLine("8 - Alterar quantidade do item de uma venda pelo (ID)");
                Console.WriteLine("9 - SAIR");
                Console.WriteLine("\n\n_____________________________________________");

                bool result = int.TryParse(Console.ReadLine(), out x);

                switch (x)
                {

                    case 1:
                        {
                            cadastrarVenda();
                            break;
                        }
                    case 2:
                        {
                            listarTodasAsVendas();
                            break;
                        }
                    case 3:
                        excluirVenda();
                        break;
                    case 4:
                        excluirItemDeUmaVenda();
                        break;
                    case 5:
                        pesquisarVendaPorData();
                        break;
                    case 6:
                        pesquisarVendaPeriodo();
                        break;
                    case 7:
                        pesquisarVendaPorVendedor();
                        break;
                    case 8:
                        alterarQuantidadeDeItemPeloId();
                        break;
                    default:
                        {
                            if (x == 9)
                            {
                                Console.WriteLine("Thanks for using");
                            }
                            else
                            {
                                Console.WriteLine("Choose a numer from 1 to 9");
                            }
                            break;
                        }
                }
            } while (x != 9);


            void cadastrarVenda()
            {
                Console.WriteLine("Informe o ID da venda: ");
                string id = Console.ReadLine();

                Console.WriteLine("Informe a data da venda: ");
                DateTime dataVenda = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Infrome o vendedor: ");
                string vendedor = Console.ReadLine();

                listaVendas.Add(new Venda(id, dataVenda, vendedor));

                string adicionar = "S";

                do
                {
                    Console.WriteLine("Informe o ID do item: ");
                    string idItem = Console.ReadLine();

                    Console.WriteLine("Informe a descrição");
                    string descricao = Console.ReadLine();

                    Console.WriteLine("Informe a quantidade: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Entre com o preço: ");
                    decimal precoUnitario = decimal.Parse(Console.ReadLine());

                    listaVendas.Last().Itens.Add(new ItemVenda(id, descricao, quantidade, precoUnitario));

                    Console.WriteLine("Deseja adicionar mais itens a venda ? S ou N");
                    adicionar = Console.ReadLine().ToUpper();
                } while (adicionar == "S");
            }


            void listarTodasAsVendas() 
            {
                foreach(var venda in listaVendas)
                {
                    Console.WriteLine("________________( Detalhes da Venda )________________");
                    Console.WriteLine($"ID Venda: {venda.ID}");
                    Console.WriteLine($"Data da Venda: {venda.DataVenda}");
                    Console.WriteLine($"Vendedor: {venda.Vendedor}");

                    foreach(var item in venda.Itens)
                    {
                        Console.WriteLine($"ID Item: {item.ID}");
                        Console.WriteLine($"Descrição do Item: {item.Descricao}");
                        Console.WriteLine($"Quantidade do Item: {item.Quantidade}");
                        Console.WriteLine($"Preço unitário: {item.PrecoUnitario}");
                    }
                    Console.WriteLine("________________________________________________");
                }
            }

            
            void excluirVenda() 
            {
                Console.WriteLine("Informe o ID da venda que será deletada: ");
                string idVendaDelete = Console.ReadLine();

                var vendaExluida = listaVendas.FirstOrDefault(venda => venda.ID == idVendaDelete);

                if(vendaExluida != null)
                {
                    listaVendas.Remove(vendaExluida);
                }
                else
                {
                    Console.WriteLine("Venda não encontrada.");
                }
            }

            
            void excluirItemDeUmaVenda() 
            {
                Console.WriteLine("Informe o id da venda para deletar um item: ");
                string idVendaDelete = Console.ReadLine();

                var vendaDeleteItem = listaVendas.FirstOrDefault(venda => venda.ID == idVendaDelete);

                if(vendaDeleteItem != null)
                {
                    Console.WriteLine("Informe o id do item que deseja excluir: ");
                    string idItemDelete = Console.ReadLine();

                    var itemDeleteSelect = vendaDeleteItem.Itens.FirstOrDefault(item => item.ID == idItemDelete);
                    if(itemDeleteSelect != null)
                    {
                        vendaDeleteItem.Itens.Remove(itemDeleteSelect);
                    }
                    else
                    {
                        Console.WriteLine("Item não encontrado !");
                    }
                }
                else
                {
                    Console.WriteLine("Venda não encontrada !");
                }
            }
            
            
            void pesquisarVendaPorData() 
            {
                Console.WriteLine("Informe a data que deseja pesquisar: ");
                DateTime dataInformada = DateTime.Parse(Console.ReadLine());

                var vendasData = listaVendas.Where(venda => venda.DataVenda == dataInformada);

                if(vendasData != null)
                {
                    foreach(var venda in vendasData)
                    {
                        Console.WriteLine("_______________________________________________");
                        Console.WriteLine($"ID Venda: {venda.ID}");
                        Console.WriteLine($"Data Venda: {venda.DataVenda}");
                        Console.WriteLine($"Vendedor: {venda.Vendedor}");

                        foreach(var item in venda.Itens)
                        {
                            Console.WriteLine($"ID Item: {item.ID}");
                            Console.WriteLine($"Descrição: {item.Descricao}");
                            Console.WriteLine($"Quantidade: {item.Quantidade}");
                            Console.WriteLine($"Preço unitário: {item.PrecoUnitario}");
                        }
                        Console.WriteLine("_______________________________________________");
                    }
                }
                else
                {
                    Console.WriteLine("Venda não encontrada !");
                }
            }
            
            
            void pesquisarVendaPeriodo() 
            {
                Console.WriteLine("Informe a data inicial: ");
                DateTime dataInicio = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Informe a data final: ");
                DateTime dataFinal = DateTime.Parse(Console.ReadLine());

                var vendasPeriodo = listaVendas.Where(venda => venda.DataVenda >= dataInicio && venda.DataVenda <= dataFinal).ToList();
            
                if (vendasPeriodo != null)
                {
                    foreach(var venda in vendasPeriodo)
                    {
                        Console.WriteLine("_________________________________________________________");
                        Console.WriteLine($"ID Venda: {venda.ID}");
                        Console.WriteLine($"Data Venda: {venda.DataVenda}");
                        Console.WriteLine($"Vendedor: {venda.Vendedor}");
                        foreach(var item in venda.Itens)
                        {
                            Console.WriteLine($"ID Item: {item.ID}");
                            Console.WriteLine($"Descrição: {item.Descricao}");
                            Console.WriteLine($"Quantidade: {item.Quantidade}");
                            Console.WriteLine($"Preço unitário: {item.PrecoUnitario}");
                        }
                        Console.WriteLine("_________________________________________________________");
                    }
                }
                else
                {
                    Console.WriteLine("Venda não encontrada !");
                }
            }
            
            
            void pesquisarVendaPorVendedor() 
            {
                Console.WriteLine("Informe o vendedor: ");
                string vendedorInformado = Console.ReadLine();

                var vendedorVendas = listaVendas.Where(venda => venda.Vendedor == vendedorInformado);

                if(vendedorVendas != null)
                {
                    foreach(var venda in vendedorVendas)
                    {
                        Console.WriteLine("______________________________________________");
                        Console.WriteLine($"ID Venda: {venda.ID}");
                        Console.WriteLine($"Data Venda: {venda.DataVenda}");
                        Console.WriteLine($"Vendedor: {venda.Vendedor}");
                        foreach(var item in venda.Itens)
                        {
                            Console.WriteLine($"ID Item: {item.ID}");
                            Console.WriteLine($"Descrição: {item.Descricao}");
                            Console.WriteLine($"Quantidade: {item.Quantidade}");
                            Console.WriteLine($"Preço unitário: {item.PrecoUnitario}");
                        }
                    }
                }else
                {
                    Console.WriteLine("Venda não encontrada !");
                }

            }
            

            void alterarQuantidadeDeItemPeloId() 
            {
                Console.WriteLine("Informe o id da venda que quer alterar a quantidade de um item: ");
                string idVendaSelected = Console.ReadLine();

                var vendaSelectedFind = listaVendas.FirstOrDefault(venda => venda.ID == idVendaSelected);

                if(vendaSelectedFind != null)
                {
                    Console.WriteLine("Informe o ID do Item para a alteração: ");
                    string idItemSelected = Console.ReadLine();

                    var itemSelected = vendaSelectedFind.Itens.FirstOrDefault(item => item.ID == idItemSelected);
                    if(itemSelected != null)
                    {
                        Console.WriteLine("Informe a nova quantidade: ");
                        int novaQuantidade = int.Parse(Console.ReadLine());
                        itemSelected.Quantidade = novaQuantidade;
                    }
                    else
                    {
                        Console.WriteLine("Item não encontrado !");
                    }
                }
                else
                {
                    Console.WriteLine("Venda não encontrada !");
                }
            }
        }

        public void Exercicio5()
        {
            Banco banco = new Banco();
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("Escolha uma da opções abaixo:");
                Console.WriteLine("1 -  Cadastrar Conta");
                Console.WriteLine("2 -  Excluir Conta");
                Console.WriteLine("3 -  Saque");
                Console.WriteLine("4 -  Depósito");
                Console.WriteLine("5 -  Saldo");
                Console.WriteLine("6 -  Extrato");
                Console.WriteLine("7 -  Transferência");
                Console.WriteLine("8 -  SAIR");
                Console.WriteLine("\n_________________________________________");
                EnumExer05 menu;
                string f = Console.ReadLine();
                Enum.TryParse<EnumExer05>(f, out menu);
                switch (menu)
                {
                    case EnumExer05.Cadastrar:
                        banco.CadastrarConta();
                        break;
                    case EnumExer05.Excluir:
                        banco.ExcluirConta();
                        break;
                    case EnumExer05.Saque:
                        banco.Saque();
                        break;
                    case EnumExer05.Deposito:
                        banco.Deposito();
                        break;
                    case EnumExer05.Saldo:
                        banco.Saldo();
                        break;
                    case EnumExer05.Extrato:
                        banco.EmitirExtrato();
                        break;
                    case EnumExer05.Transferencia:
                        banco.Transferencia();
                        break;
                    case EnumExer05.Sair:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
