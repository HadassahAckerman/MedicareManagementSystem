using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MedicareManagementSystem.DAL.Models
{
    public partial class MedicareManagementSystemContext : DbContext
    {
        public MedicareManagementSystemContext()
        {
        }

        public MedicareManagementSystemContext(DbContextOptions<MedicareManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Covid19InfoPerPerson> Covid19InfoPerPerson { get; set; }
        public virtual DbSet<PersonalData> PersonalData { get; set; }
        public virtual DbSet<VaccinesPerPerson> VaccinesPerPerson { get; set; }
        public virtual DbSet<VaccinesTypes> VaccinesTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server= DESKTOP-7C8OOMV;Database= MedicareManagementSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Covid19InfoPerPerson>(entity =>
            {
                entity.HasKey(e => e.Covid19PersonalCode);

                entity.Property(e => e.Covid19PersonalCode).HasMaxLength(50);

                entity.Property(e => e.IsPositiveToCovidDate).HasColumnType("datetime");

                entity.Property(e => e.PersonId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RecoveryDate).HasColumnType("datetime");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Covid19InfoPerPerson)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Covid19InfoPerPerson_PersonalData");
            });

            modelBuilder.Entity<PersonalData>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.CellPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HouseNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VaccinesPerPerson>(entity =>
            {
                entity.HasKey(e => e.VaccineNumber);

                entity.Property(e => e.VaccineNumber).HasMaxLength(50);

                entity.Property(e => e.Covid19Id)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VaccineDate).HasColumnType("datetime");

                entity.HasOne(d => d.Covid19)
                    .WithMany(p => p.VaccinesPerPerson)
                    .HasForeignKey(d => d.Covid19Id)
                    .HasConstraintName("FK_VaccinesPerPerson_Covid19InfoPerPerson");

                entity.HasOne(d => d.VaccineTypeNavigation)
                    .WithMany(p => p.VaccinesPerPerson)
                    .HasForeignKey(d => d.VaccineType)
                    .HasConstraintName("FK_VaccinesPerPerson_VaccinesTypes");
            });

            modelBuilder.Entity<VaccinesTypes>(entity =>
            {
                entity.HasKey(e => e.Type);

                entity.Property(e => e.Type).ValueGeneratedNever();

                entity.Property(e => e.VaccineManufacturer)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
