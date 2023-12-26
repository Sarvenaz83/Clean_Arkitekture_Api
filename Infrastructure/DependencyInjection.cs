using Infrastructure.Database.Database;
using Infrastructure.Database.Repositories.BirdRepository;
using Infrastructure.Database.Repositories.CatRepository;
using Infrastructure.Database.Repositories.DogRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<MyAppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Server=MINAZ\\SQLEXPRESS; Database=CleanArkitektureAPI; Trusted_Connection=true; TrustServerCertificate=true;")));
            services.AddScoped<IDogRepository, DogRepository>();
            services.AddScoped<ICatRepository, CatRepository>();
            services.AddScoped<IBirdRepository, BirdRepository>();


            return services;
        }
    }
}
