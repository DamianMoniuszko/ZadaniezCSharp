using Pierwsza_Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Pierwsza_Web.Data
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}