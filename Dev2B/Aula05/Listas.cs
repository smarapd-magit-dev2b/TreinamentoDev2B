using Aula05.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula05
{
    public class Listas
    {
        public void Execute()
        {
            //ExExemplo();
            //Ex1();
            //Ex2();
            //Ex3();
            Ex4();
        }

        static void ExExemplo()
        {
            var listaPessoa = new List<Pessoa>
            {
                new Pessoa
                {
                    Nome="Amanda",
                    Sobrenome="Jaria",
                    DataNascimento=new DateTime(1992,06,24),
                    Cpf="333.079.758-46"
                },

                 new Pessoa
                {
                    Nome="Sally",
                    Sobrenome="Gallagher",
                    DataNascimento=new DateTime(2017,03,06),
                    Cpf="123.456.789-10"
                },

                  new Pessoa
                {
                    Nome="Bete",
                    Sobrenome="Jaria",
                    DataNascimento=new DateTime(1964,03,06),
                    Cpf="123.456.789-10"
                },

                   new Pessoa
                {
                    Nome="Polly",
                    Sobrenome="Gallagher",
                    DataNascimento=new DateTime(2020,04,10),
                    Cpf="123.456.789-10"
                }
            };

            foreach (Pessoa pessoa in listaPessoa)
            {
                //pode fazer o override do tostring aí o console writeline(pessoa) mostra tudo MAS NÃO É COMUM ISSO
                // EQUALS COMPARA POR REFERENCIA (POSIÇÃO DA MEMÓRIA), NÃO POR VALOR, MAS PODE FAZER OVERRIDE PARA SER POR VALOR
                // CTRL K D PARA IDENTAR

                Console.WriteLine($"O nome é  {pessoa.Nome}");
                Console.WriteLine("O sobrenome é " + pessoa.Sobrenome);
                Console.WriteLine("A data de nascimento é " + pessoa.DataNascimento.ToString("dd/MM/yyyy"));
                Console.WriteLine("O cpf é " + pessoa.Cpf);
            }


            //EXEMPLOS AULA MURILO
            //Console.WriteLine("\n\nPessoas com nome Murilo.");
            //foreach (var pessoa in pessoas)
            //{
            //    if (pessoa.Nome == "Murilo")
            //    {
            //        Console.WriteLine(pessoa);
            //    }
            //}

            //Console.WriteLine("\n\nPessoas com nome Murilo usando LINQ.");
            //var pessoasComNomeMuriloComLinq = from pessoa in pessoas
            //                                  where pessoa.Nome == "Murilo" && pessoa.Sobrenome == "Gomes"
            //                                  select pessoa;
            //foreach (var pessoa in pessoasComNomeMuriloComLinq)
            //{
            //    Console.WriteLine(pessoa);
            //}

            //Console.WriteLine("\n\nPessoas com nome Murilo usando Lambda.");
            //var pessoaComNomeMuriloComLambda = pessoas.Where(pessoa => pessoa.Nome == "Murilo" && pessoa.Sobrenome == "Gomes");
            //foreach (var pessoa in pessoaComNomeMuriloComLambda)
            //{
            //    Console.WriteLine(pessoa);
            //}

            //Console.WriteLine("\n\nPrimeira pessoa com nome Murilo usando Lambda.");
            //var primeiraPessoaComNomeMuriloComLambda = pessoas.FirstOrDefault(pessoa => pessoa.Nome == "Murilo" && pessoa.Sobrenome == "Gomes");
            //if (primeiraPessoaComNomeMuriloComLambda != null)
            //{
            //    Console.WriteLine(primeiraPessoaComNomeMuriloComLambda);
            //    //pessoas.Remove(primeiraPessoaComNomeMuriloComLambda);
            //    primeiraPessoaComNomeMuriloComLambda.Nome = "Murilo Amarú ";
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa não encontrada.");
            //}

            var pessoasMaioresDe18Anos = listaPessoa.Where(pessoa => new DateTime((DateTime.Now - pessoa.DataNascimento).Ticks).Year >= 18);
            foreach (var pessoa in pessoasMaioresDe18Anos)
            {
                pessoa.Sobrenome += " (maior de idade)";
            }

            Console.WriteLine("\n\nPessoas com sobrenome ajustado");
            foreach (var pessoa in listaPessoa)
            {
                Console.WriteLine($"O nome é  {pessoa.Nome} {pessoa.Sobrenome}");                
            }

        }

        static void Ex1()
        {
            
            var listaPessoa = new List<PessoaCadastrada>();

            string opcao = "";

            do
            {
                Console.WriteLine("Menu\n\n" +
                                  "1 - Cadastrar\n" +
                                  "2 - Listar nomes\n" +
                                  "0 - Sair\n"
                                  );

                Console.WriteLine("Escolha a opção");
                opcao = Console.ReadLine();

                switch (opcao)
                {                    
                    case "1":
                        Console.WriteLine("\nEntre com o nome");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Entre com o telefone");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Entre com a data de nascimento");
                        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Entre com o salario");
                        decimal salario = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Entre com a quantidade de filhos");
                        int quantidadeFilhos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entre com a altura");
                        decimal altura = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Entre com o peso");
                        decimal peso = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Entre com o nome do pai");
                        string nomePai = Console.ReadLine();
                        Console.WriteLine("Entre com o nome da mãe");
                        string nomeMae = Console.ReadLine();
                        Console.WriteLine("");
                        listaPessoa.Add(new PessoaCadastrada(nome, telefone, dataNascimento, salario, quantidadeFilhos, altura, peso, nomePai, nomeMae));
                        break;
                    case "2":
                        foreach (var pessoa in listaPessoa)
                        {
                            Console.WriteLine($"Nome: {pessoa.Nome}");
                        }
                        Console.WriteLine("");
                        break;
                    case "0":
                        Console.WriteLine("\nEncerrando o programa");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }

            } while (!(opcao == "0"));

        }

        static void Ex2()
        {
            var listaCarros = new List<Carro>();

            string opcao = "";            

            do
            {
                Console.WriteLine("Menu\n\n" +
                                  "1 - Cadastrar\n" +
                                  "2 - Listar todos os carros\n" +
                                  "3 - Excluir carro pelo ID\n" +
                                  "0 - Sair\n"
                                  );

                Console.WriteLine("Escolha a opção");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nEntre com o ID");
                        string id = Console.ReadLine();
                        Console.WriteLine("Entre com a marca");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Entre com a cor");
                        string cor = Console.ReadLine();
                        Console.WriteLine("Entre com o ano de fabricação");
                        int anoFabricacao = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entre com o preco");
                        decimal preco = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Entre com a quantidade de portas");
                        int quantidadePortas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entre com a quilometragem");
                        decimal quilometragem = Convert.ToDecimal(Console.ReadLine());                        
                        Console.WriteLine("");
                        listaCarros.Add(new Carro(id,marca,cor,anoFabricacao,preco,quantidadePortas,quilometragem));
                        break;

                    case "2":
                        foreach (var carro in listaCarros)
                        {
                            Console.WriteLine($"ID:{carro.Id} " +
                                              $"Marca:{carro.Marca} " +
                                              $"Cor:{carro.Cor} " +
                                              $"Ano:{carro.AnoFabricacao} " +
                                              $"Preço:{carro.Preco} " +
                                              $"Quantidade Portas:{carro.QuantidadePortas} " +
                                              $"Quilometragem:{carro.Quilometragem} "
                                              );
                        }
                        Console.WriteLine("");
                        break;

                    case "3":
                        Console.WriteLine("Insira o id do carro que quer deletar.");
                        string idDeletar = Console.ReadLine();
                        
                        var deletar = listaCarros.FirstOrDefault(carro => carro.Id == idDeletar);                        

                        if (deletar != null)
                        {
                            listaCarros.Remove(deletar);
                        }
                        else
                        {
                            Console.WriteLine("Carro não encontrado.");
                        }
                        break;

                    case "0":
                        Console.WriteLine("\nEncerrando o programa");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }

            } while (!(opcao == "0"));

        }

        static void Ex3()
        {
            var listaAlunos = new List<Aluno>();

            string opcao = "";

            do
            {
                Console.WriteLine("Menu\n\n" +
                                  "1 - Cadastrar\n" +
                                  "2 - Listar todos\n" +
                                  "3 - Pesquisar aluno (nome ou ID)\n" +
                                  "4 - Excluir aluno (nome ou ID)\n" +
                                  "5 - Alterar nome aluno (nome ou ID)\n" +
                                  "0 - Sair\n"
                                  );

                Console.WriteLine("Escolha a opção");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nEntre com o ID");
                        string id = Console.ReadLine();
                        Console.WriteLine("Entre com o nome");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Entre com a idade");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entre com o nome do pai");
                        string nomePai = Console.ReadLine();
                        Console.WriteLine("Entre com o nome da mãe");
                        string nomeMae = Console.ReadLine();
                        Console.WriteLine("Entre com o ra");
                        string ra = Console.ReadLine();
                        Console.WriteLine("Entre com a data de nascimento");
                        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());                       
                        Console.WriteLine("");

                        listaAlunos.Add(new Aluno(id, nome, idade, nomePai, nomeMae, ra,dataNascimento));
                        break;

                    case "2":
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

                    case "3":
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

                    case "4":
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

                    case "5":
                        Console.WriteLine("Insira o id ou nome do aluno que deseja alterar o nome.");
                        idNomeAluno = Console.ReadLine();
                        var alunoAlterar = listaAlunos.FirstOrDefault(aluno => aluno.Id == idNomeAluno || aluno.Nome == idNomeAluno);
                        if (alunoAlterar != null)
                        {
                            Console.WriteLine("Insira o novo nome do aluno.");
                            alunoAlterar.Nome=Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado.");
                        }
                        break;
                    case "0":
                        Console.WriteLine("\nEncerrando o programa");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }

            } while (!(opcao == "0"));

        }

        static void Ex4()
        {
            var listaVendas = new List<Venda>();

            string opcao = "";

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

                Console.WriteLine("Escolha a opção");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
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

                        } while (adicionar=="S");  
                        
                        Console.WriteLine("");                      
                        break;

                    case "2":
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

                    case "3":
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

                    case "4":
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

                    case "5":
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

                    case "6":
                        Console.WriteLine("Entre com a data inicial que deseja pesquisar");
                        DateTime dataPesquisaInicial = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Entre com a data final que deseja pesquisar");
                        DateTime dataPesquisaFinal = Convert.ToDateTime(Console.ReadLine());
                        vendasData = listaVendas.Where(venda => venda.DataVenda >= dataPesquisaInicial && venda.DataVenda<=dataPesquisaFinal);


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

                    case "7":
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

                    case "8":
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
                                itemAlterar.Quantidade=novaQuantidade;
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

                    case "0":
                        Console.WriteLine("\nEncerrando o programa");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }

            } while (!(opcao == "0"));

        }
    }
}
