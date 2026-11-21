using Microsoft.EntityFrameworkCore;
using SistemaProductos.Models;
namespace SistemaProductos.Data
{
    public class ApplicationDbContext : DbContext
    { public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Producto> Productos { get; set; } }
}

