using CA_Formacion.DomainAbstractions;
using CA_Formacion.Repository.EF.DataContexts;

namespace CA_Formacion.Repository.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CA_FormacionContext _context;

        public UnitOfWork(CA_FormacionContext context) => _context = context;
        
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
