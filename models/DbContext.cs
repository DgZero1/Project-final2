using System;
using Microsoft.EntityFrameworkCore;

namespace Final
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = database.db");
        }

        
        public DbSet <Team> Teams {get; set;} = null!;
        public DbSet <Player> Players {get; set;} = null!;
       
    }
}