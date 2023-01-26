using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Proje.Models.Entities
{
    public partial class ProjeContext : DbContext
    {
        public ProjeContext()
        {
        }

        public ProjeContext(DbContextOptions<ProjeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; } = null!;
        public virtual DbSet<BookTable> BookTables { get; set; } = null!;
        public virtual DbSet<Chef> Chefs { get; set; } = null!;
        public virtual DbSet<ContactForm> ContactForms { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Footer> Footers { get; set; } = null!;
        public virtual DbSet<Gallery> Galleries { get; set; } = null!;
        public virtual DbSet<Kategori> Kategoris { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Slider> Sliders { get; set; } = null!;
        public virtual DbSet<Special> Specials { get; set; } = null!;
        public virtual DbSet<SpecialsNav> SpecialsNavs { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;
        public virtual DbSet<Title> Titles { get; set; } = null!;
        public virtual DbSet<Topbar> Topbars { get; set; } = null!;
        public virtual DbSet<Urun> Uruns { get; set; } = null!;
        public virtual DbSet<WhyU> WhyUs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-4EDFQLT; uid=sa; password=1234; database=Proje; trustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>(entity =>
            {
                entity.ToTable("About");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama1)
                    .HasMaxLength(300)
                    .HasColumnName("aciklama1");

                entity.Property(e => e.Aciklama2)
                    .HasMaxLength(300)
                    .HasColumnName("aciklama2");

                entity.Property(e => e.Aciklama3)
                    .HasMaxLength(300)
                    .HasColumnName("aciklama3");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(100)
                    .HasColumnName("baslik");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Madde1)
                    .HasMaxLength(150)
                    .HasColumnName("madde1");

                entity.Property(e => e.Madde2)
                    .HasMaxLength(150)
                    .HasColumnName("madde2");

                entity.Property(e => e.Madde3)
                    .HasMaxLength(150)
                    .HasColumnName("madde3");

                entity.Property(e => e.YoutubeLink)
                    .HasMaxLength(150)
                    .HasColumnName("youtube_link");
            });

            modelBuilder.Entity<BookTable>(entity =>
            {
                entity.ToTable("BookTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(300)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Datetime)
                    .HasMaxLength(50)
                    .HasColumnName("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Person).HasColumnName("person");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Chef>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Facebook)
                    .HasMaxLength(50)
                    .HasColumnName("facebook");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Instagram)
                    .HasMaxLength(50)
                    .HasColumnName("instagram");

                entity.Property(e => e.Linkedin)
                    .HasMaxLength(50)
                    .HasColumnName("linkedin");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.Twitter)
                    .HasMaxLength(50)
                    .HasColumnName("twitter");
            });

            modelBuilder.Entity<ContactForm>(entity =>
            {
                entity.ToTable("Contact_form");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Konu)
                    .HasMaxLength(100)
                    .HasColumnName("konu");

                entity.Property(e => e.Mesaj)
                    .HasMaxLength(300)
                    .HasColumnName("mesaj");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama1)
                    .HasMaxLength(200)
                    .HasColumnName("aciklama1");

                entity.Property(e => e.Aciklama2)
                    .HasMaxLength(200)
                    .HasColumnName("aciklama2");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(50)
                    .HasColumnName("baslik");

                entity.Property(e => e.Fiyat)
                    .HasMaxLength(50)
                    .HasColumnName("fiyat");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Madde1)
                    .HasMaxLength(100)
                    .HasColumnName("madde1");

                entity.Property(e => e.Madde2)
                    .HasMaxLength(100)
                    .HasColumnName("madde2");

                entity.Property(e => e.Madde3)
                    .HasMaxLength(100)
                    .HasColumnName("madde3");
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.ToTable("Footer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(150)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(50)
                    .HasColumnName("baslik");

                entity.Property(e => e.Icon1)
                    .HasMaxLength(50)
                    .HasColumnName("icon1");

                entity.Property(e => e.Icon1Link)
                    .HasMaxLength(50)
                    .HasColumnName("icon1_link");

                entity.Property(e => e.Icon2)
                    .HasMaxLength(50)
                    .HasColumnName("icon2");

                entity.Property(e => e.Icon2Link)
                    .HasMaxLength(50)
                    .HasColumnName("icon2_link");

                entity.Property(e => e.Icon3)
                    .HasMaxLength(50)
                    .HasColumnName("icon3");

                entity.Property(e => e.Icon3Link)
                    .HasMaxLength(50)
                    .HasColumnName("icon3_link");

                entity.Property(e => e.Icon4)
                    .HasMaxLength(50)
                    .HasColumnName("icon4");

                entity.Property(e => e.Icon4Link)
                    .HasMaxLength(50)
                    .HasColumnName("icon4_link");

                entity.Property(e => e.Icon5)
                    .HasMaxLength(50)
                    .HasColumnName("icon5");

                entity.Property(e => e.Icon5Link)
                    .HasMaxLength(50)
                    .HasColumnName("icon5_link");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.ToTable("Gallery");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");
            });

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.ToTable("Kategori");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KategoriAdi).HasMaxLength(50);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.ToTable("Slider");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(300)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(50)
                    .HasColumnName("baslik");

                entity.Property(e => e.Hidden)
                    .HasMaxLength(50)
                    .HasColumnName("hidden");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");
            });

            modelBuilder.Entity<Special>(entity =>
            {
                entity.HasIndex(e => e.SpecialsNavId, "IX_Specials_Specials_nav_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama1)
                    .HasMaxLength(200)
                    .HasColumnName("aciklama1");

                entity.Property(e => e.Aciklama2)
                    .HasMaxLength(300)
                    .HasColumnName("aciklama2");

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .HasColumnName("active");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(50)
                    .HasColumnName("baslik");

                entity.Property(e => e.Href)
                    .HasMaxLength(50)
                    .HasColumnName("href");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.SpecialsNavId).HasColumnName("Specials_nav_id");

                entity.HasOne(d => d.SpecialsNav)
                    .WithMany(p => p.Specials)
                    .HasForeignKey(d => d.SpecialsNavId)
                    .HasConstraintName("FK_Specials_Specials_nav");
            });

            modelBuilder.Entity<SpecialsNav>(entity =>
            {
                entity.ToTable("Specials_nav");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasMaxLength(50)
                    .HasColumnName("active");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(50)
                    .HasColumnName("baslik");

                entity.Property(e => e.Href)
                    .HasMaxLength(50)
                    .HasColumnName("href");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .HasColumnName("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChefsAciklama)
                    .HasMaxLength(200)
                    .HasColumnName("Chefs_aciklama");

                entity.Property(e => e.ChefsBaslik)
                    .HasMaxLength(100)
                    .HasColumnName("Chefs_baslik");

                entity.Property(e => e.ContactAciklama)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_aciklama");

                entity.Property(e => e.ContactBaslik)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_baslik");

                entity.Property(e => e.EventsBaslik)
                    .HasMaxLength(100)
                    .HasColumnName("Events_baslik");

                entity.Property(e => e.GalleryAciklama)
                    .HasMaxLength(200)
                    .HasColumnName("Gallery_aciklama");

                entity.Property(e => e.GalleryBaslik)
                    .HasMaxLength(100)
                    .HasColumnName("Gallery_baslik");

                entity.Property(e => e.SpecialsAciklama)
                    .HasMaxLength(200)
                    .HasColumnName("Specials_aciklama");

                entity.Property(e => e.SpecialsBaslik)
                    .HasMaxLength(100)
                    .HasColumnName("Specials_baslik");

                entity.Property(e => e.WhyUsAciklama)
                    .HasMaxLength(200)
                    .HasColumnName("WhyUs_aciklama");

                entity.Property(e => e.WhyUsBaslik)
                    .HasMaxLength(100)
                    .HasColumnName("WhyUs_baslik");
            });

            modelBuilder.Entity<Topbar>(entity =>
            {
                entity.ToTable("Topbar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adres)
                    .HasMaxLength(200)
                    .HasColumnName("adres");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .HasColumnName("email");

                entity.Property(e => e.Saat)
                    .HasMaxLength(100)
                    .HasColumnName("saat");

                entity.Property(e => e.Telefon)
                    .HasMaxLength(50)
                    .HasColumnName("telefon");
            });

            modelBuilder.Entity<Urun>(entity =>
            {
                entity.ToTable("Urun");

                entity.HasIndex(e => e.UrunKategoriId, "IX_Urun_Urun_Kategori_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UrunAciklama).HasMaxLength(150);

                entity.Property(e => e.UrunAdi).HasMaxLength(50);

                entity.Property(e => e.UrunFiyat).HasMaxLength(50);

                entity.Property(e => e.UrunKategoriId).HasColumnName("Urun_Kategori_id");

                entity.HasOne(d => d.UrunKategori)
                    .WithMany(p => p.Uruns)
                    .HasForeignKey(d => d.UrunKategoriId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Urun_Kategori");
            });

            modelBuilder.Entity<WhyU>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(200)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(50)
                    .HasColumnName("baslik");

                entity.Property(e => e.Sayi)
                    .HasMaxLength(50)
                    .HasColumnName("sayi");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
