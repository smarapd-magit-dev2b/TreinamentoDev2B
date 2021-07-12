using Domain.Entities;
using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository {
    public class PessoaRepository : IPessoaRepository {
        private List<Pessoa> PessoaCollection = new List<Pessoa>
            {
                new Pessoa
                {
                    Id = 1,
                    Nome = "José",
                    SobreNome = "Silva",
                    Cpf = "497.500.270-19",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    UsuarioAtivo = true,
                    Filhos = new List<Pessoa>()
                },
                new Pessoa
                {
                    Id = 10,
                    Nome = "Willian",
                    SobreNome = "Andrade",
                    Cpf = "009.630.700-53",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    UsuarioAtivo = true,
                    Filhos = new List<Pessoa>()
                },
                new Pessoa
                {
                    Id = 4,
                    Nome = "Silas",
                    SobreNome = "Almeida",
                    Cpf = "164.656.030-20",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    UsuarioAtivo = true,
                    Filhos = new List<Pessoa>()
                },
                new Pessoa
                {
                    Id = 77,
                    Nome = "Glenison",
                    SobreNome = "Honório",
                    Cpf = "916.876.230-58",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    UsuarioAtivo = false,
                    Filhos = new List<Pessoa>()
                },
                new Pessoa
                {
                    Id = 90,
                    Nome = "Gabriel",
                    SobreNome = "Domingos",
                    Cpf = "421.694.740-99",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    UsuarioAtivo = true,
                    Filhos = new List<Pessoa>()
                }
        };

        public void Adicionar(Pessoa pessoa) {
            PessoaCollection.Add(pessoa);
        }

        public void AdicionarFilhos(int id, Pessoa pessoa) {
            var idpai = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            idpai.Filhos.Add(pessoa);

        }

        public void Deletar(Pessoa pessoa) {
            PessoaCollection.Remove(pessoa);
        }

        public void Editar(int id, Pessoa pessoa) {
            var editarpessoa = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();

            editarpessoa.Nome = pessoa.Nome;
            editarpessoa.SobreNome = pessoa.SobreNome;
            editarpessoa.DataNascimento = pessoa.DataNascimento;
            editarpessoa.Altura = pessoa.Altura;
            editarpessoa.Cpf = pessoa.Cpf;
            editarpessoa.Peso = pessoa.Peso;
            editarpessoa.Raca = pessoa.Raca;
        }

        public void EditarNomeSobrenomeCpf(int id, Pessoa pessoa) {
            var editardados = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();

            editardados.Nome = pessoa.Nome;
            editardados.SobreNome = pessoa.SobreNome;
            editardados.Cpf = pessoa.Cpf;
        }

        public List<Pessoa> Listar() {
            return PessoaCollection;
        }

        public List<Pessoa> ListarPessoaPorID() {
            return PessoaCollection;
        }

        public Pessoa ObterPessoaPorID(int id) {
            var pessoa = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();

            return pessoa;
        }

        public void UsuarioStatusRepository(int id) {
            var status = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            status.UsuarioAtivo = !status.UsuarioAtivo;
        }
    }
}
