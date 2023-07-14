using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options){} 
        
    }
}