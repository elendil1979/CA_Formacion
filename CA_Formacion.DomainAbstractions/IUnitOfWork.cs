
namespace CA_Formacion.DomainAbstractions
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
