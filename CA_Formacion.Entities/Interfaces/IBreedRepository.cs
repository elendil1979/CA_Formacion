
using CA_Formacion.Entities.POCO;

namespace CA_Formacion.Entities.Interfaces
{
    public interface IBreedRepository
    {
        public Breed Get(int id);
        public IEnumerable<Breed> GetAll();
        public Breed Create(Breed breed);
    }
}
