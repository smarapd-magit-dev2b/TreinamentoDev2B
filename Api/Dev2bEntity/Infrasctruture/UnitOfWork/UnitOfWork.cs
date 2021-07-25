using Infrasctruture.Model;
using Infrasctruture.Repository.Interfaces;
using Infrasctruture.UnitOfWork.Interfaces;

namespace Infrasctruture.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dev2bEntityDbContext _dev2BEntityDbContext;
        public IClienteRepository ClienteRepository { get; }
        public IProdutoRepository ProdutoRepository { get; }
        public IVendaRepository VendaRepository { get; }

        public UnitOfWork(Dev2bEntityDbContext dev2BEntityDbContext, IClienteRepository clienteRepository, IProdutoRepository produtoRepository, IVendaRepository vendaRepository)
        {
            _dev2BEntityDbContext = dev2BEntityDbContext;
            ClienteRepository = clienteRepository;
            ProdutoRepository = produtoRepository;
            VendaRepository = vendaRepository;
        }
        public void Commit()
        {
            _dev2BEntityDbContext.SaveChanges();
        }
    }
}
