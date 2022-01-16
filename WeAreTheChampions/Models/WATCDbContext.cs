using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class WATCDbContext : DbContext
    {
        public WATCDbContext() : base("name=WATCConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .HasRequired(m => m.Team1)
                .WithMany(t => t.Team1Matches)
                .HasForeignKey(m => m.Team1Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Match>()
                .HasRequired(m => m.Team2)
                .WithMany(t => t.Team2Matches)
                .HasForeignKey(m => m.Team2Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Match>()
                .Property(m => m.Score1).IsOptional();

            modelBuilder.Entity<Match>()
                .Property(m => m.Score2).IsOptional();
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
