using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_Formacion.Entities.Interfaces;
using CA_Formacion.Entities.POCO;
using CA_Formacion.Repository.EF.DataContexts;

namespace CA_Formacion.Repository.EF.Repositories
{
    public class BreedRepository : IBreedRepository
    {

        private readonly CA_FormacionContext _context;

        public BreedRepository(CA_FormacionContext context) => _context = context;

        public Breed Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Breed> GetAll()
        {
            throw new NotImplementedException();
        }

        public Breed Create(Breed breed)
        {
            _context.Add(breed);
            return breed;
        }
    }
}
