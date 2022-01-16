using Microsoft.EntityFrameworkCore;

namespace coreTest.Models
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "filename =riche;");
            // "Initial Catalog=MyDb;" +
            // "Integrated Security=SSPI");
        }

       // Set-up Employee table 
        public DbSet<Employee> Employees { get; set; } 
    }
}   