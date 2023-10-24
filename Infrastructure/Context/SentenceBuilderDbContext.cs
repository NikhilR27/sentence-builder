using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public partial class SentenceBuilderDbContext : DbContext
{
    public SentenceBuilderDbContext()
    {
    }

    public SentenceBuilderDbContext(DbContextOptions<SentenceBuilderDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sentence> Sentences { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    public virtual DbSet<WordType> WordTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sentence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Sentence_pk");

            entity.ToTable("Sentence");

            entity.Property(e => e.SentenceText)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Word>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Word_pk");

            entity.ToTable("Word");

            entity.Property(e => e.WordText)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.WordType).WithMany(p => p.Words)
                .HasForeignKey(d => d.WordTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Word_WordType_Id_fk");
        });

        modelBuilder.Entity<WordType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("WordType_pk");

            entity.ToTable("WordType");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
