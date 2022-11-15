using CA_Formacion.Entities.Interfaces.Dogs;
using CA_Formacion.Entities.POCO;
using CA_Formacion.Repository.EF.DataContexts;

namespace CA_Formacion.Repository.EF.Repositories
{
    public class DogRepository : IQueryDogsRepository, IMutationDogsRepository
    {
        private readonly CA_FormacionContext _context;

        public DogRepository(CA_FormacionContext context) => _context = context;

        public Dog Create(Dog dog)
        {
            _context.Add(dog);
            _context.SaveChanges();
            return dog;
        }

        public Dog Delete(Dog dog)
        {
            _context.Remove(dog);
            return dog;
        }

        public Dog Get(int id)
        {
            return _context.Dogs.First(d => d.Id == id);
        }

        public IEnumerable<Dog> GetAll()
        {
            return _context.Dogs;
        }

        public Dog Update(Dog dog)
        {
            _context.Update(dog);
            return dog;
        }
    }
}
