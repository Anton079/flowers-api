using flowers_api.Flowers.Models;
using Microsoft.EntityFrameworkCore;

namespace flowers_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Flower> Flower { get; set; }
    }
}
