using System;
using System.Collections.Generic;
using System.Linq;
using Aula4.Classes;
using Aula4.Exercicio2.Classes;
using Aula4.Exercicio3.Classes;
using Aula4.Exercicio4.Classes;
using Aula4.Exercicio5.Classes;

namespace Aula4
{
    public class ListasECollections
    {
        public void Execute()
        {
            //Exemplo1();
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            Exercicio5();
        }

        private void Exemplo1()
        {
            var pessoas = new List<Pessoa>
            {
                new()
                {
                    Nome = "Gabriel",
                    Cpf = "123.456.789-12",
                    DataNascimento = DateTime.Parse("01/12/1998"),
                    Sobrenome = "Teles"
                },
                new()
                {
                    Nome = "Fernando",
                    Cpf = "987.654.321-01",
                    DataNascimento = new DateTime(2005, 5, 8),
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
            var pessoas = new List<Exercicio1.Classes.Pessoa>();

            var pessoa1 = new Exercicio1.Classes.Pessoa();

            var pessoa2 = new Exercicio1.Classes.Pessoa();

            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);

            foreach (var item in pessoas) Console.WriteLine($"Nome: {item.Nome}");
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
                        var autoId = 1;
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
                        var id = int.Parse(Console.ReadLine());
                        var carroComId2 = carros.FirstOrDefault(x => x.Id == id);

                        if (carroComId2 != null)
                            carros.Remove(carroComId2);

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
            while (op != 6)
            {
                switch (op)
                {
                    case 1:
                        var autoId = 1;
                        if (alunos.Count != 0)
                            autoId = alunos[alunos.Count].Id + 1;

                        alunos.Add(new Aluno(autoId));
                        break;
                    case 2:
                        foreach (var item in alunos) item.AlunoToString();
                        break;
                    case 3:
                        Console.WriteLine("Informe o Id para pesquisar");
                        var termo = Console.ReadLine();
                        var alunoPesquisado =
                            alunos.FirstOrDefault(al => al.Nome == termo || al.Id == int.Parse(termo));

                        if (alunoPesquisado != null)
                            alunoPesquisado.AlunoToString();

                        break;
                    case 4:
                        Console.WriteLine("Informe o Id para excluir");
                        var termoX = Console.ReadLine();
                        var alunoPesquisadoExclusao =
                            alunos.FirstOrDefault(al => al.Nome == termoX || al.Id == int.Parse(termoX));

                        if (alunoPesquisadoExclusao != null)
                            alunos.Remove(alunoPesquisadoExclusao);

                        break;
                    case 5:
                        Console.WriteLine("Informe o Id para alterar");
                        var termoAlt = Console.ReadLine();
                        var alunoPesquisadoAlteracao =
                            alunos.FirstOrDefault(al => al.Nome == termoAlt || al.Id == int.Parse(termoAlt));

                        if (alunoPesquisadoAlteracao != null)
                        {
                            Console.WriteLine("Qual nome deseja alterar: ");
                            alunoPesquisadoAlteracao.Nome = Console.ReadLine();
                        }

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

            var opcaoMenu = 0;
            while (opcaoMenu != 9)
            {
                switch (opcaoMenu)
                {
                    case 1:
                        var autoId = 1;
                        if (vendas.Count != 0)
                            autoId = vendas[vendas.Count].Id + 1;

                        var venda = new Venda(autoId);


                        var itemOp = 0;

                        while (itemOp != 2)
                        {
                            venda.items.Add(new ItemVenda());

                            MenuExercicioItemVendas4();
                        }


                        vendas.Add(venda);
                        break;
                    case 2:
                    {
                        foreach (var item in vendas)
                        {
                            Console.WriteLine($"ID VENDA: {item.Id}");
                            Console.WriteLine($"Vendedor: {item.Vendedor}");
                            Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                            Console.WriteLine("Item da venda");
                            foreach (var itemV in item.items)
                            {
                                Console.WriteLine($"- ID: {itemV.Id}");
                                Console.WriteLine($"- Descricao: {itemV.Descricao}");
                                Console.WriteLine($"- Preço: {itemV.Preco}");
                                Console.WriteLine($"- Quantidade: {itemV.Quantidade}\n");
                            }

                            Console.WriteLine("");
                        }

                        break;
                    }
                    case 3:
                        Console.WriteLine("Informe o ID da venda para deletar: ");
                        var idExclusao = int.Parse(Console.ReadLine());
                        var apagarVenda = vendas.FirstOrDefault(v => v.Id == idExclusao);
                        if (apagarVenda != null)
                            vendas.Remove(apagarVenda);
                        else
                            Console.WriteLine("Não existem registros com esse ID");
                        break;
                    case 4:
                        Console.WriteLine("Informe o ID da venda para deletar: ");
                        var idExclusaoV = int.Parse(Console.ReadLine());
                        var vendaPorId = vendas.FirstOrDefault(v => v.Id == idExclusaoV);
                        if (vendaPorId != null)
                        {
                            Console.WriteLine("Informe o ID do item para apagar: ");
                            var idItemVenda = int.Parse(Console.ReadLine());
                            var itemParaExcluir = vendaPorId.items.FirstOrDefault(i => i.Id == idItemVenda);

                            if (itemParaExcluir != null) vendaPorId.items.Remove(itemParaExcluir);
                        }
                        else
                        {
                            Console.WriteLine("Não existem registros com esse ID");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Informe a data que deseja buscar: ");
                        var dataBusca = DateTime.Parse(Console.ReadLine());
                        var pesquisaPorData = vendas.Where(v => v.DataVenda == dataBusca);
                        if (pesquisaPorData != null)
                            foreach (var item in pesquisaPorData)
                            {
                                Console.WriteLine($"ID VENDA: {item.Id}");
                                Console.WriteLine($"Vendedor: {item.Vendedor}");
                                Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                                Console.WriteLine("Item da venda");
                                foreach (var itemV in item.items)
                                {
                                    Console.WriteLine($"- ID: {itemV.Id}");
                                    Console.WriteLine($"- Descricao: {itemV.Descricao}");
                                    Console.WriteLine($"- Preço: {itemV.Preco}");
                                    Console.WriteLine($"- Quantidade: {itemV.Quantidade}\n");
                                }

                                Console.WriteLine("");
                            }

                        break;
                    case 6:
                        Console.WriteLine("Informe a primeira data do intervalo que deseja buscar: ");
                        var dataBusca1 = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a segunda data do intervalo que deseja buscar: ");
                        var dataBusca2 = DateTime.Parse(Console.ReadLine());
                        var pesquisaPorPeriodo =
                            vendas.Where(v => v.DataVenda > dataBusca1 && v.DataVenda < dataBusca2);
                        if (pesquisaPorPeriodo != null)
                            foreach (var item in pesquisaPorPeriodo)
                            {
                                Console.WriteLine($"ID VENDA: {item.Id}");
                                Console.WriteLine($"Vendedor: {item.Vendedor}");
                                Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                                Console.WriteLine("Item da venda");
                                foreach (var itemV in item.items)
                                {
                                    Console.WriteLine($"- ID: {itemV.Id}");
                                    Console.WriteLine($"- Descricao: {itemV.Descricao}");
                                    Console.WriteLine($"- Preço: {itemV.Preco}");
                                    Console.WriteLine($"- Quantidade: {itemV.Quantidade}\n");
                                }

                                Console.WriteLine("");
                            }

                        break;
                    case 7:
                        Console.WriteLine("Informe o vendedor que deseja buscar: ");
                        var vendedorBusca = Console.ReadLine();
                        var pesquisaPorVendedor = vendas.Where(v => v.Vendedor.ToLower() == vendedorBusca.ToLower());
                        if (pesquisaPorVendedor != null)
                            foreach (var item in pesquisaPorVendedor)
                            {
                                Console.WriteLine($"ID VENDA: {item.Id}");
                                Console.WriteLine($"Vendedor: {item.Vendedor}");
                                Console.WriteLine($"Data da venda: {item.DataVenda.ToString("dd/MM/yyyy")}");
                                Console.WriteLine("Item da venda");
                                foreach (var itemV in item.items)
                                {
                                    Console.WriteLine($"- ID: {itemV.Id}");
                                    Console.WriteLine($"- Descricao: {itemV.Descricao}");
                                    Console.WriteLine($"- Preço: {itemV.Preco}");
                                    Console.WriteLine($"- Quantidade: {itemV.Quantidade}\n");
                                }

                                Console.WriteLine("");
                            }

                        break;
                    case 8:
                        Console.WriteLine("Informe o ID da venda para alterar: ");
                        var idAlteracao = int.Parse(Console.ReadLine());
                        var vendaAlteracao = vendas.FirstOrDefault(v => v.Id == idAlteracao);
                        Console.WriteLine("Informe o ID do item para apagar: ");
                        var idItemVendaAlteracao = int.Parse(Console.ReadLine());
                        var vendaP = vendas.FirstOrDefault(v => v.Id == idAlteracao);
                        var i = vendaP.items.FirstOrDefault(i => i.Id == idItemVendaAlteracao);
                        Console.WriteLine($"Informe a quantidade que deseja mudar do item {i.Descricao}");
                        i.Quantidade = int.Parse(Console.ReadLine());
                        break;
                }

                opcaoMenu = MenuExercicioVendas4();
            }
        }

        private int MenuExercicioVendas4()
        {
            Console.WriteLine("1 - Cadastrar uma nova venda");
            Console.WriteLine("2 - Listar todos as vendas cadastrados");
            Console.WriteLine("3 - Excluir venda (Pelo ID ou Nome)");
            Console.WriteLine("4 - Excluir item da venda (Pelo ID ou Nome)");
            Console.WriteLine("5 - Pesquisar venda por Data");
            Console.WriteLine("6 - Pesquisar venda por Periodo");
            Console.WriteLine("7 - Pesquisar venda por Vendedor");
            Console.WriteLine("8 - Alterar a quantidade do item");
            Console.WriteLine("9 - Sair");
            return int.Parse(Console.ReadLine());
        }

        private int MenuExercicioItemVendas4()
        {
            Console.WriteLine("1 - Novo item");
            Console.WriteLine("2 - Sair");
            return int.Parse(Console.ReadLine());
        }

        private void Exercicio5()
        {
            var contas = new List<Conta>();

            var opcaoMenu = 0;
            while (opcaoMenu != 7)
            {
                switch (opcaoMenu)
                {
                    case 1:
                    {
                        var autoId = 1;
                        if (contas.Count != 0)
                            autoId = contas[contas.Count].NumeroConta + 1;

                        Console.WriteLine("Criação de conta");
                        contas.Add(new Conta(autoId));
                        Console.WriteLine($"Conta criada com o ID {autoId}");

                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Informe o numero da conta de deseja excluir");
                        var id = int.Parse(Console.ReadLine());
                        var contaParaExcluir = contas.FirstOrDefault(c => c.NumeroConta == id);
                        if (contaParaExcluir != null)
                            Console.WriteLine("Conta excluida");
                        contas.Remove(contaParaExcluir);
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Informe o numero da conta de deseja sacar");
                        var id = int.Parse(Console.ReadLine());

                        var contaParaSacar = contas.FirstOrDefault(c => c.NumeroConta == id);


                        if (contaParaSacar != null)
                        {
                            Console.WriteLine("Informe o valor que deseja sacar");
                            var valor = decimal.Parse(Console.ReadLine());
                            contaParaSacar.Sacar(valor);
                        }

                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Informe o numero da conta de deseja depositar");
                        var id = int.Parse(Console.ReadLine());

                        var contaParaDepositar = contas.FirstOrDefault(c => c.NumeroConta == id);


                        if (contaParaDepositar != null)
                        {
                            Console.WriteLine("Informe o valor que deseja depositar");
                            var valor = decimal.Parse(Console.ReadLine());
                            contaParaDepositar.Depositar(valor);
                        }

                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Qual numero da conta para imprimir o extrato?");
                        var id = int.Parse(Console.ReadLine());

                        var contaParaDepositar = contas.FirstOrDefault(c => c.NumeroConta == id);

                        if (contaParaDepositar != null) contaParaDepositar.ImprimirExtrato();
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("Informe o numero da conta de deseja transferir");
                        var id = int.Parse(Console.ReadLine());

                        var contaParaTranferir = contas.FirstOrDefault(c => c.NumeroConta == id);

                        if (contaParaTranferir != null)
                        {
                            Console.WriteLine("Informe o numero da conta que vai receber");
                            var idTarget = int.Parse(Console.ReadLine());
                            var contaQueVaiATranferencia = contas.FirstOrDefault(c => c.NumeroConta == idTarget);
                            if (contaQueVaiATranferencia != null)
                            {
                                Console.WriteLine("Qual o valor que vai tranferir ?");
                                var valor = decimal.Parse(Console.ReadLine());
                                contaParaTranferir.Tranferir(contaParaTranferir, valor);
                            }
                        }

                        break;
                    }
                }

                opcaoMenu = MenuExercicio5();
            }
        }

        private int MenuExercicio5()
        {
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Excluir conta");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Depositar");
            Console.WriteLine("5 - Imprimir Extrato");
            Console.WriteLine("6 - Transferir");
            Console.WriteLine("7 - Sair");
            return int.Parse(Console.ReadLine());
        }
    }
}