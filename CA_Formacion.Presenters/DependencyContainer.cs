using CA_Formacion.Presenters.Dogs;
using CA_Formacion.UseCasesPorts.Dogs;
using Microsoft.Extensions.DependencyInjection;

namespace CA_Formacion.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IDogCreateOutputPort, CreateDogPresenter>();
            return services;
        }
    }
}
