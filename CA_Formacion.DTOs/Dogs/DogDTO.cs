using CA_Formacion.DTOs.Breeds;

namespace CA_Formacion.DTOs.Dogs
{
    public class DogDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BreedDTO Breed { get; set; }
    }
}
