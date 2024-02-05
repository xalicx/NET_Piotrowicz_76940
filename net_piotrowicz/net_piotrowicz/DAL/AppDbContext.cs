using Microsoft.EntityFrameworkCore;
using net_piotrowicz.Models;

namespace net_piotrowicz.DAL
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options) { 
        
        }

        public virtual DbSet <Product> Products { get; set; }
    }
}
