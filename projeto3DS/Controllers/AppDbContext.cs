using Microsoft.EntityFrameworkCore;
using projeto3DS.Models;

namespace projeto3DS.Controllers
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
        public DbSet<Categoria> Categoria {  get; set; }
        public DbSet<Lanche> Lanche { get; set; }

    }
}
