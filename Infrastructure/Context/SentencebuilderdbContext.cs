using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public partial class SentencebuilderdbContext : DbContext
{
    public SentencebuilderdbContext()
    {
    }

    public SentencebuilderdbContext(DbContextOptions<SentencebuilderdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sentence> Sentences { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    public virtual DbSet<WordType> WordTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=sentencebuilderdb;Username=dbuser;Password=dbuserpwd123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sentence>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sentence");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SentenceText)
                .HasColumnType("character varying")
                .HasColumnName("sentence_text");
        });

        modelBuilder.Entity<Word>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("word");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WordText)
                .HasColumnType("character varying")
                .HasColumnName("word_text");
            entity.Property(e => e.WordTypeId).HasColumnName("word_type_id");

            entity.HasOne(d => d.WordType).WithMany()
                .HasForeignKey(d => d.WordTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("word_fk");
        });

        modelBuilder.Entity<WordType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("id_pk");

            entity.ToTable("word_type");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
