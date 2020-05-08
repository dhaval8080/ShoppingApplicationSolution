using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrderApi.Model
{
    public partial class shoppingdbContext : DbContext
    {
    /*    public shoppingdbContext()
        {
        }*/

        public shoppingdbContext(DbContextOptions<shoppingdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=shoppingdb;Integrated Security=True");
                //optionsBuilder.UseSqlServer("Server=tcp:newshopping.database.windows.net,1433;Initial Catalog=NewShoppingDb;Persist Security Info=False;User ID=shopadmin;Password=admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
                optionsBuilder.UseSqlServer("Data Source=newshopping.database.windows.net;Initial Catalog=NewShoppingDb;User ID=shopadmin;Password=admin@123;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasColumnName("adress")
                    .HasMaxLength(256);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(256);

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.Ordertime)
                    .HasColumnName("ordertime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Paymentid).HasColumnName("paymentid");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Totalcost)
                    .HasColumnName("totalcost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(450);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
