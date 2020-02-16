using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class DogsBarberShopContext : DbContext
    {
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Queue> Queue { get; set; }
        public DogsBarberShopContext(DbContextOptions<DogsBarberShopContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                   .HasMaxLength(50)
                   .IsUnicode(false);

                entity.Property(e => e.Mobile)
                   .HasMaxLength(50)
                   .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }

}
