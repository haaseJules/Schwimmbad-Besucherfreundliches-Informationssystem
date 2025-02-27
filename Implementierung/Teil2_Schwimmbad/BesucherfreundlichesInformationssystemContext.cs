using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Teil2_Schwimmbad
{
    public partial class BesucherfreundlichesInformationssystemContext : DbContext
    {
        public BesucherfreundlichesInformationssystemContext()
        {
        }

        public BesucherfreundlichesInformationssystemContext(DbContextOptions<BesucherfreundlichesInformationssystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Becken> Beckens { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Kurszeiten> Kurszeitens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=JULES-HAASE19\\SQLEXPRESS;Initial Catalog=BesucherfreundlichesInformationssystem;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Becken>(entity =>
            {
                entity.ToTable("Becken");

                entity.Property(e => e.BeckenId).HasColumnName("BeckenID");

                entity.Property(e => e.Details).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Kursleiter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kurszeiten>(entity =>
            {
                entity.HasKey(e => e.KursId)
                    .HasName("PK__Kurszeit__BCCFFF3BAF584A21");

                entity.ToTable("Kurszeiten");

                entity.Property(e => e.KursId).HasColumnName("KursID");

                entity.Property(e => e.Kursleiter)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Text).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
