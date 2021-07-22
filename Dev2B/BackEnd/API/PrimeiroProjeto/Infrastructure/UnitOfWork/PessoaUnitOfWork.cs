using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork
{
    public class PessoaUnitOfWork : IPersonUnitOfWork
    {
        public IPersonRepository PersonRepository { get; }

        public PessoaUnitOfWork(IPersonRepository pessoaRepository) => PersonRepository = pessoaRepository;
    }
}
