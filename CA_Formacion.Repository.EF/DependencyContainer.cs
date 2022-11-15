
using CA_Formacion.DomainAbstractions;
using CA_Formacion.Entities.Interfaces;
using CA_Formacion.Entities.Interfaces.Dogs;
using CA_Formacion.Repository.EF.DataContexts;
using CA_Formacion.Repository.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CA_Formacion.Repository.EF
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<CA_FormacionContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("CA_Formacion")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IQueryDogsRepository, DogRepository>();
            services.AddScoped<IMutationDogsRepository, DogRepository>();
            services.AddScoped<IBreedRepository, BreedRepository>();
            return services;
        }
    }
}
