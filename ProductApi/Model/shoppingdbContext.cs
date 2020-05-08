using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProductApi.model
{
    public partial class shoppingdbContext : DbContext
    {
       /* public shoppingdbContext()
        {
        }*/

        public shoppingdbContext(DbContextOptions<shoppingdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=shoppingdb;Integrated Security=True");
                optionsBuilder.UseSqlServer("Data Source=newshopping.database.windows.net;Initial Catalog=NewShoppingDb;User ID=shopadmin;Password=admin@123;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //optionsBuilder.UseSqlServer("Server=tcp:newshopping.database.windows.net,1433;Initial Catalog=NewShoppingDb;Persist Security Info=False;User ID=shopadmin;Password=admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Imgurl)
                    .HasColumnName("imgurl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Productdesciption)
                    .HasColumnName("productdesciption")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Productname)
                    .HasColumnName("productname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
