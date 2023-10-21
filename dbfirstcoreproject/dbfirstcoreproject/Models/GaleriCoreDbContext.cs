using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dbfirstcoreproject.Models
{
    public partial class GaleriCoreDbContext : DbContext
    {
        public GaleriCoreDbContext()
        {
        }

        public GaleriCoreDbContext(DbContextOptions<GaleriCoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agalerisi> Agalerisis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5K7HMBT\\SQLEXPRESS;Database=GaleriCoreDb;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agalerisi>(entity =>
            {
                entity.HasKey(e => e.GaleriId);

                entity.ToTable("Agalerisi");

                entity.Property(e => e.GaleriId).HasColumnName("GaleriID");

                entity.Property(e => e.Ciro).HasColumnType("money");

                entity.Property(e => e.GaleriAd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resim).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
