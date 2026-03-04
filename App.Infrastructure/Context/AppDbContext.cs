using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace App.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<DamageReports> DamageReports { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {
        }
            
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppDbReleased;Integrated Security=True;TrustServerCertificate=True;",
                sqlOptions => sqlOptions.EnableRetryOnFailure());
     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "In-progress" },
                new Status { Id = 2, Name = "On-hold" },
                new Status { Id = 3, Name = "Completed" });
        }
    }
}
