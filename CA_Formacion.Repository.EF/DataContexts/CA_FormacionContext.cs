
using CA_Formacion.Entities.POCO;
using Microsoft.EntityFrameworkCore;

namespace CA_Formacion.Repository.EF.DataContexts
{
    public class CA_FormacionContext : DbContext
    {
        public CA_FormacionContext(DbContextOptions<CA_FormacionContext> options) : base(options) { }

        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Dog> Dogs { get; set; }
    }
}
