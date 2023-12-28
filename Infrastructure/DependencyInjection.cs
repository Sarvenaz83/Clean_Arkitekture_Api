using Infrastructure.Database.Database;
using Infrastructure.Database.Repositories.Authorization;
using Infrastructure.Database.Repositories.BirdRepository;
using Infrastructure.Database.Repositories.CatRepository;
using Infrastructure.Database.Repositories.DogRepository;
using Infrastructure.Database.Repositories.UserRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {


            services.AddDbContext<MyAppDbContext>(options =>
            {
                var connectionString = "Server=MINAZ\\SQLEXPRESS; Database=CleanArkitektureAPI; Trusted_Connection=true; TrustServerCertificate=true;";
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IDogRepository, DogRepository>();
            services.AddScoped<ICatRepository, CatRepository>();
            services.AddScoped<IBirdRepository, BirdRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();


            return services;
        }
    }
}
