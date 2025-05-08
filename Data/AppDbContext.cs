using Microsoft.EntityFrameworkCore;
using CampaniasCRUD_NET9.Models;

namespace CampaniasCRUD_NET9.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Campanias> Campanias { get; set; }
    }
}