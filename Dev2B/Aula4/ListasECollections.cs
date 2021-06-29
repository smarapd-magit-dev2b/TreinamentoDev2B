using Aula4.Classes;
using Aula4.Exercicio2.Classes;
using Aula4.Exercicio3.Classes;
using Aula4.Exercicio4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula4
{
    public class ListasECollections
    {
        public void Execute()
        {
            //Exemplo1();
            //Exercicio1();
            //Exercicio2();
            Exercicio3();
            //Exercicio4();
        }
        private void Exemplo1()
        {
            List<Pessoa> pessoas = new List<Pessoa> {
                new Pessoa
                {
                    Nome = "Gabriel",
                    Cpf = "123.456.789-12",
                    DataNascimento = DateTime.Parse("01/12/1998"),
                    Sobrenome = "Teles"
                },
                new Pessoa
                {
                    Nome = "Fernando",
                    Cpf = "987.654.321-01",
                    DataNascimento = new DateTime(2005 , 5 ,8),
                    Sobrenome = "Teste"
                }
            };

            foreach (var item in pessoas)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Sobrenome: {item.Sobrenome}");
                Console.WriteLine($"Data de Nascimento: {item.DataNascimento.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Cpf: {item.Cpf}\n");
            }

        }
        private void Exercicio1()
        {
            List<Exercicio1.Classes.Pessoa> pessoas = new List<Aula4.Exercicio1.Classes.Pessoa>();

            var pessoa1 = new Exercicio1.Classes.Pessoa();

            var pessoa2 = new Exercicio1.Classes.Pessoa();

            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);

            foreach (var item in pessoas)
            {
                Console.WriteLine($"Nome: {item.Nome}");
            }
        }
        private void Exercicio2()
        {
            var carros = new List<Carro>();
            var op = 0;
            while (op != 4)
            {
                switch (op)
                {
                    case 1:
                        int autoId = 1;
                        if (carros.Count != 0)
                            autoId = carros[carros.Count].Id + 1;
                        carros.Add(new Carro(autoId));
                        break;
                    case 2:
                        foreach (var item in carros)
                        {
                            Console.WriteLine($"ID: {item.Id}");
                            Console.WriteLine($"Marca: {item.Marca}");
                            Console.WriteLine($"Cor: {item.Cor}");
                            Console.WriteLine($"Ano Fabricação: {item.AnoFabricacao}");
                            Console.WriteLine($"Preço: {item.Preco}");
                            Console.WriteLine($"Quantidade de Portas: {item.QuantidadePortas}");
                            Console.WriteLine($"Kilometragem: {item.Kilometragem}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Informe o Id para excluir");
                        int id = int.Parse(Console.ReadLine());
                        var carroComId2 = carros.FirstOrDefault(x => x.Id == id);

                        if (carroComId2 != null)
                            carros.Remove(carroComId2);

                        break;
                    default:
                        break;
                }
                op = MenuExercicio2();
            }

        }
        private int MenuExercicio2()
        {
            Console.WriteLine("1 - Cadastrar novo carro");
            Console.WriteLine("2 - Listar Todos");
            Console.WriteLine("3 - Excluir Carro");
            Console.WriteLine("4 - Sair");
            return int.Parse(Console.ReadLine());
        }
        private void Exercicio3()
        {
            var alunos = new List<Aluno>();
            var op = 0;
            while (op != 4)
            {
                switch (op)
                {
                    case 1:
                        int autoId = 1;
                        if (alunos.Count != 0)
                            autoId = alunos[alunos.Count].Id + 1;

                        alunos.Add(new Aluno(autoId));
                        break;
                    case 2:
                        foreach (var item in alunos)
                        {
                            item.AlunoToString();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Informe o Id para pesquisar");
                        string termo = Console.ReadLine();
                        var alunoPesquisado = alunos.FirstOrDefault(al => al.Nome == termo || al.Id == int.Parse(termo));

                        if (alunoPesquisado != null)
                            alunoPesquisado.AlunoToString();

                        break;
                    case 4:
                        Console.WriteLine("Informe o Id para excluir");
                        string termoX = Console.ReadLine();
                        var alunoPesquisadoExclusao = alunos.FirstOrDefault(al => al.Nome == termoX || al.Id == int.Parse(termoX));

                        if (alunoPesquisadoExclusao != null)
                            alunos.Remove(alunoPesquisadoExclusao);

                        break;
                    case 5:
                        Console.WriteLine("Informe o Id para excluir");
                        string termoAlt = Console.ReadLine();
                        var alunoPesquisadoAlteracao = alunos.FirstOrDefault(al => al.Nome == termoAlt || al.Id == int.Parse(termoAlt));

                        if (alunoPesquisadoAlteracao != null)
                        {
                            Console.WriteLine("Qual nome deseja alterar: ");
                            alunoPesquisadoAlteracao.Nome = Console.ReadLine();
                        }

                        break;
                    default:
                        break;
                }
                op = MenuExercicio3();
            }

        }
        private int MenuExercicio3()
        {
            Console.WriteLine("1 - Cadastrar um novo aluno");
            Console.WriteLine("2 - Listar todos os alunos cadastrados");
            Console.WriteLine("3 - Pesquisar aluno (Pelo ID ou Nome)");
            Console.WriteLine("4 - Excluir aluno (Pelo ID ou Nome)");
            Console.WriteLine("5 - Alterar nome do aluno (Pesquisa feita para alteração por Id Ou Nome)");
            Console.WriteLine("6 - Sair");
            return int.Parse(Console.ReadLine());
        }
        private void Exercicio4()
        {
            var vendas = new List<Venda>();

            var venda1 = new Venda()
            {
                DataVenda = new DateTime(2021, 06, 29),
                Id = 1,
                Vendedor = "Gabriel"
            };
            venda1.items.Add(new ItemVenda
            {
                Id = 1,
                Descricao = "Sabão",
                Preco = 1.5m,
                Quantidade = 2
            });
            venda1.items.Add(new ItemVenda
            {
                Id = 2,
                Descricao = "Alface",
                Preco = 1m,
                Quantidade = 1
            });
            venda1.items.Add(new ItemVenda
            {
                Id = 7,
                Descricao = "Pao de queijo",
                Preco = 0.5m,
                Quantidade = 1
            });

            var venda2 = new Venda()
            {
                DataVenda = new DateTime(2021, 06, 29),
                Id = 2,
                Vendedor = "Francisco"
            };
            venda2.items.Add(new ItemVenda
            {
                Id = 3,
                Descricao = "CocaCola",
                Preco = 8.5m,
                Quantidade = 3
            });
            venda2.items.Add(new ItemVenda
            {
                Id = 4,
                Descricao = "Carvao",
                Preco = 5m,
                Quantidade = 4
            });

            var venda3 = new Venda()
            {
                DataVenda = new DateTime(2021, 06, 29),
                Id = 3,
                Vendedor = "Gabriel"
            };
            venda3.items.Add(new ItemVenda
            {
                Id = 1,
                Descricao = "Sabão",
                Preco = 1.5m,
                Quantidade = 2
            });
            venda3.items.Add(new ItemVenda
            {
                Id = 2,
                Descricao = "Alface",
                Preco = 1m,
                Quantidade = 1
            });
            venda3.items.Add(new ItemVenda
            {
                Id = 7,
                Descricao = "Pao de queijo",
                Preco = 0.5m,
                Quantidade = 1
            });
            venda3.items.Add(new ItemVenda
            {
                Id = 8,
                Descricao = "Bolo",
                Preco = 0.5m,
                Quantidade = 1
            });

            vendas.Add(venda1);
            vendas.Add(venda2);
            vendas.Add(venda3);



            foreach (var item in vendas)
            {
                Console.WriteLine($"ID VENDA: {item.Id}");
                Console.WriteLine($"Vendedor: {item.Vendedor}");
                Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Item da venda");
                foreach (var itemV in item.items)
                {
                    Console.WriteLine($"- ID: {itemV.Id}");
                    Console.WriteLine($"- Descricao: {itemV.Descricao}");
                    Console.WriteLine($"- Preço: {itemV.Preco}");
                    Console.WriteLine($"- Quantidade: {itemV.Quantidade}\n");
                }
                Console.WriteLine("");
            }


            var apagarVenda = vendas.FirstOrDefault(v => v.Id == 2);
            vendas.Remove(apagarVenda);

            #region Excluir Item Da Venda
            var vendaPorId = vendas.FirstOrDefault(v => v.Id == 1);
            var itemParaExcluir = vendaPorId.items.FirstOrDefault(i => i.Id == 2);
            vendaPorId.items.Remove(itemParaExcluir);
            #endregion

            var pesquisaPorData = vendas.Where(v => v.DataVenda == new DateTime(2021, 06, 29));
            foreach (var item in pesquisaPorData)
            {
                Console.WriteLine($"ID VENDA: {item.Id}");
                Console.WriteLine($"Vendedor: {item.Vendedor}");
                Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Item da venda");
                foreach (var itemV in item.items)
                {
                    Console.WriteLine($"- ID: {itemV.Id}");
                    Console.WriteLine($"- Descricao: {itemV.Descricao}");
                    Console.WriteLine($"- Preço: {itemV.Preco}");
                    Console.WriteLine($"- Quantidade: {itemV.Quantidade}\n");
                }
                Console.WriteLine("");
            }

            var pesquisaPorPeriodo = vendas.Where(v => v.DataVenda == new DateTime(2021, 06, 29));
            foreach (var item in pesquisaPorPeriodo)
            {
                Console.WriteLine($"ID VENDA: {item.Id}");
                Console.WriteLine($"Vendedor: {item.Vendedor}");
                Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Item da venda");
                foreach (var itemV in item.items)
                {
                    Console.WriteLine($"- ID: {itemV.Id}");
                    Console.WriteLine($"- Descricao: {itemV.Descricao}");
                    Console.WriteLine($"- Preço: {itemV.Preco}");
                    Console.WriteLine($"- Quantidade: {itemV.Quantidade}\n");
                }
                Console.WriteLine("");
            }

            var pesquisaPorVendedor = vendas.Where(v => v.Vendedor == "Gabriel");
            foreach (var item in pesquisaPorVendedor)
            {
                Console.WriteLine($"ID VENDA: {item.Id}");
                Console.WriteLine($"Vendedor: {item.Vendedor}");
                Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Item da venda");
                foreach (var itemV in item.items)
                {
                    Console.WriteLine($"- ID: {itemV.Id}");
                    Console.WriteLine($"- Descricao: {itemV.Descricao}");
                    Console.WriteLine($"- Preço: {itemV.Preco}");
                    Console.WriteLine($"- Quantidade: {itemV.Quantidade}\n");
                }
                Console.WriteLine("");
            }

            #region Alterar quantidade de item
            var vendaP = vendas.FirstOrDefault(v => v.Id == 1);
            var i = vendaP.items.FirstOrDefault(i => i.Id == 7);
            i.Quantidade = 5;
            #endregion
        }

    }
}
