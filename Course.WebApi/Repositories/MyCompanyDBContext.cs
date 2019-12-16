using Microsoft.EntityFrameworkCore;
using Course.WebApi.Models;

namespace Course.WebApi.Repositories
{
    
    public class MyCompanyDbContext : DbContext
    {
        public MyCompanyDbContext(DbContextOptions<MyCompanyDbContext> options) : base(options)
        {
        }

        // DbSet 用來指定要使用的 table類別
        public DbSet<Employee> Employees { get; set; }
    }
}