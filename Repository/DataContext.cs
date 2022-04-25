using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace Repository
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
