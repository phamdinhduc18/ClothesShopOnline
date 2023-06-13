using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
