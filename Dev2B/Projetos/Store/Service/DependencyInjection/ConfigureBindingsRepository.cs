﻿using Infrastructure.Repository;
using Infrastructure.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsRepository
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICostummerRepository, CostummerRepository>();
        }
    }
}
