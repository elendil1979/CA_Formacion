
using CA_Formacion.Entities.POCO;

namespace CA_Formacion.DTOs.Breeds
{
    public class BreedDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BreedDTO(Breed breed)
        {
            Id = breed.Id;
            Name = breed.Name;
        }
    }
}
