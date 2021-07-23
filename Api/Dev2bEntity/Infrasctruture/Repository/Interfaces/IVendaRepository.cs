using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Infrasctruture.Repository.Interfaces
{
    public interface IVendaRepository
    {
        IEnumerable<Venda> GetAll();
        Venda GetById(int id);
        void Post(Venda venda);
    }
}
