using DapperTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace DapperTest.Context
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Companies");
        }

        DbSet<Company> Companies { get; set; }
    }
}
