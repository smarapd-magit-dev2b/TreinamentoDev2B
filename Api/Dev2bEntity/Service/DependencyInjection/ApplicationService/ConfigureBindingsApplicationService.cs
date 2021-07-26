using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.ApplicationService;
using Service.ApplicationService.Interfaces;

namespace Service.DependencyInjection.ApplicationService
{
    public class ConfigureBindingsApplicationService
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IClienteApplicationService, ClienteApplicationService>();
            services.AddScoped<IProdutoApplicationService, ProdutoApplicationService>();
            services.AddScoped<IVendaApplicationService, VendaApplicationService>();
        }
    }
}
