using lctp.core.Services;
using lctp.infra.Repositories;
using lctp.libs.Interfaces;
using lctp.libs.Models;
using Microsoft.Extensions.DependencyInjection;

namespace lctp.core
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            #region services
            services.AddScoped<LoginService,LoginService>();
            #endregion

            return services;
        }
    }
}
