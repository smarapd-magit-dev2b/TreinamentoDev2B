using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository.Interface
{
   public interface  IPessoaRepository
    {
        //Listar todas as pessoas cadastradas----
        List<Pessoa> Get();
        
        //Buscar dados de uma pessoa pelo Id-----
        Pessoa GetId(int id);
        
        //Deletar uma pessoa pelo Id passado-----
        int Delete(int id);

       //Cadastrar uma pessoa-------------------
        int Post(Pessoa pessoa);

       //Editar uma pessoa pelo Id passado-----
       int Put(int id, Pessoa pessoa);

        //Serviço para Ativar o usuario--------
        int PutStatus(int id, bool status);

        //Atualizar apenas apenas as informações de Nome, Sobrenome e cpf
        int PutPeopleEssencial(int id, Pessoa pessoa);

      


    }
}
