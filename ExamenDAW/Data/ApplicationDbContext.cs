using ExamenDAW.Models.Asociativa;
using ExamenDAW.Models.Eveniment;
using ExamenDAW.Models.Organizator;
using ExamenDAW.Models.Participant;
using ExamenDAW.Models.Spectator;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
namespace ExamenDAW.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Eveniment> eveniments { get; set; }
        public DbSet<Participant> participants { get; set; }
        public DbSet<Asociativa> asociativas { get; set; }
        public DbSet<Organizator> organizations { get; set; }
        public DbSet<Spectator> spectators { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eveniment>()
                .HasIndex(e => e.Nume)
                .IsUnique();

            modelBuilder.Entity<Eveniment>()
                .HasOne(a => a.Asociativa)
                .WithMany(b => b.Eveniments)
                .HasForeignKey(a => a.AsociativaId);

            modelBuilder.Entity<Participant>()
                .HasOne(a => a.Asociativa)
                .WithMany(b => b.Participants)
                .HasForeignKey(a => a.AsociativaId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
