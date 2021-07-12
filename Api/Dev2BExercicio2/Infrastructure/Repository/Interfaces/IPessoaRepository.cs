using System.Collections.Generic;
using Common.Entities;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        void Adicionar(Pessoa pessoa);
        void AdicionarFilho(int id, Pessoa filho);
        void Deletar(Pessoa pessoa);
        void Editar(int id, Pessoa pessoa);
        void Atualizar(int id, Pessoa pessoa);
        void AtivarUsuario(int id);
        void DesativarUsuario(int id);
        Pessoa ObterPessoaPorId(int id);
        List<Pessoa> GetAll();
    }
}
