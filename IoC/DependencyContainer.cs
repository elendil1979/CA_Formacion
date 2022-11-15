using CA_Formacion.Presenters;
using CA_Formacion.Repository.EF;
using CA_Formacion.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAllServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddPresenters();
            services.AddUsesCases();
            return services;
        }
    }
}
