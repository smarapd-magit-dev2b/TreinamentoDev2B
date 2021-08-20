using Infrastructure.UnitOfWork;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsUnitOfWork
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            _ = services.AddScoped<IUserUnitOfWork, UserUnitOfWork>();
            _ = services.AddScoped<ITeacherUnitOfWork, TeacherUnitOfWork>();
        }
    }
}
