using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudEng.Models
{
    public partial class Study_EnglishContext : DbContext
    {
        public Study_EnglishContext()
        {
        }

        public Study_EnglishContext(DbContextOptions<Study_EnglishContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Companyy> Companyys { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Modulle> Modulles { get; set; } = null!;
        public virtual DbSet<Pupil> Pupils { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Companyy>(entity =>
            {
                entity.HasKey(e => e.IdCompanyy);

                entity.ToTable("Companyy");

                entity.Property(e => e.IdCompanyy).HasColumnName("ID_Companyy");

                entity.Property(e => e.NameCompanyy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Name_Companyy");

                entity.Property(e => e.RatingCompanyy)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Rating_Companyy");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.IdCourses);

                entity.Property(e => e.IdCourses).HasColumnName("ID_Courses");

                entity.Property(e => e.Advanced).IsUnicode(false);

                entity.Property(e => e.Elementary).IsUnicode(false);

                entity.Property(e => e.Intermediate).IsUnicode(false);

                entity.Property(e => e.PreIntermediate)
                    .IsUnicode(false)
                    .HasColumnName("Pre-Intermediate");

                entity.Property(e => e.SaleId).HasColumnName("Sale_ID");

               
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.ToTable("Employee");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.FirstNameEmployee)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("First_Name_Employee");

                entity.Property(e => e.LoginEmployee)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Login_Employee");

                entity.Property(e => e.MiddleNameEmployee)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Middle_Name_Employee")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ModulleId).HasColumnName("Modulle_ID");

                entity.Property(e => e.PasswrodEmployee)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Passwrod_Employee");

                entity.Property(e => e.SecondNameEmployee)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Second_Name_Employee");

            });

            modelBuilder.Entity<Modulle>(entity =>
            {
                entity.HasKey(e => e.IdModulle);

                entity.ToTable("Modulle");

                entity.Property(e => e.IdModulle).HasColumnName("ID_Modulle");

                entity.Property(e => e.CompanyyId).HasColumnName("Companyy_ID");

                entity.Property(e => e.Listening).IsUnicode(false);

                entity.Property(e => e.Reading).IsUnicode(false);

                entity.Property(e => e.SaleId).HasColumnName("Sale_ID");

                entity.Property(e => e.Speaking).IsUnicode(false);

                entity.Property(e => e.Writing).IsUnicode(false);

               
            });

            modelBuilder.Entity<Pupil>(entity =>
            {
                entity.HasKey(e => e.IdPupil);

                entity.ToTable("Pupil");

                entity.Property(e => e.IdPupil).HasColumnName("ID_Pupil");

                entity.Property(e => e.FirstNamePupil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("First_Name_Pupil");

                entity.Property(e => e.LoginPupil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Login_Pupil");

                entity.Property(e => e.MiddleNamePupil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Middle_Name_Pupil")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ModulleId).HasColumnName("Modulle_ID");

                entity.Property(e => e.PasswrodPupil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Passwrod_Pupil");

                entity.Property(e => e.SecondNamePupil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Second_Name_Pupil");

             
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.IdSale);

                entity.ToTable("Sale");

                entity.Property(e => e.IdSale).HasColumnName("ID_Sale");

                entity.Property(e => e.NameSale)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Name_Sale");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.IdTeacher);

                entity.ToTable("Teacher");

                entity.Property(e => e.IdTeacher).HasColumnName("ID_Teacher");

                entity.Property(e => e.FirstNameTeacher)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("First_Name_Teacher");

                entity.Property(e => e.Level)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleNameTeacher)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Middle_Name_Teacher")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ModulleId).HasColumnName("Modulle_ID");

                entity.Property(e => e.SecondNameTeacher)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Second_Name_Teacher");

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_Userr");

                entity.ToTable("User");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.Login)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
