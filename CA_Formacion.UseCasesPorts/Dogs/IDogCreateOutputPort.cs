
using CA_Formacion.DTOs.Dogs;

namespace CA_Formacion.UseCasesPorts.Dogs
{
    public interface IDogCreateOutputPort
    {
        Task Handle(DogDTO dog);
    }
}
