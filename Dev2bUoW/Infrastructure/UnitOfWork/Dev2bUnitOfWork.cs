using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork.Interfaces;

namespace Infrastructure.UnitOfWork
{
    public class Dev2bUnitOfWork : IDev2bUnitOfWork
    {
        private readonly Dev2bDbContext _dev2BDbContext;
        public IPessoaRepository PessoaRepository { get; }
        public IEnderecoRepository EnderecoRepository { get; }

        public Dev2bUnitOfWork(Dev2bDbContext dev2BDbContext, IPessoaRepository pessoaRepository, IEnderecoRepository enderecoRepository)
        {
            _dev2BDbContext = dev2BDbContext;
            PessoaRepository = pessoaRepository;
            EnderecoRepository = enderecoRepository;
        }

        public void Commit()
        {
            _dev2BDbContext.SaveChanges();
        }
    }
}
