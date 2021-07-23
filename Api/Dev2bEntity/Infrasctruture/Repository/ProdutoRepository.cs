using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Infrasctruture.Model;
using Infrasctruture.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrasctruture.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Dev2bEntityDbContext _dev2BEntityDbContext;

        public ProdutoRepository(Dev2bEntityDbContext dev2BEntityDbContext)
        {
            _dev2BEntityDbContext = dev2BEntityDbContext;
        }

        public void Delete(Produto produto)
        {
            _dev2BEntityDbContext.Produtos.Remove(produto);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _dev2BEntityDbContext.Produtos.AsNoTracking().ToList();
        }

        public Produto GetById(int id)
        {
            return _dev2BEntityDbContext.Produtos.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Post(Produto produto)
        {
            _dev2BEntityDbContext.Produtos.Add(produto);
        }

        public void Put(Produto produto)
        {
            _dev2BEntityDbContext.Produtos.Update(produto);
        }
    }
}
