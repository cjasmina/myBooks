using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace myBooks.API.Database
{
    public partial class myBooksContext : DbContext
    {
        public myBooksContext()
        {
        }

        public myBooksContext(DbContextOptions<myBooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autori> Autori { get; set; }
        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<IzdavackeKuce> IzdavackeKuce { get; set; }
        public virtual DbSet<Jezici> Jezici { get; set; }
        public virtual DbSet<Knjige> Knjige { get; set; }
        public virtual DbSet<KnjigeAutori> KnjigeAutori { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Police> Police { get; set; }
        public virtual DbSet<Prijedlozi> Prijedlozi { get; set; }
        public virtual DbSet<PoliceKnjige> PoliceKnjige { get; set; }
        public virtual DbSet<Recenzije> Recenzije { get; set; }
        public virtual DbSet<Zanrovi> Zanrovi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autori>(entity =>
            {
                entity.HasKey(e => e.AutorId);

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Drzave>(entity =>
            {
                entity.HasKey(e => e.DrzavaId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Gradovi)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gradovi_Drzave");
            });

            modelBuilder.Entity<IzdavackeKuce>(entity =>
            {
                entity.HasKey(e => e.IzdavackaKucaId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.IzdavackeKuce)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IzdavackeKuce_Gradovi");
            });

            modelBuilder.Entity<Jezici>(entity =>
            {
                entity.HasKey(e => e.JezikId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Knjige>(entity =>
            {
                entity.HasKey(e => e.KnjigaId);

                entity.Property(e => e.DatumIzdavanja).HasColumnType("date");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("ISBN")
                    .HasMaxLength(30);

                entity.Property(e => e.KratakOpis)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NaslovnaFotografija).IsRequired();

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Opis).IsRequired();

                entity.HasOne(d => d.IzdavackaKuca)
                    .WithMany(p => p.Knjige)
                    .HasForeignKey(d => d.IzdavackaKucaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Knjige_IzdavackeKuce");

                entity.HasOne(d => d.Jezik)
                    .WithMany(p => p.Knjige)
                    .HasForeignKey(d => d.JezikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Knjige_Jezici");

                entity.HasOne(d => d.Zanr)
                    .WithMany(p => p.Knjige)
                    .HasForeignKey(d => d.ZanrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Knjige_Gradovi");
            });

            modelBuilder.Entity<KnjigeAutori>(entity =>
            {
                entity.HasKey(e => e.KnjigaAutorId);

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.KnjigeAutori)
                    .HasForeignKey(d => d.AutorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnjigeAutori_Autori");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.KnjigeAutori)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnjigeAutori_Knjige");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Knjige");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Korisnici");
            });

            modelBuilder.Entity<Police>(entity =>
            {
                entity.HasKey(e => e.PolicaId);

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CiljniBroj)
                    .IsRequired(false);

                entity.Property(e => e.KrajnjiDatumCilja).HasColumnType("date")
                    .IsRequired(false);

                entity.Property(e => e.Naziv)
                            .IsRequired()
                            .HasMaxLength(100);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Police)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Police_Korisnici");
            });

            modelBuilder.Entity<Prijedlozi>(entity =>
            {
                entity.HasKey(e => e.PrijedlogId);

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Autor)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Prijedlozi)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prijedlozi_Korisnici");
            });

            modelBuilder.Entity<PoliceKnjige>(entity =>
            {
                entity.HasKey(e => e.PolicaKnjigaId);

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.PoliceKnjige)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoliceKnjige_Knjige");

                entity.HasOne(d => d.Polica)
                    .WithMany(p => p.PoliceKnjige)
                    .HasForeignKey(d => d.PolicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoliceKnjige_Police");

                entity.Property(e => e.Procitano)
                    .IsRequired();
            });

            modelBuilder.Entity<Recenzije>(entity =>
            {
                entity.HasKey(e => e.RecenzijaId);

                entity.Property(e => e.DatumObjave).HasColumnType("date");

                entity.Property(e => e.Sadrzaj).IsRequired();

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.Recenzije)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recenzije_Knjige");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Recenzije)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recenzije_Korisnici");
            });

            modelBuilder.Entity<Zanrovi>(entity =>
            {
                entity.HasKey(e => e.ZanrId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}