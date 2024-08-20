using Microsoft.EntityFrameworkCore;
using ProjectoSO.Pages;

namespace ProjectoSO.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Producto> Products { get; set; }
    }
}
