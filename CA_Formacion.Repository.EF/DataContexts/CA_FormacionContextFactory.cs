
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CA_Formacion.Repository.EF.DataContexts
{
    public class CA_FormacionContextFactory : IDesignTimeDbContextFactory<CA_FormacionContext>
    {
        public CA_FormacionContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CA_FormacionContext>();
            optionsBuilder.UseSqlite("Data Source=CA_Formacion.sqlite;Cache=Shared");
            return new CA_FormacionContext(optionsBuilder.Options);
        }
    }
}
