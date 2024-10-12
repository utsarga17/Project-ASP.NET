using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstateListing.Models;

namespace RealEstateListing.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<RealEstate> Properties { get; set; }
        public DbSet<Inquiry> Inquiries { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define PropertyId as the primary key for RealEstate
            modelBuilder.Entity<RealEstate>()
                .HasKey(r => r.PropertyId);

            // Define InquiryId as the primary key for Inquiry
            modelBuilder.Entity<Inquiry>()
                .HasKey(i => i.InquiryId);

            // Optionally, if you want to specify precision for Price in RealEstate
            modelBuilder.Entity<RealEstate>()
                .Property(r => r.Price)
                .HasColumnType("decimal(18,2)");  // Precision for the Price field
        }
    }
}
