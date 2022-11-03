
using CA_Formacion.Entities.POCO;

namespace CA_Formacion.Entities.Interfaces.Dogs
{
    public interface IQueryDogsRepository
    {
        public Dog Get(int id);
        public IEnumerable<Dog> GetAll();
    }
}
