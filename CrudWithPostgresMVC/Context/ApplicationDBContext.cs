using CrudWithPostgresMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWithPostgresMVC.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> users { get; set; }
    }
}
