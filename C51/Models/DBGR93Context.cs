using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace C51.Models
{
    public partial class DBGR93Context : DbContext
    {
        public DBGR93Context()
        {
        }

        public DBGR93Context(DbContextOptions<DBGR93Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Emekdashlar> Emekdashlars { get; set; } = null!;
        public virtual DbSet<Kitablar> Kitablars { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=WIN19SQL\\SQLEXPRESS;Database=DBGR93;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("ACCOUNT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("CONTACTS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_CODE")
                    .IsFixedLength();

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INSERT_USER");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Number)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("NUMBER")
                    .IsFixedLength();

                entity.Property(e => e.Prefix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PREFIX")
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Birthplace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRTHPLACE");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength();

                entity.Property(e => e.Identityno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYNO")
                    .IsFixedLength();

                entity.Property(e => e.Identitypincode).HasColumnName("IDENTITYPINCODE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");
            });

            modelBuilder.Entity<Emekdashlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EMEKDASHLAR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Kitablar>(entity =>
            {
                entity.ToTable("KITABLAR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KitabAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_AD");

                entity.Property(e => e.KitabCapev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_CAPEV");

                entity.Property(e => e.KitabQiymet)
                    .HasColumnType("money")
                    .HasColumnName("KITAB_QIYMET");

                entity.Property(e => e.KitabSehife).HasColumnName("KITAB_SEHIFE");

                entity.Property(e => e.KitabTarix)
                    .HasColumnType("date")
                    .HasColumnName("KITAB_TARIX");

                entity.Property(e => e.KitabYazar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_YAZAR");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.ToTable("PERSONAL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("BIRTH_DATE");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIRTH_PLACE");

                entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.MobileNo)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("MOBILE_NO");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_PERSONAL_DEPARTMENT");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.MadedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MADED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.ProductDate)
                    .HasColumnType("date")
                    .HasColumnName("PRODUCT_DATE");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("REGISTRATION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("STUDENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
