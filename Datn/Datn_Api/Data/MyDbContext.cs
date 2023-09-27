using Datn_Api.Extensions;
using Datn_Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Data
{
    public class MyDbContext : IdentityDbContext<User, Role, Guid>
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<BillStatus> BillStatuses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDetail> CategoriesDetail { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Gripe> Gripes { get; set; }
        public DbSet<Handle> Handles { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Ren> Rens { get; set; }
        public DbSet <Role> Roles { get; set; }
        public DbSet<Top> Tops { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<WishList> WishLists { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DATN;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
            .HasOne(a => a.UsedVoucher)
            .WithOne(c => c.Bill)
            .HasForeignKey<UsedVoucher>(c => c.BillId);
            modelBuilder.Entity<User>()
            .HasOne(a => a.Cart)
            .WithOne(c => c.User)
            .HasForeignKey<Cart>(c => c.UserId);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
