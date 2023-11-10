using Microsoft.EntityFrameworkCore;
using Models.Entities.DerivedEntities;
using System.Reflection;

namespace Databases.Contexts
{
    public class TourDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(AppSettings.MyConfigurations.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<BankCard> BankCards { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarTour> CarTours { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Tourist> Tourists { get; set; }
        public virtual DbSet<Tourleader> Tourleaders { get; set; }
        public virtual DbSet<TourLocation> TourLocations { get; set; }

    }
}
