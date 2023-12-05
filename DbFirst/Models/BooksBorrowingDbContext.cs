using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirst.Models
{
    public partial class BooksBorrowingDbContext : DbContext
    {
        public BooksBorrowingDbContext()
        {
        }

        public BooksBorrowingDbContext(DbContextOptions<BooksBorrowingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookDetail> BookDetails { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=IN-FK1D5S3;Database=BooksBorrowingDb;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookDetail>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.ToTable("BookDetail");

                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.BookAvailability).HasColumnName("bookAvailability");

                entity.Property(e => e.BorrowedBy).HasColumnName("borrowedBy");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Gener).HasColumnName("gener");

                entity.Property(e => e.LendBy).HasColumnName("lendBy");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Rating).HasColumnName("rating");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserDetail");

                entity.Property(e => e.BooksBorrowed).HasColumnName("booksBorrowed");

                entity.Property(e => e.BooksLent).HasColumnName("booksLent");

                entity.Property(e => e.TokensAvailable).HasColumnName("tokensAvailable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
