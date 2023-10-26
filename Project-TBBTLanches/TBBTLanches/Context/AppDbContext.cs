using Microsoft.EntityFrameworkCore;
using TBBTLanches.Models;

namespace TBBTLanches.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Lanches> Lanches { get; set; }

    }
}
