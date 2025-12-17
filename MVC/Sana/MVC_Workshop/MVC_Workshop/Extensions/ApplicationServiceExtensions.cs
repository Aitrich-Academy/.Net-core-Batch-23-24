using Microsoft.EntityFrameworkCore;
using MVC_Workshop.Interfaces;
using MVC_Workshop.Repositories;
using MVC_Workshop.Services;

namespace MVC_Workshop.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Data.AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IPublicService, PublicService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IJobRepository, JobRepository>();

            return services;
        }
    }
}
