using Commom.Dto;
using Domain.Entities;

namespace Commom.Helpers
{
    public static class PessoaHelper
    {
        public static PessoaGetDto ToPessoaGetDto(Pessoa pessoa) => new PessoaGetDto()
        {
            Nome = pessoa.Name,
            SobreNome = pessoa.LastName,
            Altura = pessoa.Height,
            Peso = pessoa.Weight,
            DataNascimento = pessoa.BirthDate,
            UsuarioAtivo = pessoa.Status,
            DocumentoCpf = pessoa.Cpf,
            Codigo = pessoa.Id,
            Raca = pessoa.Race,
            Filhos = pessoa.Filhos != null ? pessoa.Filhos.Count : 0
        };

        public static PessoaGetDtoPorCodigo ToPessoaGetDtoPorCodigo(Pessoa pessoa) => new PessoaGetDtoPorCodigo()
        {
            Nome = pessoa.Name,
            SobreNome = pessoa.LastName,
            Altura = pessoa.Height,
            Peso = pessoa.Weight,
            DataNascimento = pessoa.BirthDate,
            UsuarioAtivo = pessoa.Status,
            DocumentoCpf = pessoa.Cpf,
            Codigo = pessoa.Id,
            Raca = pessoa.Race
        };
    }
}
