using Microsoft.EntityFrameworkCore;
using TcknoCheckApp.Models.Concrete;

namespace TcknoCheckApp.DataAccess.EFramework.Contexts
{
    public class PortalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=T1LPRVT4970;Database=Portal;Trusted_Connection=true");
        }
        public DbSet<Portal> Portals { get; set; }
        public DbSet<Starbuck> Starbucks { get; set; }
    }
}
