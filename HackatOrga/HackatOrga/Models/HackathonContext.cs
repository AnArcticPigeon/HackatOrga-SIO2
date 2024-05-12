using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HackatOrga.Models
{
    public partial class HackathonContext : DbContext
    {
        public HackathonContext()
        {
        }

        public HackathonContext(DbContextOptions<HackathonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; } = null!;
        public virtual DbSet<Equipe> Equipes { get; set; } = null!;
        public virtual DbSet<Evenement> Evenements { get; set; } = null!;
        public virtual DbSet<Hackaton> Hackatons { get; set; } = null!;
        public virtual DbSet<Intervenant> Intervenants { get; set; } = null!;
        public virtual DbSet<MessengerMessage> MessengerMessages { get; set; } = null!;
        public virtual DbSet<Participant> Participants { get; set; } = null!;
        public virtual DbSet<Statistique> Statistiques { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;
        public virtual DbSet<UtilisateurEquipe> UtilisateurEquipes { get; set; } = null!;
        public virtual DbSet<UtilisateurHackatonFavori> UtilisateurHackatonFavoris { get; set; } = null!;
        public virtual DbSet<Ville> Villes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=192.168.49.1;port=3306;user=hackaweb;password=password;database=Hackathon;charset=utf8", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.6-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<MessengerMessage>(entity =>
            {
                entity.Property(e => e.AvailableAt).HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.CreatedAt).HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.DeliveredAt).HasComment("(DC2Type:datetime_immutable)");
            });

            modelBuilder.Entity<Statistique>(entity =>
            {
                entity.ToView("Statistiques");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.Property(e => e.Roles).HasComment("(DC2Type:json)");
            });

            modelBuilder.Entity<UtilisateurEquipe>(entity =>
            {
                entity.HasKey(e => new { e.UtilisateurId, e.EquipeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            modelBuilder.Entity<UtilisateurHackatonFavori>(entity =>
            {
                entity.HasKey(e => new { e.UtilisateurId, e.HackatonId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
