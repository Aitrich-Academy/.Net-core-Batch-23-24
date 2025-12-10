

using JWT;
using JWT.Interface;
using JWT.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;



namespace HireMeNow_WebApi.Extensions
{
    public static class ApplicationServiceExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );



            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<Context>();
            services.AddScoped<Itok,tok>();
            services.AddScoped<tok>();

            return services;
        }
    }
}
