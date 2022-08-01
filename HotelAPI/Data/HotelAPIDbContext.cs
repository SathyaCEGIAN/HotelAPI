using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Data
{
    public class HotelAPIDbContext : DbContext
    {
        public HotelAPIDbContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "Ind"
                },
                new Country
                {
                    Id = 2,
                    Name = "South Africa",
                    ShortName = "SA"
                },
                new Country
                {
                    Id = 3,
                    Name = "WestIndies",
                    ShortName = "WI"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel Winsten",
                    Address = "Velachery",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Karibean Hotel",
                    Address = "Cape Town",
                    CountryId = 2,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Black Hotel",
                    Address = "Havana",
                    CountryId = 3,
                    Rating = 4.5
                }
            );
        }
    }
}
