using System;
using System.Collections.Generic;
using System.Text;
using Infrasctruture.Repository.Interfaces;

namespace Infrasctruture.UnitOfWork.Interfaces
{
    public interface IClienteUnitOfWork
    {
        IClienteRepository ClienteRepository { get; }
        void Commit();
    }
}
