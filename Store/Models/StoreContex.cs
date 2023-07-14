using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Phones { get; set; }
       
        
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options){} 
        
    }
}