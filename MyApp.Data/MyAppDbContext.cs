using Microsoft.EntityFrameworkCore;
using MyApp.Model;

namespace MyApp.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Author> authors { get; set; }
    }
}
