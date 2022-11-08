
using CA_Formacion.DTOs.Dogs;
using CA_Formacion.Presenters.Abstractions;
using CA_Formacion.UseCasesPorts.Dogs;

namespace CA_Formacion.Presenters.Dogs
{
    public class CreateDogPresenter: IDogCreateOutputPort, IPresenter<DogDTO>
    {
        public DogDTO Content { get; private set; }

        public Task Handle(DogDTO dog)
        {
            Content = dog;
            return Task.CompletedTask;
        }

        
    }
}
