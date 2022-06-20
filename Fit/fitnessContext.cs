using System;
using System.Collections.Generic;
using Fit.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fit
{
    public partial class fitnessContext : DbContext
    {
        public fitnessContext()
        {
        }

        public fitnessContext(DbContextOptions<fitnessContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coach> Coaches { get; set; } = null!;
        public virtual DbSet<Lesson> Lessons { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<PersonList> PersonLists { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<training> trainings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=fitness;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coach>(entity =>
            {
                entity.HasKey(e => e.IdCo);

                entity.ToTable("Coach");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.FristNam).HasMaxLength(50);

                entity.Property(e => e.LastNam).HasMaxLength(50);

                entity.Property(e => e.Patromym).HasMaxLength(50);

                entity.Property(e => e.Phones).HasMaxLength(50);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasKey(e => e.IdLessins);

                entity.Property(e => e.IdLessins).ValueGeneratedOnAdd();

                entity.Property(e => e.TrainingDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingType).HasMaxLength(50);

                entity.HasOne(d => d.IdLessinsNavigation)
                    .WithOne(p => p.Lesson)
                    .HasForeignKey<Lesson>(d => d.IdLessins)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lessons_Coach1");

                entity.HasOne(d => d.IdLessins1)
                    .WithOne(p => p.Lesson)
                    .HasForeignKey<Lesson>(d => d.IdLessins)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lessons_Person1");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.IdPer);

                entity.ToTable("Person");

                entity.Property(e => e.FristNames).HasMaxLength(50);

                entity.Property(e => e.LastNames).HasMaxLength(50);

                entity.Property(e => e.MedicalCart).HasMaxLength(50);

                entity.Property(e => e.Patronymics).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(11);

                entity.Property(e => e.TypeTraining).HasMaxLength(50);
            });

            modelBuilder.Entity<PersonList>(entity =>
            {
                entity.HasKey(e => e.IdList);

                entity.ToTable("PersonList");

                entity.Property(e => e.IdList).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdLessonsNavigation)
                    .WithMany(p => p.PersonLists)
                    .HasForeignKey(d => d.IdLessons)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonList_Lessons");

                entity.HasOne(d => d.IdListNavigation)
                    .WithOne(p => p.PersonList)
                    .HasForeignKey<PersonList>(d => d.IdList)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonList_Training1");

                entity.HasOne(d => d.IdList1)
                    .WithOne(p => p.PersonList)
                    .HasForeignKey<PersonList>(d => d.IdList)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonList_User1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.Property(e => e.FristName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Pass).HasMaxLength(50);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Post).HasMaxLength(50);
            });

            modelBuilder.Entity<training>(entity =>
            {
                entity.HasKey(e => e.IdTra);

                entity.ToTable("Training");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TrainingPlace).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
