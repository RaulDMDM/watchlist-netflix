using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetflixWatchlist_be.Entities
{
    public partial class netflix_watchlistContext : DbContext
    {
        public netflix_watchlistContext(DbContextOptions<netflix_watchlistContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Content> Contents { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Watchlist> Watchlists { get; set; } = null!;
        public virtual DbSet<WatchlistContent> WatchlistContents { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("content");

                entity.Property(e => e.ContentId).HasColumnName("content_id");

                entity.Property(e => e.ContentDescription)
                    .HasMaxLength(500)
                    .HasColumnName("content_description");

                entity.Property(e => e.ContentName)
                    .HasMaxLength(225)
                    .HasColumnName("content_name");

                entity.Property(e => e.Director)
                    .HasMaxLength(225)
                    .HasColumnName("director");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(225)
                    .HasColumnName("image_url");

                entity.Property(e => e.Type)
                    .HasMaxLength(225)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.Property(e => e.UserName)
                    .HasMaxLength(225)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(225)
                    .HasColumnName("user_password");
            });

            modelBuilder.Entity<Watchlist>(entity =>
            {
                entity.HasKey(e => e.ListName)
                    .HasName("PRIMARY");

                entity.ToTable("watchlists");

                entity.HasIndex(e => e.UserNameFk, "user_name_FK");

                entity.Property(e => e.ListName)
                    .HasMaxLength(225)
                    .HasColumnName("list_name");

                entity.Property(e => e.UserNameFk)
                    .HasMaxLength(225)
                    .HasColumnName("user_name_FK");

            });

            modelBuilder.Entity<WatchlistContent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("watchlist_content");

                entity.HasIndex(e => e.ContentIdFk, "content_id_FK");

                entity.HasIndex(e => e.ListNameFk, "list_name_FK");

                entity.Property(e => e.ContentIdFk).HasColumnName("content_id_FK");

                entity.Property(e => e.ListNameFk)
                    .HasMaxLength(225)
                    .HasColumnName("list_name_FK");

                entity.HasOne(d => d.ContentIdFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ContentIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("watchlist_content_ibfk_2");

                entity.HasOne(d => d.ListNameFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ListNameFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("watchlist_content_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
