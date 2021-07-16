using Commom.Dto;
using Common;
using Common.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IPessoaAplicationService
    {

        //Listar todas as pessoas cadastradas
        List<PessoaGetDto> Get();

        //Buscar dados de uma pessoa pelo Id-----
        PessoaGetDto GetPorCod(int cod);

        //Deletar uma pessoa pelo Id passado-----
        int Delete(int cod);

        //Cadastrar uma pessoa--------------------
        int Post(PessoaPostDto pessoa);

        //Editar uma pessoa pelo Id passado-------
        int Put(int cod, PessoaPostDto pessoa);

        // Serviço para Ativar o usuario---------
        int PutStatus(int cod, bool status);
        
        //Atualizar apenas apenas as informações de Nome, Sobrenome e cpf
        int PutEssentialPerson(int cod, PessoaPutEssencialDto pessoa);

    }
}
