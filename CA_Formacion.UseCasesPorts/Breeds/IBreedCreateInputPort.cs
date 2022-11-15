
using CA_Formacion.DTOs.Breeds;

namespace CA_Formacion.UseCasesPorts.Breeds
{
    public interface IBreedCreateInputPort
    {
        Task Handle(BreedCreateDTO data);
    }
}
