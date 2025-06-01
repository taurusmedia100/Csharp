using Entities.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class JetonDbContext :IdentityDbContext<User>
    {
        public JetonDbContext(DbContextOptions<JetonDbContext> options):base(options) { }
        
        public DbSet<JetonPackage> JetonPackages { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Token> Tokens { get; set; }
        
        public DbSet<UserJetonPackage> UserJetonPackages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Pivot cədvəl üçün mürəkkəb açar (Composite Key)
            modelBuilder.Entity<UserJetonPackage>()
                .HasKey(x => new { x.UserId, x.JetonPackageId });

            // Əlaqələr
            modelBuilder.Entity<UserJetonPackage>()
                .HasOne(x => x.Users)
                .WithMany(u => u.UserJetonPackages)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserJetonPackage>()
                .HasOne(x => x.JetonPackage)
                .WithMany(j => j.UserJetonPackages)
                .HasForeignKey(x => x.JetonPackageId);

            // Purchase əlaqələri (əgər ayrıca purchase qeyd edilirsə)
            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.User)
                .WithMany(u => u.Purchases)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.JetonPackage)
                .WithMany(j => j.Purchases)
                .HasForeignKey(p => p.JetonPackageId);
        }



    }
}
