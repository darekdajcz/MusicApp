
using Microsoft.EntityFrameworkCore;

namespace MusicApp.Models
{
    public class MainContext: DbContext
    {
        public MainContext()
        {
        }

        public MainContext(DbContextOptions db): base(db)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<MusicLabel> MusicLabel { get; set; }
        public DbSet<Musican> Musican { get; set; }
        public DbSet<Musican_Track> Musican_Track { get; set; }
        public DbSet<Track> Track { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s21522;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musican_Track>().HasKey(x => new { x.IdTrack, x.IdMusican});
          /*  modelBuilder.Seed();*/
        }
    }
}
