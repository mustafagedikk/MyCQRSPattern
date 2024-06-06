using Microsoft.EntityFrameworkCore;
using MyCQRSPattern.DataAcces.Entities;

namespace MyCQRSPattern.DataAcces.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-C7ME16C;database=QRSPatternDb;integrated security=true;trustServerCertificate=true");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
