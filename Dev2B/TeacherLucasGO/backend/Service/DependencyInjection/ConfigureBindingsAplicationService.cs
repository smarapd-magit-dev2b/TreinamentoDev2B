﻿using Microsoft.Extensions.DependencyInjection;
using Service.AplicationService;
using Service.AplicationService.Interfaces;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsAplicationService
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<IUserAplicationService, UserAplicationService>();
        }
    }
}
