using Commom.Dto;
using Commom.Exceptions;
using Commom.Helpers;
using Domain.Entities;
using Infrastructure.UnitOfWork.Interfaces;
using Service.AplicationService.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service.AplicationService
{
    public class PessoaAplicationService : IPessoaAplicationService
    {
        private readonly IPessoaUnitOfWork _uow;

        public PessoaAplicationService(IPessoaUnitOfWork uow) => _uow = uow;
        #region Get
        public List<PessoaGetDto> Get() => _uow.PessoaRepository.Get() != null
                ? _uow.PessoaRepository.Get()
                .Select(p => PessoaHelper.ToPessoaGetDto(p)).ToList()
                : throw new NegocioException("Não há Pessoas cadastradas");

        public PessoaGetDtoPorCodigo GetPorCodigo(int codigo)
        {
            CodigoValidate(codigo);

            Pessoa pessoa = _uow.PessoaRepository.GetPorId(codigo);

            List<Pessoa> filhos = pessoa.Filhos;

            PessoaGetDtoPorCodigo pessoaDto = PessoaHelper.ToPessoaGetDtoPorCodigo(pessoa);

            if (filhos != null)
            {
                pessoaDto.Filhos = new List<PessoaGetDto>();

                foreach (Pessoa filho in filhos)
                    pessoaDto.Filhos.Add(PessoaHelper.ToPessoaGetDto(filho));
            }

            return pessoaDto;
        }
        #endregion
        #region Post
        public int Post(PessoaPostDto pessoaDto)
        {
            PessoaValidate(pessoaDto);

            return _uow.PessoaRepository.Post(
                new Pessoa
                {
                    Name = pessoaDto.Nome,
                    BirthDate = pessoaDto.DataNascimento,
                    Cpf = pessoaDto.DocumentoCpf,
                    Height = pessoaDto.Altura,
                    Id = _uow.PessoaRepository.Get().Max(p => p.Id) + 1,
                    LastName = pessoaDto.SobreNome,
                    Race = pessoaDto.Raca,
                    Status = true,
                    Weight = pessoaDto.Peso
                });
        }

        public int Post(int codigo, PessoaPostDto pessoaDto)
        {
            CodigoValidate(codigo);

            int idFilho = Post(pessoaDto);

            return _uow.PessoaRepository.Post(codigo, idFilho);
        }

        public void Post(int codigo, List<PessoaPostDto> pessoasDto)
        {
            CodigoValidate(codigo);

            foreach (PessoaPostDto pessoaDto in pessoasDto)
                PessoaValidate(pessoaDto);

            List<int> idsFilhos = new List<int>();

            foreach (PessoaPostDto pessoaDto in pessoasDto)
                idsFilhos.Add(Post(pessoaDto));

            foreach (int idFilho in idsFilhos)
                _uow.PessoaRepository.Post(codigo, idFilho);
        }
        #endregion
        #region Put
        public int Put(int codigo, PessoaPostDto pessoaDto)
        {
            CodigoValidate(codigo);

            PessoaValidate(pessoaDto);

            return _uow.PessoaRepository.Put(
                codigo,
                new Pessoa
                {
                    Name = pessoaDto.Nome,
                    BirthDate = pessoaDto.DataNascimento,
                    Cpf = pessoaDto.DocumentoCpf,
                    Height = pessoaDto.Altura,
                    Id = codigo,
                    LastName = pessoaDto.SobreNome,
                    Race = pessoaDto.Raca,
                    Status = true,
                    Weight = pessoaDto.Peso
                });
        }

        public int PutEssencial(int codigo, PessoaPutEssencialDto pessoaDto)
        {
            CodigoValidate(codigo);

            PessoaValidateEssencial(pessoaDto);

            return _uow.PessoaRepository.PutPessoaEssencial(codigo, new Pessoa
            {
                Name = pessoaDto.Nome,
                LastName = pessoaDto.SobreNome,
                Cpf = pessoaDto.DocumentoCpf
            });
        }

        public int PutUsuarioAtivo(int codigo, bool usuario)
        {
            CodigoValidate(codigo);

            if (usuario == _uow.PessoaRepository.GetPorId(codigo).Status)
                throw new NegocioException($"Pessoa com Código {codigo} {(usuario ? "já está ativa" : "já está desativada")}");

            return _uow.PessoaRepository.PutStatus(codigo, usuario);
        }
        #endregion
        public int Delete(int codigo)
        {
            CodigoValidate(codigo);

            if (_uow.PessoaRepository.GetPorId(codigo).Status)
                throw new NegocioException("Não é possível deletar usuários ativos");

            return _uow.PessoaRepository.Delete(codigo);
        }
        #region Validate
        private void PessoaValidateEssencial(PessoaPutEssencialDto pessoaDto)
        {
            if (string.IsNullOrEmpty(pessoaDto.Nome))
                throw new NegocioException("O campo Nome deve ser preenchido");

            if (pessoaDto.Nome.Length < 5)
                throw new NegocioException("O Nome não pode ter menos de 5 letras");

            if (string.IsNullOrEmpty(pessoaDto.SobreNome))
                throw new NegocioException("O campo Sobrenome deve ser preenchido");

            if (string.IsNullOrEmpty(pessoaDto.DocumentoCpf))
                throw new NegocioException("O campo Cpf deve ser preenchido");

            if (!CpfHelper.Valido(pessoaDto.DocumentoCpf))
                throw new NegocioException("Cpf inválido");
        }
        private void PessoaValidate(PessoaPostDto pessoaDto)
        {
            PessoaValidateEssencial(new PessoaPutEssencialDto()
            {
                Nome = pessoaDto.Nome,
                SobreNome = pessoaDto.SobreNome,
                DocumentoCpf = pessoaDto.DocumentoCpf
            });

            if (DateTimeHelper.Idade(pessoaDto.DataNascimento) < 18)
                throw new NegocioException("Só é aceito maiores de idade");
        }

        private void CodigoValidate(int codigo)
        {
            if (_uow.PessoaRepository.GetPorId(codigo) == null)
                throw new NegocioException($"Pessoa com Código {codigo} não existe");
        }
        #endregion
    }
}
