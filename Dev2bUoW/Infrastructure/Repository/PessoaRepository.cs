using Domain.Entities;
using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly Dev2bDbContext _dev2BDbContext;

        public PessoaRepository(Dev2bDbContext dev2BDbContext)
        {
            _dev2BDbContext = dev2BDbContext;
        }

        public Pessoa Get(int id)
        {
            return _dev2BDbContext.Pessoas.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return _dev2BDbContext.Pessoas.Include(x => x.Endereco).AsNoTracking().ToList();
        }

        public void Post(Pessoa pessoa)
        {
            _dev2BDbContext.Pessoas.Add(pessoa);
        }
    }
}
