using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backendapi.Models;

public partial class LibrarysContext : DbContext
{
    public LibrarysContext()
    {
    }

    public LibrarysContext(DbContextOptions<LibrarysContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASTLPTWFH151\\SQLEXPRESS;Initial Catalog=Librarys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BookId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Book_ID");
            entity.Property(e => e.BookName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Book_Name");
            entity.Property(e => e.Descriptions)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PiblishedDate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Piblished_Date");
            entity.Property(e => e.Price)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UrlLink).HasColumnName("url_Link");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
