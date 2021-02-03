using Microsoft.EntityFrameworkCore;
using Warungcd.Models;

namespace Warungcd.Data
{
   public class WarungCdContext : DbContext
    {
        public WarungCdContext (DbContextOptions<WarungCdContext> options)
            : base(options)
        {
            
        }

        public DbSet<Barang> Barang { get; set; }
    }
    
}