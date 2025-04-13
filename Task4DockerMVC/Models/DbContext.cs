using Microsoft.EntityFrameworkCore;

namespace Task4DockerMVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<EnergyDrinkBrand> EnergyDrinkBrands { get; set; }
        public DbSet<EnergyDrinks> EnergyDrinks { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}