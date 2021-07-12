using Common.DomainException;
using Common.DTO;
using Domain.Entities;
using Domain.Helpers;
using Infrastructure.UnitOfWork;
using Service.ApplicationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.ApplicationService {
    public class PessoaApplicationService : IPessoaApplicationService {
        private readonly IPessoaUnitOfWork UnitOfWork;

        public PessoaApplicationService(IPessoaUnitOfWork unitofwork) {
            UnitOfWork = unitofwork;
        }

        //Cadastrar novas pessoas no sistema
        public int Cadastrar(PessoaPostDTO pessoaDTO) {
            Random idrandom = new Random();

            Pessoa pessoa = new Pessoa() {
                Id = Convert.ToInt32(idrandom.Next(1, 100)),
                Nome = pessoaDTO.Nome,
                SobreNome = pessoaDTO.SobreNome,
                DataNascimento = pessoaDTO.DataNascimento,
                Altura = pessoaDTO.Altura,
                Peso = pessoaDTO.Peso,
                Raca = pessoaDTO.Raca,
                UsuarioAtivo = true,
                Cpf = pessoaDTO.Cpf
            };

            Validate(pessoa);

            UnitOfWork.PessoaRepository.Adicionar(pessoa);

            return pessoa.Id;
        }

        //Listar todas as pessoas cadastradas no sistema
        List<PessoaGetAllDTO> IPessoaApplicationService.Listar() {
            var dto = UnitOfWork.PessoaRepository.Listar().Select(x => new PessoaGetAllDTO {
                Nome = x.Nome,
                SobreNome = x.SobreNome,
                Altura = x.Altura,
                Peso = x.Peso,
                DataNascimento = x.DataNascimento,
                UsuarioAtivo = x.UsuarioAtivo,
                Cpf = x.Cpf,
                Id = x.Id,
                Raca = x.Raca,
                Idade = DateTimeHelper.Idade(x.DataNascimento),
                Filhos = x.Filhos
            }).ToList();

            return dto;
        }

        //Validar os dados da pessoa para cadastro
        private static void Validate(Pessoa pessoa) {
            if (string.IsNullOrEmpty(pessoa.Nome))
                throw new DomainException("O Campo Nome é obrigatório...");
            if (string.IsNullOrEmpty(pessoa.SobreNome))
                throw new DomainException("O Campo Sobrenome é obrigatório...");
            if (string.IsNullOrEmpty(pessoa.Cpf))
                throw new DomainException("O Campo CPF é obrigatório...");
            if (DateTimeHelper.Idade(pessoa.DataNascimento) < 18)
                throw new DomainException("Impossivel cadastrar pessoas menor de idade...");
            if (pessoa.Nome.Length < 5)
                throw new DomainException("Nome com no mínimo 5 caracteres");
            if (ValidarCPF(pessoa.Cpf) == false)
                throw new DomainException("Somente CPF valido...");
        }

        //Validadar o CPF da pessoa
        private static bool ValidarCPF(string cpf) {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        //Validar o ID do cadastro
        private void ValidarID(int id) {
            if (UnitOfWork.PessoaRepository.ObterPessoaPorID(id) == null)
                throw new DomainException("ID não encontrado...");
            if (UnitOfWork.PessoaRepository.ObterPessoaPorID(id).UsuarioAtivo == true)
                throw new DomainException("Impossível remover alguem com usuario ativo...");
        }

        //Deletar o cadastro
        public int Deletar(int id) {
            ValidarID(id);
            var deletarid = UnitOfWork.PessoaRepository.ObterPessoaPorID(id);
            UnitOfWork.PessoaRepository.Deletar(deletarid);
            return id;

        }

        List<PessoaGetIdDTO> IPessoaApplicationService.ListarPessoaPorID(int id) {
            var listarporid = UnitOfWork.PessoaRepository.ListarPessoaPorID().Where(x => x.Id == id)
                .Select(x => new PessoaGetIdDTO {
                    Nome = x.Nome,
                    SobreNome = x.SobreNome,
                    Altura = x.Altura,
                    Peso = x.Peso,
                    DataNascimento = x.DataNascimento,
                    UsuarioAtivo = x.UsuarioAtivo,
                    Cpf = x.Cpf,
                    Id = x.Id,
                    Raca = x.Raca,
                    Idade = DateTimeHelper.Idade(x.DataNascimento),
                    Filhos = x.Filhos
                }).ToList();

            if (listarporid.Count == 0)
                throw new DomainException("ID não encontrado...");
            else
                return listarporid;
        }

        public int Editar(int id, PessoaPutDTO pessoaDTO) {
            if (UnitOfWork.PessoaRepository.ObterPessoaPorID(id) == null)
                throw new DomainException("ID não encontrado...");

            Pessoa pessoas = new Pessoa() {
                Nome = pessoaDTO.Nome,
                SobreNome = pessoaDTO.SobreNome,
                DataNascimento = pessoaDTO.DataNascimento,
                Altura = pessoaDTO.Altura,
                Peso = pessoaDTO.Peso,
                Raca = pessoaDTO.Raca,
                Cpf = pessoaDTO.Cpf
            };

            Validate(pessoas);
            UnitOfWork.PessoaRepository.Editar(id, pessoas);
            return pessoas.Id;
        }

        public int EditarNomeSobrenomeCpf(int id, PessoaNomeSobrenomeCpfPatchDTO pessoaDTO) {
            if (UnitOfWork.PessoaRepository.ObterPessoaPorID(id) == null)
                throw new DomainException("ID não encontrado...");

            Pessoa pessoa = new Pessoa() {
                Nome = pessoaDTO.Nome,
                SobreNome = pessoaDTO.SobreNome,
                Cpf = pessoaDTO.Cpf
            };

            Validate(pessoa);
            UnitOfWork.PessoaRepository.EditarNomeSobrenomeCpf(id, pessoa);
            return pessoa.Id;
        }

        public int StatusUsuario(int id) {
            var pessoa = UnitOfWork.PessoaRepository.ObterPessoaPorID(id);
            if (pessoa == null)
                throw new DomainException("ID não encontrado...");

            UnitOfWork.PessoaRepository.UsuarioStatusRepository(id);
            return pessoa.Id;
        }

        public void CadastrarFilhos(int id, PessoasFilhosDTO pessoaDTO) {
            if (UnitOfWork.PessoaRepository.ObterPessoaPorID(id) == null)
                throw new DomainException("ID não encontrado...");
            
            Random idrandom = new Random();

            Pessoa pessoa = new Pessoa() {
                Id = Convert.ToInt32(idrandom.Next(1, 100)),
                Nome = pessoaDTO.Nome,
                SobreNome = pessoaDTO.SobreNome,
                DataNascimento = pessoaDTO.DataNascimento,
                Altura = pessoaDTO.Altura,
                Peso = pessoaDTO.Peso,
                Raca = pessoaDTO.Raca,
                UsuarioAtivo = true,
                Cpf = pessoaDTO.Cpf
            };
            Validate(pessoa);

            UnitOfWork.PessoaRepository.AdicionarFilhos(id, pessoa);
        }
    }
}

