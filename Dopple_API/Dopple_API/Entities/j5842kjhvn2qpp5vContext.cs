using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dopple_API.Entities
{
    public partial class j5842kjhvn2qpp5vContext : DbContext
    {
        public j5842kjhvn2qpp5vContext()
        {
        }

        public j5842kjhvn2qpp5vContext(DbContextOptions<j5842kjhvn2qpp5vContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=ebh2y8tqym512wqs.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;port=3306;user=bdi7b88w4a9pia2d;password=m1ejb1ex8snhl34k;database=j5842kjhvn2qpp5v");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(10)
                    .HasColumnName("OrderID");

                entity.Property(e => e.StatusOrder).HasColumnType("enum('PENDING','PROCESSING','COMPLETE')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
