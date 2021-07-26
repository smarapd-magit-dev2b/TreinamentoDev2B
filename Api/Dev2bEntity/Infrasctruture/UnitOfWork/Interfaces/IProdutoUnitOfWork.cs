using System;
using System.Collections.Generic;
using System.Text;
using Infrasctruture.Repository.Interfaces;

namespace Infrasctruture.UnitOfWork.Interfaces
{
    public interface IProdutoUnitOfWork
    {
        IProdutoRepository ProdutoRepository { get; }
        void Commit();
    }
}
