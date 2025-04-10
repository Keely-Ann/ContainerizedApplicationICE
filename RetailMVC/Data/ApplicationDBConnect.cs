using Microsoft.EntityFrameworkCore;
using RetailMVC.Models;

namespace RetailMVC.Data
{
    public class ApplicationDBConnect: DbContext
    {
        public ApplicationDBConnect(DbContextOptions<ApplicationDBConnect> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBConnect).Assembly);
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Products> Products { get; set; }
    }
}
