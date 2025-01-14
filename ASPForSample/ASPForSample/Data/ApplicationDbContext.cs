using ASPForSample.Models.Entitites;
using Microsoft.EntityFrameworkCore;

namespace ASPForSample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
