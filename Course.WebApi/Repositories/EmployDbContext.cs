using Microsoft.EntityFrameworkCore;
using Course.WebApi.Models;

namespace Course.WebApi.Repositories
{
    
    public class EmployDbContext : DbContext
    {
        public EmployDbContext(DbContextOptions<EmployDbContext> options) : base(options)
        {
        }

        // DbSet 用來指定要使用的 table類別
        public DbSet<Employ> Employs { get; set; }
    }
}