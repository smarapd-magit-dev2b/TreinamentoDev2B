using Infrasctruture.UnitOfWork;
using Infrasctruture.UnitOfWork.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection.Unitofwork
{
    public class ConfigureBindingsUnitOfWork
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IClienteUnitOfWork, ClienteUnitOfWork>();
            services.AddScoped<IProdutoUnitOfWork, ProdutoUnitOfWork>();
            services.AddScoped<IVendaUnitOfWork, VendaUnitOfWork>();
        }
    }
}
