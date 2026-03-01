using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace App.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<DamageReports> DamageReports { get; set; }

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
    }
}
