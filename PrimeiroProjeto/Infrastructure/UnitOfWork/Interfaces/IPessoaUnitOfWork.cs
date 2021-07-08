using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork.Interfaces
{
    public interface IPessoaUnitOfWork
    {
        public IPessoaRepository PessoaRepository { get; }
    }
}
