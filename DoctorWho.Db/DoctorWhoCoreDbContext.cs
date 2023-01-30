using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ABUSAFAT;Initial Catalog=DoctorWhoCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>().HasKey(a => a.Id);
            modelBuilder.Entity<Author>().Property(a => a.Name).HasColumnType("varchar(20)");

            modelBuilder.Entity<Companion>().HasKey(c => c.Id);
            modelBuilder.Entity<Companion>().Property(a => a.Name).HasColumnType("varchar(20)");
            modelBuilder.Entity<Companion>().Property(a => a.WhoPlayed).HasColumnType("varchar(100)");

            modelBuilder.Entity<Doctor>().HasKey(d => d.Id);
            modelBuilder.Entity<Doctor>().Property(a => a.Name).HasColumnType("varchar(20)");

            modelBuilder.Entity<Enemy>().HasKey(e => e.Id);
            modelBuilder.Entity<Enemy>().Property(e => e.Name).HasColumnType("varchar(20)");
            modelBuilder.Entity<Enemy>().Property(e => e.Description).HasColumnType("varchar(200)");

            modelBuilder.Entity<Episode>().HasKey(e => e.Id);
            modelBuilder.Entity<Episode>().Property(e => e.Type).HasColumnType("varchar(100)");
            modelBuilder.Entity<Episode>().Property(e => e.Title).HasColumnType("varchar(100)");
            modelBuilder.Entity<Episode>().Property(e => e.Notes).HasColumnType("varchar(200)");

        }

        public DbSet<Author> authors { get; set; }
        public DbSet<Companion> companions { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Episode> episodes { get; set; }
        public DbSet<Enemy> enemys { get; set; }
        public DbSet<CompanionEpisode> episodeCompanions { get; set; }
        public DbSet<EnemyEpisode> episodeEnemies { get; set; }

    }
}
