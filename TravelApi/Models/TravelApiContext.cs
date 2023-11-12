using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Review> Reviews { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, Description = "So fun wow", Country = "Guyana", City = "Purple", Rating = 5 },
          new Review { ReviewId = 2, Description = "Bad place", Country = "Canada", City = "Montreal", Rating = 5 },
          new Review { ReviewId = 3, Description = "Meow", Country = "India", City = "Hyderabad", Rating = 4 },
          new Review { ReviewId = 4, Description = ".....", Country = "Barf", City = "Bile", Rating = 1 },
          new Review { ReviewId = 5, Description = "Sweet", Country = "Jamaica", City = "Kingston", Rating = 5 }
        );
    }
  }
}