using Microsoft.EntityFrameworkCore;

namespace Red_Dead_Redemption_2.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
        : base(options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData(
            new Country{ CountryId= 1, Name = "United States of America" },
            new Country { CountryId = 2, Name = "Japan" },
            new Country { CountryId = 3, Name = "Canada" },
            new Country { CountryId = 4, Name = "Turkey" },
            new Country { CountryId = 5, Name = "Poland" }
        );
    }
}