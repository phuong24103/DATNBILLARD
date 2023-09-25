﻿using Datn_Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Data
{
    public class MyDbContext : DbContext
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
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
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
            optionsBuilder.UseSqlServer("Data Source=PHUONGDEPTRAI;Initial Catalog=DATN;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WishList>()
              .HasKey(p => new { p.CustomerId, p.ProductId });
            modelBuilder.Entity<Customer>()
            .HasOne(a => a.Cart)
            .WithOne(c => c.Customer)
            .HasForeignKey<Cart>(c => c.CustomerId);
        
             //modelBuilder.Seed();
        }
    }
}
