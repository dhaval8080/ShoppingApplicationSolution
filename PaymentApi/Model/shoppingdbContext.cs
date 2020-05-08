using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PaymentApi.Model
{
    public partial class shoppingdbContext : DbContext
    {
      /*  public shoppingdbContext()
        {
        }
*/
        public shoppingdbContext(DbContextOptions<shoppingdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Payment> Payment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=shoppingdb;Integrated Security=True");
                //optionsBuilder.UseSqlServer("Server=tcp:newshopping.database.windows.net,1433;Initial Catalog=NewShoppingDb;Persist Security Info=False;User ID=shopadmin;Password=admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                optionsBuilder.UseSqlServer("Data Source=newshopping.database.windows.net;Initial Catalog=NewShoppingDb;User ID=shopadmin;Password=admin@123;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Creditnumber)
                    .HasColumnName("creditnumber")
                    .HasMaxLength(450);

                entity.Property(e => e.Paymentstatus).HasColumnName("paymentstatus");

                entity.Property(e => e.Paymenttime)
                    .HasColumnName("paymenttime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
