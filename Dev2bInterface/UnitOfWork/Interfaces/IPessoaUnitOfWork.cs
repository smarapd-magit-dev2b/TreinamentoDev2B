using Infrastructure.Repository.Interface;

namespace Infrastructure.UnitOfWork.Interface
{
    public interface IPessoaUnitOfWork
    {
        IPessoaRepository PessoaRepository { get; }
    }
}
