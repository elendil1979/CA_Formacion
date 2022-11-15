
using CA_Formacion.UseCases.Breeds;
using CA_Formacion.UseCases.Dogs;
using CA_Formacion.UseCasesPorts.Breeds;
using CA_Formacion.UseCasesPorts.Dogs;
using Microsoft.Extensions.DependencyInjection;

namespace CA_Formacion.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUsesCases(this IServiceCollection services)
        {
            services.AddTransient<IDogCreateInputPort, DogCreateInteractor>();
            services.AddTransient<IBreedCreateInputPort, BreedCreateInteractor>();
            return services;
        }
    }
}
