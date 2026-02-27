using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Context
{
    public class AppDbContextFactory
        : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=AppDbRelease;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
