using Aula4.ClassesExe01;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Aula4.Classes.ClassesExe02;
using Aula4.Classes.ClassesExe04;
using Aula4.Classes.ClassesExe05;

namespace Aula4 {
    public class ExercicioAula04 {
        public void Executar() {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
        }
        private void Exercicio01() {
            bool rodando = true;
            var pessoas = new List<Pessoa>();
            while (rodando) {
                Console.Clear();
                Console.WriteLine("[1] - Cadastrar novas pessoas\n" +
                                  "[2] - Listar pessoas cadastrada\n" +
                                  "[3] - Sair");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        var telefone = Console.ReadLine();
                        Console.Write("Data de nascimento: ");
                        var datanascimento = DateTime.Parse(Console.ReadLine());
                        Console.Write("Salário: ");
                        var salario = decimal.Parse(Console.ReadLine());
                        Console.Write("Quantidade de filhos: ");
                        var qntfilhos = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        var altura = decimal.Parse(Console.ReadLine());
                        Console.Write("Peso: ");
                        var peso = decimal.Parse(Console.ReadLine());
                        Console.Write("Nome do Pai: ");
                        var nomepai = Console.ReadLine();
                        Console.Write("Nome da Mãe: ");
                        var nomemae = Console.ReadLine();


                        pessoas.Add(new Pessoa {
                            Nome = nome,
                            Telefone = telefone,
                            DataNascimento = datanascimento,
                            Salario = salario,
                            QntFilhos = qntfilhos,
                            Altura = altura,
                            Peso = peso,
                            NomePai = nomepai,
                            NomeMae = nomemae
                        });

                        break;
                    case 2:
                        Console.WriteLine("AAAAA");
                        foreach (var dados in pessoas) {
                            Console.WriteLine(dados);
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Saindo...");
                        rodando = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida...");
                        break;
                }
            }































            //var pessoa = new List<Pessoa>{
            //   new Pessoa {
            //       Nome = "Bruno",
            //       Sobrenome = "Camargo",
            //       Nascimento = new DateTime(1998, 10, 15)
            //   },

            //    new Pessoa {
            //        Nome = "Bruno",
            //        Sobrenome = "Camargo",
            //        Nascimento = new DateTime(1998, 10, 15)

            //    },

            //   new Pessoa {
            //       Nome = "Bruno",
            //       Sobrenome = "Camargo",
            //       Nascimento = new DateTime(1998, 10, 15)
            //   }
            //};
            //foreach (var item in pessoa) {
            //    Console.WriteLine("Nome :" + item.Nome);
            //    Console.WriteLine("Sobrenome :" + item.Sobrenome);
            //}

            //Console.WriteLine("Pessoas Maiores de idade...");
            //var maioresdeidade = pessoa.Where(pessoa => (DateTime.Now) pessoa.Nascimento.Subtract(1998, 10, 15) > DateTime.Now);

            //if(maioresdeidade != null) {
            //    Console.WriteLine(pessoa);
            //}
            //else {
            //    Console.WriteLine("Pessoa não encontrada !!");
            //}
        }
        private void Exercicio02() {
            List<Carro> carros = new List<Carro>();
            bool rodando = true;
            while (rodando) {
                Console.Clear();
                Console.WriteLine("[1] - Cadastrar carro novo\n" +
                                  "[2] - Listar carro cadastrado\n" +
                                  "[3] - Excluir carro cadastrado\n" +
                                  "[4] - Sair");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.Write("ID: ");
                        var id = int.Parse(Console.ReadLine());

                        Console.Write("Marca: ");
                        var marca = Console.ReadLine();

                        Console.Write("Cor: ");
                        var cor = Console.ReadLine();

                        Console.Write("Ano de Fabricação: ");
                        var anofabricacao = DateTime.Parse(Console.ReadLine());

                        Console.Write("Preço: ");
                        var preco = decimal.Parse(Console.ReadLine());

                        Console.Write("Qnt de portas: ");
                        var qntportas = int.Parse(Console.ReadLine());

                        Console.Write("Kilometragem: ");
                        var km = int.Parse(Console.ReadLine());


                        carros.Add(new Carro {
                            ID = id,
                            Marca = marca,
                            Cor = cor,
                            AnoFabricacao = anofabricacao,
                            Preco = preco,
                            QtdPortas = qntportas,
                            Kilometragem = km,
                        });
                        break;
                    case 2:
                        foreach (var dados in carros) {
                            Console.WriteLine(dados);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Digite o ID do carro: ");
                        var idexcluir = int.Parse(Console.ReadLine());

                        var RemoveCarro = carros.Where(x => x.ID == idexcluir).FirstOrDefault();
                        carros.Remove(RemoveCarro);
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        rodando = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida....");
                        break;
                }

            }
        }
        private void Exercicio03() {
            List<Aluno> alunos = new List<Aluno>();
            bool rodando = true;
            while (rodando) {
                Console.Clear();
                Console.WriteLine("[1] - Cadastrar novo aluno\n" +
                                  "[2] - Listar alunos cadastrado\n" +
                                  "[3] - Excluir alunos cadastrado\n" +
                                  "[4] - Alterar nome do aluno\n" +
                                  "[5] - Pesquisar aluno no banco de dados\n" +
                                  "[6] - Sair");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.Write("ID: ");
                        var id = Console.ReadLine();

                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();

                        Console.Write("RA: ");
                        var ra = int.Parse(Console.ReadLine());

                        Console.Write("Data de nascimento: ");
                        var datanascimento = DateTime.Parse(Console.ReadLine());

                        Console.Write("Nome do Pai: ");
                        var nomepai = Console.ReadLine();

                        Console.Write("Nome da Mãe: ");
                        var nomemae = Console.ReadLine();

                        alunos.Add(new Aluno {
                            ID = id,
                            Nome = nome,
                            RA = ra,
                            DataNascimento = datanascimento,
                            NomePai = nomepai,
                            NomeMae = nomemae

                        });
                        break;

                    case 2:
                        foreach (var dados in alunos) {
                            Console.WriteLine(dados);
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Digite o ID ou nome do aluno: ");
                        var idexcluir = Console.ReadLine();

                        var RemoveAluno = alunos.Where(x => x.ID == idexcluir || x.Nome == idexcluir).FirstOrDefault();
                        alunos.Remove(RemoveAluno);
                        break;

                    case 4:
                        Console.Write("Digite o nome do aluno que deseja alterar: ");
                        var alterarnome = Console.ReadLine();

                        var TrocarNome = alunos.Where(x => x.Nome == alterarnome || x.ID == alterarnome).FirstOrDefault();

                        Console.Write("Digite o novo nome: ");
                        var novonome = Console.ReadLine();

                        if (TrocarNome != null) {
                            alunos.Remove(TrocarNome);
                            TrocarNome.Nome = novonome;
                            alunos.Add(TrocarNome);
                        }
                        else
                            Console.WriteLine("Aluno não encontrado....");
                        break;

                    case 5:
                        Console.Write("Digite o nome do aluno: ");
                        var mostrarlista = Console.ReadLine();
                        var mostrar = alunos.Where(x => x.Nome == mostrarlista || x.ID == mostrarlista).FirstOrDefault();

                        Console.WriteLine(mostrar.ToString());
                        break;

                    case 6:
                        Console.WriteLine("Saindo...");
                        rodando = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida....");
                        break;
                }
            }
        }
        private void Exercicio04() {
            List<Venda> venda = new List<Venda>();
            bool rodando = true;

            while (rodando) {
                Console.Clear();
                Console.WriteLine("[1] - Cadastrar nova venda\n" +
                                  "[2] - Listar vendas\n" +
                                  "[3] - Excluir venda\n" +
                                  "[4] - Excluir item da venda\n" +
                                  "[5] - Pesquisar venda\n" +
                                  "[6] - Alterar quantidade de itens\n" +
                                  "[7] - Sair");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.WriteLine("REGISTRO DO VENDEDOR");

                        Console.Write("ID: ");
                        var id = int.Parse(Console.ReadLine());

                        Console.Write("Data da venda: ");
                        var datavenda = DateTime.Parse(Console.ReadLine());

                        Console.Write("Vendedor: ");
                        var vendedor = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("REGISTRO DO PRODUTO");

                        Console.Write("ID: ");
                        var idvendas = int.Parse(Console.ReadLine());

                        Console.Write("Descrição: ");
                        var descricao = Console.ReadLine();

                        Console.Write("Quantidade: ");
                        var quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Preço: ");
                        var preco = decimal.Parse(Console.ReadLine());

                        var a = new Venda {
                            ID = id,
                            DataVenda = datavenda,
                            Vendedor = vendedor,
                        };

                        var iv = new ItemVenda {
                            IDproduto = idvendas,
                            Descricao = descricao,
                            Quantidade = quantidade,
                            Preco = preco
                        };
                        a.Itens.Add(iv);
                        venda.Add(a);
                        break;
                    case 2:
                        foreach (var item in venda) {
                            Console.WriteLine("---VENDA---");
                            Console.WriteLine($"ID VENDA: {item.ID}");
                            Console.WriteLine($"Vendedor: {item.Vendedor}");
                            Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                            Console.WriteLine($"Item da venda");
                            foreach (var itemV in item.Itens) {
                                Console.WriteLine("---PRODUTO---");
                                Console.WriteLine($"ID: {itemV.IDproduto}");
                                Console.WriteLine($"Descricao: {itemV.Descricao}");
                                Console.WriteLine($"Preço: {itemV.Preco}");
                                Console.WriteLine($"Quantidade: {itemV.Quantidade}\n");
                            }
                            Console.WriteLine("");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Digite o ID da venda: ");
                        var idvendaa = int.Parse(Console.ReadLine());

                        var idexlusao = venda.FirstOrDefault(x => x.ID == idvendaa);
                        if (idexlusao != null)
                            venda.Remove(idexlusao);
                        else
                            Console.WriteLine("ID não encontrado....");
                        break;

                    case 4:
                        Console.WriteLine("ID da venda:");
                        var idvenda = int.Parse(Console.ReadLine());
                        var itemvenda = venda.FirstOrDefault(x => x.ID == idvenda);
                        Console.WriteLine("ID da Item venda:");
                        var idvendaItem = int.Parse(Console.ReadLine());
                        var itemVendaExclusao = itemvenda.Itens.FirstOrDefault(x => x.IDproduto == idvendaItem);

                        if (itemvenda != null) {
                            itemvenda.Itens.Remove(itemVendaExclusao);
                        }
                        else
                            Console.WriteLine("Produto não encontrado...");
                        break;
                    case 5:
                        bool rodando2 = true;
                        while (rodando2) {
                            Console.WriteLine("[1] - Pesquisar por data\n" +
                                              "[2] - Pesquisar por periodo\n" +
                                              "[3] - Pesquisar por vendedor\n" +
                                              "[4] - Sair");
                            opcao = int.Parse(Console.ReadLine());

                            switch (opcao) {
                                case 1:
                                    Console.Write("Digite a data da venda: ");
                                    var datadavenda = DateTime.Parse(Console.ReadLine());

                                    var datapesquisa = venda.Where(x => x.DataVenda == datadavenda);

                                    if (datapesquisa != null) {
                                        foreach (var item in datapesquisa) {
                                            Console.WriteLine("---VENDA---");
                                            Console.WriteLine($"ID VENDA: {item.ID}");
                                            Console.WriteLine($"Vendedor: {item.Vendedor}");
                                            Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                                            Console.WriteLine($"Item da venda");
                                            foreach (var itemV in item.Itens) {
                                                Console.WriteLine("---PRODUTO---");
                                                Console.WriteLine($"ID: {itemV.IDproduto}");
                                                Console.WriteLine($"Descricao: {itemV.Descricao}");
                                                Console.WriteLine($"Preço: {itemV.Preco}");
                                                Console.WriteLine($"Quantidade: {itemV.Quantidade}\n");
                                            }
                                        }
                                    }
                                    else
                                        Console.WriteLine("Não encontrado nenhuma venda nessa data");
                                    break;
                                case 2:
                                    Console.Write("Digite a data inicial do periodo: ");
                                    var datainicial = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Digite a data final do periodo: ");
                                    var datafinal = DateTime.Parse(Console.ReadLine());

                                    var periodo = venda.Where(x => x.DataVenda > datainicial && x.DataVenda < datafinal);
                                    if (periodo != null) {
                                        foreach (var item in periodo) {
                                            Console.WriteLine("---VENDA---");
                                            Console.WriteLine($"ID VENDA: {item.ID}");
                                            Console.WriteLine($"Vendedor: {item.Vendedor}");
                                            Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                                            Console.WriteLine($"Item da venda");
                                            foreach (var itemV in item.Itens) {
                                                Console.WriteLine("---PRODUTO---");
                                                Console.WriteLine($"ID: {itemV.IDproduto}");
                                                Console.WriteLine($"Descricao: {itemV.Descricao}");
                                                Console.WriteLine($"Preço: {itemV.Preco}");
                                                Console.WriteLine($"Quantidade: {itemV.Quantidade}\n");
                                            }
                                        }
                                    }
                                    else
                                        Console.WriteLine("Não encontrado nenhuma venda nesse periodo");

                                    break;
                                case 3:
                                    Console.Write("Digite o nome do vendedor: ");
                                    var vendedorr = Console.ReadLine();

                                    var pesquisarvendedor = venda.Where(x => x.Vendedor == vendedorr);
                                    if (vendedorr != null) {
                                        foreach (var item in pesquisarvendedor) {
                                            Console.WriteLine("---VENDA---");
                                            Console.WriteLine($"ID VENDA: {item.ID}");
                                            Console.WriteLine($"Vendedor: {item.Vendedor}");
                                            Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                                            Console.WriteLine($"Item da venda");
                                            foreach (var itemV in item.Itens) {
                                                Console.WriteLine("---PRODUTO---");
                                                Console.WriteLine($"ID: {itemV.IDproduto}");
                                                Console.WriteLine($"Descricao: {itemV.Descricao}");
                                                Console.WriteLine($"Preço: {itemV.Preco}");
                                                Console.WriteLine($"Quantidade: {itemV.Quantidade}\n");
                                            }
                                        }
                                    }
                                    else
                                        Console.Write("Nenhuma venda encontrada por esse vendedor");
                                    break;
                                case 4:
                                    rodando2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Opção invalida...");
                                    break;
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("ID da venda:");
                        var idquantidade = int.Parse(Console.ReadLine());
                        var quantidade1 = venda.FirstOrDefault(x => x.ID == idquantidade);
                        Console.WriteLine("ID da Item venda:");
                        var idquantidadevenda = int.Parse(Console.ReadLine());
                        var quantidade2 = quantidade1.Itens.FirstOrDefault(x => x.IDproduto == idquantidadevenda);

                        if (quantidade2 != null) {
                            Console.Write("Digite a nova quantidade: ");
                            var novaquantidade = int.Parse(Console.ReadLine());
                            quantidade2.Quantidade = novaquantidade;
                        }
                        else
                            Console.WriteLine("Item não encontrado...");
                        break;
                    case 7:
                        Console.WriteLine("Saindo...");
                        rodando = false;
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void Exercicio05() {
            List<ContaBancaria> contabancaria = new List<ContaBancaria>();
            bool rodando = true;

            while (rodando) {
                Console.Clear();
                Console.WriteLine("[1] - Cadastrar nova conta\n" +
                                  "[2] - Excluir conta\n" +
                                  "[3] - Extrato\n" +
                                  "[4] - Saques\n" +
                                  "[5] - Depósito\n" +
                                  "[6] - Transferencia\n" +
                                  "[7] - Sair");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                     
                    case 1:
                        Console.Write("Digite o número da conta: ");
                        var numconta = int.Parse(Console.ReadLine());

                        Console.Write("Digite o saldo da conta: R$");
                        var saldo = decimal.Parse(Console.ReadLine());

                        Console.Write("Conta Especial ?\n" +
                                      "[Sim/Não]");
                        var status = Console.ReadLine();

                        Console.Write("Digite o limite especial da conta: ");
                        var limite = decimal.Parse(Console.ReadLine());

                        contabancaria.Add(new ContaBancaria {
                            Numero = numconta,
                            Saldo = saldo,
                            Status = status,
                            Limite = limite
                        });
                        break;
                    
                    case 2:
                        Console.Write("Digite o número da conta que deseja excluir: ");
                        var numexcluir = int.Parse(Console.ReadLine());

                        //lambda
                        var lambdaexcluir = contabancaria.Where(x => x.Numero == numexcluir);

                        if (lambdaexcluir != null) {
                            foreach (var conta in lambdaexcluir) {
                                contabancaria.Remove((ContaBancaria)lambdaexcluir);
                            }
                        }
                        else
                            Console.WriteLine("Conta não encontrada...");
                        break;
                    
                    case 3:
                        Console.Write("Digite o número da conta: ");
                        var numextrado = int.Parse(Console.ReadLine());

                        var labdaextrado = contabancaria.FirstOrDefault(x => x.Numero == numextrado);

                        if (labdaextrado != null) {
                            labdaextrado.ExtratoTostring();
                        }
                        else
                            Console.WriteLine("Conta não encontrada...");
                        break;
                    case 4:
                     
                      
                        break;
                }
            }
        }
    }
}
