using Dev2bDomain.Entities;
using System;

namespace Dev2bAppilcation.Helpers
{
    public static class PessoaServiceHelper
    {
        public static void NaoExistePessoaComId(int id, PessoaEntity pessoa)
        {
            if (pessoa == null)
                throw new Exception($"Não existe uma pessoa com Id {id}");
        }

        public static void NomeNaoInformado(PessoaEntity pessoa)
        {
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new Exception($"Nome da pessoa não informado");
        }

        public static void NomeMaiorQue5Caracteres(PessoaEntity pessoa)
        {
            if (pessoa.Nome.Length < 5)
                throw new Exception($"Nome da pessoa deve ser maior que 5 caracteres");
        }

        public static void MaiorDeIdade(PessoaEntity pessoa)
        {
            if (pessoa.Idade < 18)
                throw new Exception($"É aceito apenas o cadastro de adultos (maiores de 18 anos)");
        }
    }
}
