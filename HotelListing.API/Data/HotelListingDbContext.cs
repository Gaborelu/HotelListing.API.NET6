using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                     Id = 2,
                     Name = "Italy",
                     ShortName = "IT"
                },
                new Country
                {
                    Id = 3,
                    Name = "Romania",
                    ShortName = "RO"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id =1,
                    Name = "Hotel Resort",
                    Address = "Avenu Str. 75",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel Costinesti",
                    Address = "Str. Fericirii nr.88",
                    CountryId = 3,
                    Rating = 4
                }
            );
        }
    }
}
