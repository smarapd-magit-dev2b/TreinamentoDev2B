using Domain.Entities;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces {
    public interface IPessoaRepository {

        void Adicionar(Pessoa pessoa);
        List<Pessoa> Listar();

        Pessoa ObterPessoaPorID(int id);

        void Deletar(Pessoa pessoa);

        List<Pessoa> ListarPessoaPorID();

        void Editar(int id, Pessoa pessoa);
        void EditarNomeSobrenomeCpf(int id, Pessoa pessoa);
        void UsuarioStatusRepository(int id);
        void AdicionarFilhos(int id, Pessoa pessoa);

        
    }
}
