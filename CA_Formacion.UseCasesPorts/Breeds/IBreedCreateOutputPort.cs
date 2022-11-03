
using CA_Formacion.DTOs.Breeds;

namespace CA_Formacion.UseCasesPorts.Breeds
{
    public interface IBreedCreateOutputPort
    {
        Task Handle(BreedDTO breed);
    }
}
