using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyDearPet.Data.EF
{
    public class DearDbContextFactory : IDesignTimeDbContextFactory<DearDbContext>
    {
        public DearDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DearDbContext>();
            builder.UseSqlServer("Server=localhost;Database=my-dear-pet;Trusted_Connection=True;MultipleActiveResultSets=true",
                                 optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(DearDbContext).GetTypeInfo().Assembly.GetName().Name));
            return new DearDbContext(builder.Options);
        }
    }
}
