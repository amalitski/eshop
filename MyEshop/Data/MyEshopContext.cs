using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyEshop.Models;

namespace MyEshop.Data
{
    public class MyEshopContext : DbContext
    {
        public MyEshopContext(DbContextOptions<MyEshopContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryToProduct> CategoryToProducts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToProduct>()
                .HasKey(t => new { t.CategoryId, t.ProductId });

            modelBuilder.Entity<OrderDetail>()
              .Property(p => p.Price)
              .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Item>()
              .Property(p => p.Price)
              .HasColumnType("Money");

            base.OnModelCreating(modelBuilder);
        }
    }
}
