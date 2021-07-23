﻿using Infrasctruture.UnitOfWork.Interfaces;
using Infrasctruture.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection.Unitofwork
{
    public class ConfigureBindingsUnitOfWork
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
