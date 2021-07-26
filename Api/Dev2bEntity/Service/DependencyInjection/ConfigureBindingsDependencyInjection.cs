﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.DependencyInjection.ApplicationService;
using Service.DependencyInjection.Repository;
using Service.DependencyInjection.Unitofwork;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsApplicationService.RegisterBindings(services, configuration);
            ConfigureBindingsRepository.RegisterBindings(services, configuration);
            ConfigureBindingsUnitOfWork.RegisterBindings(services, configuration);
            ConfigureBindingsDatabaseContext.RegisterBindings(services, configuration);
        }
    }
}
