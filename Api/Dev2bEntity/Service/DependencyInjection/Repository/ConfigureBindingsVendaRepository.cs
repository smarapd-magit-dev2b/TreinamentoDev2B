using System;
using System.Collections.Generic;
using System.Text;
using Infrasctruture.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection.Repository
{
    public class ConfigureBindingsVendaRepository
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IVendaRepository, VendaRepository>();
        }
    }
}
