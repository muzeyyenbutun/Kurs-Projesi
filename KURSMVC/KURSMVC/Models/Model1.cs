namespace KURSMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ALT_KATEGORI> ALT_KATEGORI { get; set; }
        public virtual DbSet<EGITIM> EGITIM { get; set; }
        public virtual DbSet<GRUP> GRUP { get; set; }
        public virtual DbSet<GRUP_KAYIT> GRUP_KAYIT { get; set; }
        public virtual DbSet<K_DURUMU> K_DURUMU { get; set; }
        public virtual DbSet<KATEGORI> KATEGORI { get; set; }
        public virtual DbSet<KULLANICI> KULLANICI { get; set; }
        public virtual DbSet<KURSIYER> KURSIYER { get; set; }
        public virtual DbSet<OGRENIM> OGRENIM { get; set; }
        public virtual DbSet<OK_DURUMU> OK_DURUMU { get; set; }
        public virtual DbSet<ONKAYIT> ONKAYIT { get; set; }
        public virtual DbSet<SAYFA> SAYFA { get; set; }
        public virtual DbSet<SLIDER> SLIDER { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TAKSIT> TAKSIT { get; set; }
        public virtual DbSet<TAKVIM> TAKVIM { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALT_KATEGORI>()
                .Property(e => e.ALT_KATEGORI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<EGITIM>()
                .Property(e => e.EGITIM_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<EGITIM>()
                .Property(e => e.ICERIK)
                .IsUnicode(false);

            modelBuilder.Entity<EGITIM>()
                .Property(e => e.OZET)
                .IsUnicode(false);

            modelBuilder.Entity<EGITIM>()
                .HasMany(e => e.GRUP)
                .WithRequired(e => e.EGITIM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRUP>()
                .Property(e => e.GUNLER)
                .IsUnicode(false);

            modelBuilder.Entity<GRUP>()
                .HasMany(e => e.GRUP_KAYIT)
                .WithRequired(e => e.GRUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRUP>()
                .HasMany(e => e.ONKAYIT)
                .WithRequired(e => e.GRUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRUP_KAYIT>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<GRUP_KAYIT>()
                .HasMany(e => e.TAKSIT)
                .WithRequired(e => e.GRUP_KAYIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<K_DURUMU>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<KATEGORI>()
                .Property(e => e.KATEGORI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<KATEGORI>()
                .HasMany(e => e.EGITIM)
                .WithRequired(e => e.KATEGORI)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<KATEGORI>()
               .HasMany(e => e.ALT_KATEGORIs)
               .WithRequired(e => e.KATEGORI)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<KULLANICI>()
                .Property(e => e.KULLANICI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<KULLANICI>()
                .Property(e => e.SIFRESI)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .Property(e => e.ADI)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .Property(e => e.SOYADI)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .Property(e => e.CINSIYET)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .Property(e => e.ADRES)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<KURSIYER>()
                .HasMany(e => e.GRUP_KAYIT)
                .WithRequired(e => e.KURSIYER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OGRENIM>()
                .Property(e => e.OGRENIM_ADI)
                .IsUnicode(false);
            modelBuilder.Entity<OGRENIM>()
               .HasMany(e => e.KURSIYERs)
               .WithRequired(e => e.OGRENIM)
               .WillCascadeOnDelete(false);
            modelBuilder.Entity<KATEGORI>()
              .HasMany(e => e.ALT_KATEGORIs)
              .WithRequired(e => e.KATEGORI)
              .WillCascadeOnDelete(false);
            modelBuilder.Entity<OK_DURUMU>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<ONKAYIT>()
                .Property(e => e.ADI_SOYADI)
                .IsUnicode(false);

            modelBuilder.Entity<ONKAYIT>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<ONKAYIT>()
                .Property(e => e.EPOSTA)
                .IsUnicode(false);

            modelBuilder.Entity<ONKAYIT>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<SAYFA>()
                .Property(e => e.ADI)
                .IsUnicode(false);

            modelBuilder.Entity<SAYFA>()
                .Property(e => e.ICERIK)
                .IsUnicode(false);

            modelBuilder.Entity<SLIDER>()
                .Property(e => e.BASLIK)
                .IsUnicode(false);

            modelBuilder.Entity<SLIDER>()
                .Property(e => e.LINK)
                .IsUnicode(false);

            modelBuilder.Entity<SLIDER>()
                .Property(e => e.RESIM)
                .IsUnicode(false);

            modelBuilder.Entity<TAKSIT>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<TAKVIM>()
                .Property(e => e.BASLIK)
                .IsUnicode(false);
        }
    }
}
