using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class PessoaRepository {
        List<Pessoa> PessoaCollection = new List<Pessoa>
            {
                new Pessoa
                {
                    Id = 1,
                    Nome = "José",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    Idade = 18,
                    UsuarioAtivo = true
                },
                new Pessoa
                {
                    Id = 10,
                    Nome = "Willian",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    Idade = 25,
                    UsuarioAtivo = true
                },
                new Pessoa
                {
                    Id = 4,
                    Nome = "Silas",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    Idade = 35,
                    UsuarioAtivo = true,
                },
                new Pessoa
                {
                    Id = 77,
                    Nome = "Glenison",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    Idade = 30,
                    UsuarioAtivo = false
                },
                new Pessoa
                {
                    Id = 90,
                    Nome = "Gabriel",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    Idade = 30,
                    UsuarioAtivo = true
                }
        };
    }
}
