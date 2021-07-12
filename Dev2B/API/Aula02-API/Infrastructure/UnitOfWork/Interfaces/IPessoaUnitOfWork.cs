using Infrastructure.Repository.Interfaces;

namespace Infrastructure.UnitOfWork {
    public interface IPessoaUnitOfWork {

        IPessoaRepository PessoaRepository { get; }
    }
}
