using GooWareRental.Core.Entities.Concretes;
using GooWareRental.Entities.Concretes;
using GooWareRental.Entities.Concretes.Motorcycle;
using Microsoft.EntityFrameworkCore;

namespace GooWareRental.DataAccessLayer.Contexts
{
    public class GooWareRentalContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Gear> Gears { get; set; }
        public DbSet<VechileType> VechileTypes { get; set; }

        public DbSet<MotorcycleBrand> MotorcycleBrands { get; set; }
        public DbSet<MotorcycleModel> MotorcycleModels { get; set; }
        public DbSet<MotorcyclePackage> MotorcyclePackages { get; set; }
        public DbSet<MotorcycleType> MotorcycleTypes { get; set; }

        public DbSet<Motorcycle> Motorcycles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("SERVER = .; DATABASE = GooWareRental; INTEGRATED SECURITY = TRUE");
    }
}
