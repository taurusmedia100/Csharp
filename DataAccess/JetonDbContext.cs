using Entities.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class JetonDbContext :IdentityDbContext<User>
    {
        public JetonDbContext(DbContextOptions<JetonDbContext> options):base(options) { }
        
        public DbSet<TokenPackage> TokenPackages { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
       
    }
}
