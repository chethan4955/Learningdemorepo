using GadgetApp.Models;
using Microsoft.EntityFrameworkCore;
namespace GadgetApp.Data
{
    public class ApplicationDbContextDb :DbContext
    {
        public ApplicationDbContextDb(DbContextOptions<ApplicationDbContextDb> options) : base(options) { }
      public DbSet<Gadget> gadgets { get; set; }
        public DbSet<Category> categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gadget>()
                .Property(g => g.price)
                .HasPrecision(18, 2);
        }
    }
}
