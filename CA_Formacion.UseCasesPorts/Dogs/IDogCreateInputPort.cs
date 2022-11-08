using CA_Formacion.DTOs.Dogs;

namespace CA_Formacion.UseCasesPorts.Dogs
{
    public interface IDogCreateInputPort
    {
        Task Handle(CreateDogDTO dog);
    }
}
