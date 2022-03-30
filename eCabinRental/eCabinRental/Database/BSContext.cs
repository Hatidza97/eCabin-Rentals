using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eCabinRental
{
    public partial class BSContext : DbContext
    {
        public BSContext()
        {
        }

        public BSContext(DbContextOptions<BSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DetaljiRezervacije> DetaljiRezervacijes { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Klijent> Klijents { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<KorisnikUloge> KorisnikUloges { get; set; }
        public virtual DbSet<Objekat> Objekats { get; set; }
        public virtual DbSet<Ocjena> Ocjenas { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<TipObjektaSllike> TipObjektaSllikes { get; set; }
        public virtual DbSet<TipObjektum> TipObjekta { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BS; User=admin; Password=admin123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DetaljiRezervacije>(entity =>
            {
                entity.ToTable("DetaljiRezervacije");

                entity.Property(e => e.DetaljiRezervacijeId).HasColumnName("DetaljiRezervacijeID");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.ObjekatId).HasColumnName("ObjekatID");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.TipObjektaId).HasColumnName("TipObjektaID");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.DetaljiRezervacijes)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_klijenta");

                entity.HasOne(d => d.Objekat)
                    .WithMany(p => p.DetaljiRezervacijes)
                    .HasForeignKey(d => d.ObjekatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_objekatt");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.DetaljiRezervacijes)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rezervacija");
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.PostBroj).HasMaxLength(10);
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.ToTable("Klijent");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime).HasMaxLength(30);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(40);

                entity.Property(e => e.Prezime).HasMaxLength(40);

                entity.Property(e => e.Telefon).HasMaxLength(60);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Klijents)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grad");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).IsRequired();

                entity.Property(e => e.LozinkaSalt).IsRequired();

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<KorisnikUloge>(entity =>
            {
                entity.ToTable("KorisnikUloge");

                entity.Property(e => e.KorisnikUlogeId).HasColumnName("KorisnikUlogeID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUloges)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_korisnik");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUloges)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_uloga");
            });

            modelBuilder.Entity<Objekat>(entity =>
            {
                entity.ToTable("Objekat");

                entity.Property(e => e.ObjekatId).HasColumnName("ObjekatID");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Povrsina)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipObjektaId).HasColumnName("TipObjektaID");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Objekats)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_gradd");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Objekats)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_korisniKk");

                entity.HasOne(d => d.TipObjekta)
                    .WithMany(p => p.Objekats)
                    .HasForeignKey(d => d.TipObjektaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tipa");
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.ToTable("Ocjena");

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Komentar).HasMaxLength(100);

                entity.Property(e => e.ObjekatId).HasColumnName("ObjekatID");

                entity.Property(e => e.Ocjena1).HasColumnName("Ocjena");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjenas)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_klijent");

                entity.HasOne(d => d.Objekat)
                    .WithMany(p => p.Ocjenas)
                    .HasForeignKey(d => d.ObjekatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_objekat");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.ToTable("Rezervacija");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.DatumOdjave).HasColumnType("date");

                entity.Property(e => e.DatumPrijave).HasColumnType("date");
            });

            modelBuilder.Entity<TipObjektaSllike>(entity =>
            {
                entity.HasKey(e => e.TipObjektaSlikeId)
                    .HasName("PK__TipObjek__56FB740DBAA14113");

                entity.ToTable("TipObjektaSllike");

                entity.Property(e => e.TipObjektaSlikeId).HasColumnName("TipObjektaSlikeID");

                entity.Property(e => e.ObjekatId).HasColumnName("ObjekatID");

                entity.HasOne(d => d.Objekat)
                    .WithMany(p => p.TipObjektaSllikes)
                    .HasForeignKey(d => d.ObjekatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tipobjekta");
            });

            modelBuilder.Entity<TipObjektum>(entity =>
            {
                entity.HasKey(e => e.TipObjektaId)
                    .HasName("PK__TipObjek__B4E39314F94BA0CC");

                entity.Property(e => e.TipObjektaId).HasColumnName("TipObjektaID");

                entity.Property(e => e.Tip).HasMaxLength(50);
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OpisUloge)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
