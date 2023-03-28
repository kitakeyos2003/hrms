using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
