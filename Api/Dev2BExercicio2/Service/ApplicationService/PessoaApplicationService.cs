using System.Collections.Generic;
using System.Linq;
using Common.Dto;
using Common.Exceptions;
using Common.Entities;
using Infrastructure.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;
using Common.Helpers;

namespace Service.ApplicationService
{
    public class PessoaApplicationService : IPessoaApplicationService
    {
        private readonly IPessoaUnitOfWork Uow;
        public PessoaApplicationService(IPessoaUnitOfWork pessoaUnitOfWork)
        {
            Uow = pessoaUnitOfWork;
        }

        public int AdicionarPessoa(PessoaPostDto dto)
        {
            Pessoa pessoa = new Pessoa()
            {
                Id = IdHelper.GenerateId(),
                Nome = dto.Nome,
                SobreNome = dto.SobreNome,
                Cpf = dto.Cpf,
                Altura = dto.Altura,
                DataNascimento = dto.DataNascimento,
                Peso = dto.Peso,
                Raca = dto.Raca,
                UsuarioAtivo = true,
            };

            Validate(pessoa);

            Uow.PessoaRepository.Adicionar(pessoa);

            return pessoa.Id;
        }

        public void EditarPessoa(int id, PessoaPutDto putDto)
        {
            if (Uow.PessoaRepository.ObterPessoaPorId(id) == null)
                throw new DomainException($"Id não encontrado");

            Pessoa pessoa = new Pessoa()
            {
                Nome = putDto.Nome,
                SobreNome = putDto.SobreNome,
                Cpf = putDto.Cpf,
                Altura = putDto.Altura,
                DataNascimento = putDto.DataNascimento,
                Peso = putDto.Peso,
                Raca = putDto.Raca,
            };

            Validate(pessoa);

            Uow.PessoaRepository.Editar(id, pessoa);
        }

        private void Validate(Pessoa pessoa)
        {
            if (DateTimeHelper.GetIdade(pessoa.DataNascimento) < 18)
                throw new DomainException($"Cadastro válido apenas para pessoas maiores de 18 anos");
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new DomainException($"O campo Nome é obrigatório");
            if (string.IsNullOrEmpty(pessoa.SobreNome))
                throw new DomainException($"O campo SobreNome é obrigatório");
            if (string.IsNullOrEmpty(pessoa.Cpf))
                throw new DomainException($"O campo Cpf é obrigatório");
            if (pessoa.Nome.Length < 5)
                throw new DomainException($"O campo Nome deve ter no mínimo 5 letras");
            if (CpfHelper.IsCpf(pessoa.Cpf) != true)
                throw new DomainException($"Permitido apenas Cpf válido");
        }

        public List<PessoaGetAllDto> GetAll()
        {
            var dto = Uow.PessoaRepository.GetAll().Select(p => new PessoaGetAllDto
            {
                Id = p.Id,
                Nome = p.Nome,
                SobreNome = p.SobreNome,
                DataNascimento = p.DataNascimento,
                Altura = p.Altura,
                Peso = p.Peso,
                Raca = p.Raca,
                Idade = DateTimeHelper.GetIdade(p.DataNascimento),
                UsuarioAtivo = p.UsuarioAtivo,  
                Cpf = p.Cpf,
                Filhos = p.Filhos
            }).ToList();

            return dto;
        }

        public void DeletarPessoa(int id)
        {
            if (Uow.PessoaRepository.ObterPessoaPorId(id) == null)
                throw new DomainException($"Id não encontrado");
            if (Uow.PessoaRepository.ObterPessoaPorId(id).UsuarioAtivo == true)
                throw new DomainException($"Não é possível deletar usuário Ativo");

            var deletePessoa = Uow.PessoaRepository.ObterPessoaPorId(id);
            Uow.PessoaRepository.Deletar(deletePessoa);
        }

        public PessoaGetAllDto GetPessoaId(int id)
        {
            var pessoaGetId = Uow.PessoaRepository.ObterPessoaPorId(id);
            if (pessoaGetId == null)
                throw new DomainException($"Id não encontrado");

            var dto = new PessoaGetAllDto
            {
                Id = pessoaGetId.Id,
                Nome = pessoaGetId.Nome,
                SobreNome = pessoaGetId.SobreNome,
                DataNascimento = pessoaGetId.DataNascimento,
                Altura = pessoaGetId.Altura,
                Peso = pessoaGetId.Peso,
                Raca = pessoaGetId.Raca,
                Idade = DateTimeHelper.GetIdade(pessoaGetId.DataNascimento),
                UsuarioAtivo = pessoaGetId.UsuarioAtivo,
                Cpf = pessoaGetId.Cpf,
                Filhos = pessoaGetId.Filhos
            };
            return dto;
        }

        public void AtualizarPessoa(int id, PessoaPatchDto patchDto)
        {
            if (Uow.PessoaRepository.ObterPessoaPorId(id) == null)
                throw new DomainException($"Id não encontrado");

            Pessoa pessoa = new Pessoa()
            {
                Nome = patchDto.Nome,
                SobreNome = patchDto.SobreNome,
                Cpf = patchDto.Cpf
            };

            Validate(pessoa);

            Uow.PessoaRepository.Atualizar(id, pessoa);
        }

        public void AtivarUsuario(int id)
        {
            var pessoa = Uow.PessoaRepository.ObterPessoaPorId(id);
            if (pessoa == null)
                throw new DomainException($"Id não encontrado");
            if (pessoa.UsuarioAtivo == true)
                throw new DomainException($"Usuário já está ativado");

            Uow.PessoaRepository.AtivarUsuario(id);
        }

        public void DesativarUsuario(int id)
        {
            var pessoa = Uow.PessoaRepository.ObterPessoaPorId(id);
            if (pessoa == null)
                throw new DomainException($"Id não encontrado");
            if (pessoa.UsuarioAtivo == false)
                throw new DomainException($"Usuário já está desativado");

            Uow.PessoaRepository.DesativarUsuario(id);
        }

        public void AdicionarFilho(int id, PessoaFilhosPutDto putFilhoDto)
        {
            var p = Uow.PessoaRepository.ObterPessoaPorId(id);
            if (p == null)
                throw new DomainException($"Id não encontrado");

            Pessoa pessoa = new Pessoa()
            {
                Id = IdHelper.GenerateId(),
                Nome = putFilhoDto.Nome,
                SobreNome = putFilhoDto.SobreNome,
                Cpf = putFilhoDto.Cpf,
                Altura = putFilhoDto.Altura,
                DataNascimento = putFilhoDto.DataNascimento,
                Peso = putFilhoDto.Peso,
                Raca = putFilhoDto.Raca,
                UsuarioAtivo = true
            };

            Validate(pessoa);

            Uow.PessoaRepository.AdicionarFilho(id, pessoa);
        }
    }
}
