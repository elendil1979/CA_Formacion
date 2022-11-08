using CA_Formacion.DTOs.Dogs;
using CA_Formacion.UseCasesPorts.Dogs;

namespace CA_Formacion.UseCases.Dogs
{
    public class MockDogCreateInteractor : IDogCreateInputPort
    {
        public Task Handle(CreateDogDTO dog)
        {
            Console.WriteLine("mock");
            return Task.CompletedTask;
        }
    }
}
