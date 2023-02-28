using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Proje.Models.Entities
{
    public partial class QRContext : DbContext
    {
        public QRContext()
        {
        }

        public QRContext(DbContextOptions<QRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategoriler> Kategorilers { get; set; } = null!;
        public virtual DbSet<Urunler> Urunlers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-4EDFQLT; uid=sa; password=1234; database=QR; trustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => e.KategoriId);

                entity.ToTable("KATEGORILER");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.KategoriAd)
                    .HasMaxLength(50)
                    .HasColumnName("kategori_ad");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("URUNLER");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.UrunAciklama)
                    .HasMaxLength(150)
                    .HasColumnName("urun_aciklama");

                entity.Property(e => e.UrunAdi)
                    .HasMaxLength(50)
                    .HasColumnName("urun_adi");

                entity.Property(e => e.UrunFiyati)
                    .HasMaxLength(50)
                    .HasColumnName("urun_fiyati");

                entity.Property(e => e.UrunKategoriId).HasColumnName("urun_kategori_id");

                entity.HasOne(d => d.UrunKategori)
                    .WithMany(p => p.Urunlers)
                    .HasForeignKey(d => d.UrunKategoriId)
                    .HasConstraintName("FK_URUNLER_KATEGORILER");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
