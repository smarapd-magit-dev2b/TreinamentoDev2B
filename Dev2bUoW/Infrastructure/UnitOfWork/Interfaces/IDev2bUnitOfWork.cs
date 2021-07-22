using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface IDev2bUnitOfWork
    {
        IPessoaRepository PessoaRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        void Commit();
    }
}
