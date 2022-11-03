
using CA_Formacion.Entities.POCO;

namespace CA_Formacion.Entities.Interfaces.Dogs
{
    public interface IMutationDogsRepository
    {
        public Dog Create(Dog dog);
        public Dog Update(Dog dog);
        public bool Delete(Dog dog);
    }
}
