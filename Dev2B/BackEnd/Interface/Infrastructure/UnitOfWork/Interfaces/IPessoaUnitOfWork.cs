using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface IPessoaUnitOfWork
    {
        IPessoaRepository PessoaRepository { get; }
    }
}
