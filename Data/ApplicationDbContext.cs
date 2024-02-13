using Microsoft.AspNetCore.Mvc; 
using Microsoft.EntityFrameworkCore;
using REST_API.Models;

public class ApplicationDbContext : DbContext
{
    // DbSets
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your model here using Fluent API if needed

            modelBuilder.Entity<User>()
                .Property(u => u.UserName)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(255);

            base.OnModelCreating(modelBuilder);
        }
}
