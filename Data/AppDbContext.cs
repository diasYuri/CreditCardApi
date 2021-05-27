using CreditCardApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CreditCardApi.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<CreditCard>()
          .HasIndex(c => c.CardNumber)
          .IsUnique();
    }

    public DbSet<CreditCard> CreditCards { get; set; }

  }
}