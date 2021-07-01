using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aula5.Exercicio1;
using Aula5.Exercicio2;
using Aula5.Exercicio3;
using Aula5.Exercicio4;
using Aula5.Exercicio5;

namespace Aula5
{
    public class ExerciciosAula5
    {
        public void Execute()
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();

        }
        private void Exercicio1()
        {
            int QuantPessoas;
            List<Exercicio1.Pessoa> ListaPessoas = new List<Exercicio1.Pessoa>();
            Console.WriteLine("Quantas pessoas deseja cadastrar? ");
            QuantPessoas = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < QuantPessoas; i++)
            {
                ListaPessoas.Add(new Aula5.Exercicio1.Pessoa());
            }
            Console.Clear();
            foreach (var pessoa in ListaPessoas)
            {
                Console.WriteLine(pessoa.Nome);
                Console.WriteLine(pessoa.Telefone);
                Console.WriteLine(pessoa.DataNascimento);
                Console.WriteLine(pessoa.Salario);
                Console.WriteLine(pessoa.QtdFilhos);
                Console.WriteLine(pessoa.Altura);
                Console.WriteLine(pessoa.Peso);
                Console.WriteLine(pessoa.NomePai);
                Console.WriteLine(pessoa.NomeMae);
                Console.WriteLine("----------------------------------------");
            }
        }
        private void Exercicio2()
        {
            List<Carro> ListaCarros = new List<Carro>();
            bool rodando = true;
            while (rodando)
            {
                Console.WriteLine("Escolha qual função deseja:");
                Console.WriteLine("1 - Cadastrar carro");
                Console.WriteLine("2 - Listas carros");
                Console.WriteLine("3 - Excluir carro");
                Console.WriteLine("4 - Sair");
                EnumMenu2 funcao;
                string func = Console.ReadLine();
                Enum.TryParse<EnumMenu2>(func, out funcao);
                switch (funcao)
                {
                    case EnumMenu2.Cadastrar:
                        ListaCarros.Add(new Carro());
                        break;
                    case EnumMenu2.Listar:
                        foreach (var carro in ListaCarros)
                        {
                            Console.WriteLine(carro.Id);
                            Console.WriteLine(carro.Marca);
                            Console.WriteLine(carro.Cor);
                            Console.WriteLine(carro.AnoFabricacao);
                            Console.WriteLine(carro.Preco);
                            Console.WriteLine(carro.QtdPortas);
                            Console.WriteLine(carro.Kilometragem);
                        }
                        break;
                    case EnumMenu2.Excluir:
                        Console.WriteLine("Qual o id do carro que deseja remover? ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var CarRemove = ListaCarros.Where(x => x.Id == id).FirstOrDefault();
                        ListaCarros.Remove(CarRemove);
                        break;
                    case EnumMenu2.Sair:
                        rodando = false;
                        break;

                }
            }
        }
        private void Exercicio3()
        {
            List<Aluno> ListaAluno = new List<Aluno>();
            bool rodando2 = true;
            while (rodando2)
            {
                Console.WriteLine("Escolha qual função deseja:");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Listar aluno");
                Console.WriteLine("3 - Pesquisar aluno");
                Console.WriteLine("4 - Excluir aluno");
                Console.WriteLine("5 - Alterar nome do aluno");
                Console.WriteLine("6 - Sair");
                EnumMenu3 funcao;
                string func = Console.ReadLine();
                Enum.TryParse<EnumMenu3>(func, out funcao);
                switch (funcao)
                {
                    case EnumMenu3.Cadastrar:
                        ListaAluno.Add(new Aluno());
                        break;

                    case EnumMenu3.Listar:
                        foreach (var aluno in ListaAluno)
                        {
                            Console.WriteLine(aluno.Nome);
                            Console.WriteLine(aluno.Idade);
                            Console.WriteLine(aluno.Ra);
                            Console.WriteLine(aluno.DataNascimento);
                            Console.WriteLine(aluno.NomePai);
                            Console.WriteLine(aluno.NomeMae);
                            Console.WriteLine("----------------------------------------");
                        }
                        break;

                    case EnumMenu3.BuscarAluno:
                        Console.WriteLine("Qual o nome ou id do aluno? ");
                        string Procura = Console.ReadLine();
                        var Aluno = ListaAluno.Where(x => x.Id == Procura || x.Nome == Procura).FirstOrDefault();
                        Console.WriteLine(Aluno.Id);
                        Console.WriteLine(Aluno.Nome);
                        Console.WriteLine(Aluno.Idade);
                        Console.WriteLine(Aluno.Ra);
                        Console.WriteLine(Aluno.DataNascimento);
                        Console.WriteLine(Aluno.NomePai);
                        Console.WriteLine(Aluno.NomeMae);
                        break;
                    case EnumMenu3.Excluir:
                        Console.WriteLine("Qual o nome ou id do aluno que deseja excluir? ");
                        string Remover = Console.ReadLine();
                        var RemAluno = ListaAluno.Where(x => x.Id == Remover || x.Nome == Remover).FirstOrDefault();
                        ListaAluno.Remove(RemAluno);
                        break;
                    case EnumMenu3.MudarNome:
                        Console.WriteLine("Qual o nome ou id do aluno que deseja editar? ");
                        string Editar = Console.ReadLine();
                        var EditarAluno = ListaAluno.Where(x => x.Id == Editar || x.Nome == Editar).FirstOrDefault();
                        Console.WriteLine("Qual o novo nome do aluno? ");
                        EditarAluno.Nome = Console.ReadLine();
                        break;
                    case EnumMenu3.Sair:
                        rodando2 = false;
                        break;
                }
            }
        }
        private void Exercicio4()
        {
            List<Venda> Vendas = new List<Venda>();
            bool rodando3 = true;
            while (rodando3)
            {
                Console.WriteLine("Escolha qual função deseja:");
                Console.WriteLine("1 - Cadastrar Venda");
                Console.WriteLine("2 - Adicionar item a venda");
                Console.WriteLine("3 - Listar vendas");
                Console.WriteLine("4 - Excluir Venda");
                Console.WriteLine("5 - Excluir item da venda");
                Console.WriteLine("6 - Pesquisar venda por data");
                Console.WriteLine("7 - Pesquisar venda por periodo");
                Console.WriteLine("8 - Pesquisar venda por vendedor");
                Console.WriteLine("9 - Alterar Quantidade de itens");
                Console.WriteLine("10 - Sair");
                EnumMenu4 funcao;
                string func = Console.ReadLine();
                Enum.TryParse<EnumMenu4>(func, out funcao);


                switch (funcao)
                {
                    case EnumMenu4.Cadastrar:
                        Vendas.Add(new Venda());
                        break;
                    case EnumMenu4.AdicionarItem:
                        Console.WriteLine("Qual venda deseja adicionar item? ");
                        string IdVenda = Console.ReadLine();
                        var venda = Vendas.Where(x => x.Id == IdVenda).FirstOrDefault();
                        venda.ListaItens.Add(new ItemVenda());
                        break;
                    case EnumMenu4.Listar:
                        foreach (var Venda in Vendas)
                        {
                            Console.WriteLine(Venda.Id);
                            Console.WriteLine(Venda.DataVenda);
                            Console.WriteLine(Venda.Vendedor);
                            foreach (var coisa in Venda.ListaItens)
                            {
                                Console.WriteLine(coisa.Id);
                                Console.WriteLine(coisa.Descricao);
                                Console.WriteLine(coisa.Quantidade);
                                Console.WriteLine(coisa.PrecoUnitario);
                            }
                        }
                        break;
                    case EnumMenu4.ExcluirVenda:
                        Console.WriteLine("Qual o id da venda deseja remover item? ");
                        string idVenda = Console.ReadLine();
                        var vend = Vendas.Where(x => x.Id == idVenda).FirstOrDefault();
                        Vendas.Remove(vend);
                        break;
                    case EnumMenu4.ExcluirItem:
                        Console.WriteLine("Qual o id da venda deseja remover item? ");
                        string idvenda = Console.ReadLine();
                        Console.WriteLine("Qual o id item deseja remover? ");
                        string idItem = Console.ReadLine();
                        var vendaRemItem = Vendas.Where(x => x.Id == idvenda).FirstOrDefault();
                        var item = vendaRemItem.ListaItens.Where(x => x.Id == idItem).FirstOrDefault();
                        vendaRemItem.ListaItens.Remove(item);
                        break;
                    case EnumMenu4.PesquisarData:
                        Console.WriteLine("Qual data deseja pesquisar? ");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        var Vend = Vendas.Where(x => x.DataVenda.Date == data.Date).ToList();
                        foreach (var x in Vend)
                        {
                            Console.WriteLine(x.Id);
                            Console.WriteLine(x.DataVenda);
                            Console.WriteLine(x.Vendedor);
                            foreach (var conteudo in x.ListaItens)
                            {
                                Console.WriteLine(conteudo.Id);
                                Console.WriteLine(conteudo.Descricao);
                                Console.WriteLine(conteudo.Quantidade);
                                Console.WriteLine(conteudo.PrecoUnitario);
                            }
                        }
                        break;
                    case EnumMenu4.PesquisarPeriodo:
                        Console.WriteLine("Qual o começo do periodo que deseja pesquisar? ");
                        DateTime inicio = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Qual o final do periodo que deseja pesquisar? ");
                        DateTime final = Convert.ToDateTime(Console.ReadLine());
                        var VendaPeriodo = Vendas.Where(x => x.DataVenda.Date > inicio.Date && x.DataVenda.Date < final.Date).ToList();
                        foreach (var x in VendaPeriodo)
                        {
                            Console.WriteLine(x.Id);
                            Console.WriteLine(x.DataVenda);
                            Console.WriteLine(x.Vendedor);
                            foreach (var y in x.ListaItens)
                            {
                                Console.WriteLine(y.Id);
                                Console.WriteLine(y.Descricao);
                                Console.WriteLine(y.Quantidade);
                                Console.WriteLine(y.PrecoUnitario);
                            }
                        }
                        break;
                    case EnumMenu4.PesquisarVendedor:
                        Console.WriteLine("Qual venderor que deseja pesquisar? ");
                        string vendedor = Console.ReadLine();
                        var VendaVendedor = Vendas.Where(x => x.Vendedor == vendedor).ToList();
                        foreach (var x in VendaVendedor)
                        {
                            Console.WriteLine(x.Id);
                            Console.WriteLine(x.DataVenda);
                            Console.WriteLine(x.Vendedor);
                            foreach (var conteudo in x.ListaItens)
                            {
                                Console.WriteLine(conteudo.Id);
                                Console.WriteLine(conteudo.Descricao);
                                Console.WriteLine(conteudo.Quantidade);
                                Console.WriteLine(conteudo.PrecoUnitario);
                            }
                        }
                        break;
                    case EnumMenu4.AlterarQuantidade:
                        Console.WriteLine("Qual o id da venda deseja editar item? ");
                        string idVendaQtd = Console.ReadLine();
                        Console.WriteLine("Qual o id item editar remover? ");
                        string idItemQtd = Console.ReadLine();
                        var VendaQtd = Vendas.Where(x => x.Id == idVendaQtd).FirstOrDefault();
                        var ItemQtd = VendaQtd.ListaItens.Where(x => x.Id == idItemQtd).FirstOrDefault();
                        Console.WriteLine("Qual a nova quantidade para este item? ");
                        ItemQtd.Quantidade = Convert.ToInt32(Console.ReadLine());
                        
                        break;
                    case EnumMenu4.Sair:
                        rodando3 = false;
                        break;

                }
                break;
            }
        }
        private void Exercicio5()
        {
            Banco Banco = new Banco();
            bool rodando = true;
            while (rodando)
            {
                Console.WriteLine("Escolha qual função deseja:");
                Console.WriteLine("1 - Cadastrar Conta");
                Console.WriteLine("2 - Excluir Conta");
                Console.WriteLine("3 - Saque");
                Console.WriteLine("4 - Deposito");
                Console.WriteLine("5 - Saldo");
                Console.WriteLine("6 - Extrato");
                Console.WriteLine("7 - Transferencia");
                Console.WriteLine("8 - Sair");
                EnumMenu5 menu;
                string funcao = Console.ReadLine();
                Enum.TryParse<EnumMenu5>(funcao, out menu);
                switch (menu)
                {
                    case EnumMenu5.Cadastrar:
                        Banco.CadastrarConta();
                        break;
                    case EnumMenu5.Excluir:
                        Banco.ExcluirConta();
                        break;
                    case EnumMenu5.Saque:
                        Banco.Saque();
                        break;
                    case EnumMenu5.Deposito:
                        break;
                    case EnumMenu5.Saldo:
                        break;
                    case EnumMenu5.Extrato:
                        break;
                    case EnumMenu5.Transferencia:
                        break;
                    case EnumMenu5.Sair:
                        break;
                    default:
                        break;
                }

            }
        }
    }
}

