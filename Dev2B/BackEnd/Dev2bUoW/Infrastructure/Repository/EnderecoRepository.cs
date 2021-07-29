using Domain.Entities;
using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly Dev2bDbContext _dev2BDbContext;

        public EnderecoRepository(Dev2bDbContext dev2BDbContext)
        {
            _dev2BDbContext = dev2BDbContext;
        }

        public IEnumerable<Endereco> GetAll()
        {
            return _dev2BDbContext.Enderecos.AsNoTracking().ToList();
        }

        public void Post(Endereco endereco)
        {
            _dev2BDbContext.Enderecos.Add(endereco);
        }

        public Endereco GetByCep(string cep)
        {
            return _dev2BDbContext.Enderecos.AsNoTracking().FirstOrDefault(x => x.Cep == cep);
        }

        public void Put(Endereco endereco)
        {
            _dev2BDbContext.Enderecos.Update(endereco);
        }
    }
}
