using HRSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Persistence.Context // Rename the namespace to something more appropriate
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext // Inherit from the correct DbContext class
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        // Override OnModelCreating if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration can be done here
        }
    }
}
