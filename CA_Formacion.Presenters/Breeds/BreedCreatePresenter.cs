
using CA_Formacion.DTOs.Breeds;
using CA_Formacion.Presenters.Abstractions;
using CA_Formacion.UseCasesPorts.Breeds;

namespace CA_Formacion.Presenters.Breeds
{
    public class BreedCreatePresenter : IBreedCreateOutputPort, IPresenter<BreedDTO>
    {
        public BreedDTO Content { get; private set; }

        public Task Handle(BreedDTO breed)
        {
            Content = breed;
            return Task.CompletedTask;
        }

    }
}
