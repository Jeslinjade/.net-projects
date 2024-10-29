using Microsoft.EntityFrameworkCore;

namespace EfcorecodefirstapproachDemo01.Models
{
    public class EmployeeDbContext: DbContext
        {
            public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
            {
            }
            public DbSet<EmployeeModel> employees { get; set; }
        }
}
