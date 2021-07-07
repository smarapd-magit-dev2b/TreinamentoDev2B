using Commom.Dto;
using Infrastructure.UnitOfWork.Interfaces;
using Service.ApplicationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.ApplicationService
{
    public class PessoaApplicationService : IPessoaApplicationService
    {
        private readonly IPessoaUnitOfWork Uow;

        public PessoaApplicationService(IPessoaUnitOfWork uow) => Uow = uow;

        public int Adicionarpessoa(PessoaPostDto pessoa)
        {
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new Exception("O Campo Nome é obrigatório");

            if (string.IsNullOrEmpty(pessoa.SobreNome))
                throw new Exception("O Campo Sobrenome é obrigatório");

            if (string.IsNullOrEmpty(pessoa.Cpf))
                throw new Exception("O Campo Cpf é obrigatório");

            Uow.PessoaRepository.Adicionar(pessoa);

            return pessoa.Id;
        }

        public List<PessoaGetAllDto> GetAll()
        {
            var lista = Uow.PessoaRepository.GetAll.Select(p => new PessoaGetAllDto { 
                Id = p.Id,
                Nome = p.Nome,
                SobreNome = p.SobreNome,
                DataNascimento = p.DataNascimento,
                Altura = p.Altura,
                Peso = p.Peso,
                Raca = p.Raca,
                UsuarioAtivo = p.UsuarioAtivo,
                Cpf = p.Cpf
            }).ToList();
            return lista;
        }
    }
}
