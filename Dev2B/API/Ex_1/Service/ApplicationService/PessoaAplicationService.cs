using Commom.Dto;
using Common;
using Common.Dto;
using Common.Exceptions;
using Common.Helper;
using Domain.Entities;
using Infrastructure.UnitOfWork.Interface;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ApplicationService
{
   public class PessoaAplicationService : IPessoaAplicationService
   {

        private readonly IPessoaUnitOfWork _uow;
        public PessoaAplicationService(IPessoaUnitOfWork uow)
        {
            _uow = uow;
        }

        //Listar todas as pessoas cadastradas
        public List<PessoaGetDto> Get() => _uow.PessoaRepository.Get() != null ? _uow.PessoaRepository.Get()
            
                   .Select(p => new PessoaGetDto
                   {
                       Nome = p.Name,
                       SobreNome = p.LastName,
                       Altura = p.Height,
                       Peso = p.Weight,
                       DataNascimento = p.BirthDate,
                       UsuarioAtivo = p.Status,
                       DocumentoCpf = p.Cpf,
                       Id = p.Id,
                       Raca = p.Race,
                   }).ToList()
                   : throw new DomainException("Não há Pessoas cadastradas");


        //Buscar dados de uma pessoa pelo Id-----
        public PessoaGetDto GetPorCod(int cod)
        {
            CodigoValidate(cod);

            Pessoa pessoa = _uow.PessoaRepository.GetId(cod);

            return new PessoaGetDto()
            {
                Nome = pessoa.Name,
                SobreNome = pessoa.LastName,
                Altura = pessoa.Height,
                Peso = pessoa.Weight,
                DataNascimento = pessoa.BirthDate,
                UsuarioAtivo = pessoa.Status,
                DocumentoCpf = pessoa.Cpf,
                Id = pessoa.Id,
                Raca = pessoa.Race
            };
        }
        //Deletar uma pessoa pelo Id passado---
        public int Delete(int cod)
        {
            CodigoValidate(cod);

            if (_uow.PessoaRepository.GetId(cod).Status)
                throw new DomainException("Não é possível deletar usuários ativos");

            return _uow.PessoaRepository.Delete(cod);
        }

        //Cadastrar uma pessoa--------------------
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
        
        //Editar uma pessoa pelo Id passado------
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

       // Atualizar apenas apenas as informações de Nome, Sobrenome e cpf
        public int PutEssentialPerson(int codigo, PessoaPutEssencialDto pessoaDto)
        {
            CodigoValidate(codigo);

            PessoaValidateEssencial(pessoaDto);

            return _uow.PessoaRepository.PutPeopleEssencial(codigo, new Pessoa
            {
                Name = pessoaDto.Nome,
                LastName = pessoaDto.SobreNome,
                Cpf = pessoaDto.DocumentoCpf
            });
        }

        //Serviço para Ativar o usuario----------
        public int PutStatus(int codigo, bool usuario)
        {
            CodigoValidate(codigo);

            if (usuario == _uow.PessoaRepository.GetId(codigo).Status)
                throw new DomainException($"Pessoa com Código {codigo} {(usuario ? "já está ativa" : "já está desativada")}");

            return _uow.PessoaRepository.PutStatus(codigo, usuario);
        }


        //Validações-----------------------------
        private void CodigoValidate(int cod)
        {
            if (_uow.PessoaRepository.GetId(cod) == null)
                throw new DomainException($" O Código {cod} não existe");
        }

        private void PessoaValidateEssencial(PessoaPutEssencialDto pessoaDto)
        {
            if (string.IsNullOrEmpty(pessoaDto.Nome))
                throw new DomainException("O campo Nome deve ser preenchido");

            if (pessoaDto.Nome.Length < 5)
                throw new DomainException("O Nome não pode ter menos de 5 letras");

            if (string.IsNullOrEmpty(pessoaDto.SobreNome))
                throw new DomainException("O campo Sobrenome deve ser preenchido");

            if (string.IsNullOrEmpty(pessoaDto.DocumentoCpf))
                throw new DomainException("O campo Cpf deve ser preenchido");

            if (!CpfHelper.Valido(pessoaDto.DocumentoCpf))
                throw new DomainException("Cpf inválido");
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
                throw new DomainException("Só é aceito maiores de idade");
        }


       
    }
}
