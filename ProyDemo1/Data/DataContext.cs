using Microsoft.EntityFrameworkCore;
using ProyDemo1.Data.Entity;

namespace ProyDemo1.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet <Country> Countres { set; get; }

        public DbSet<Product> Products { set; get; }

    }
}
