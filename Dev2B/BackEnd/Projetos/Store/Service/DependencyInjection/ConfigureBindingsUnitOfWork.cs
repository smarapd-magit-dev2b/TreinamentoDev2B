﻿using Infrastructure.UnitOfWork;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsUnitOfWork
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICustomerUnitOfWork, CustomerUnitOfWork>();
            services.AddScoped<IProductUnitOfWork, ProductUnitOfWork>();
            services.AddScoped<ISaleUnitOfWork, SaleUnitOfWork>();
        }
    }
}
