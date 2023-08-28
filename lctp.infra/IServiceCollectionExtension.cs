using lctp.infra.Context;
using lctp.infra.Repositories;
using lctp.infra.Services;
using lctp.libs.Interfaces;
using lctp.libs.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace lctp.infra
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services, string[]? args)
        {
            #region configuration file
#pragma warning disable CS8604 // Possível argumento de referência nula.
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddCommandLine(args)
                .Build();

#pragma warning restore CS8604 // Possível argumento de referência nula.
            #endregion

            #region JWT

            var key = Encoding.ASCII.GetBytes(config["SecretToken"]);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(
                x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            #endregion

            #region database
            services.AddDbContext<SQLServerDbContext>(options =>
            {
                options.UseSqlServer(config["ConnectionString:db"], b => b.MigrationsAssembly("lctp.infra"));
            });

            #endregion

            #region repositories

            services.AddScoped<IBaseRepository<UserModel>, UserRepository<UserModel>>();

            #endregion

            #region general

            services.AddSingleton<Settings, Settings>();
            services.AddScoped<TokenService, TokenService>();

            #endregion

            return services;
        }
    }
}
