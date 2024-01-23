using Microsoft.EntityFrameworkCore;
using Olx.Domain.Entities;

namespace Olx.Data.OlexDBContext
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Username=postgres; Password=root123; Database=Olex;");
        }

        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
