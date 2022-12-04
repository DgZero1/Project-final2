using System;
using Microsoft.EntityFrameworkCore;

namespace Final
{
	public class  AppDbContext : DbContext
	{
		public AppDbContext (DbContextOptions<  AppDbContext> options)
			: base(options)
		{
		}
		public DbSet <Team> Teams {get; set;} = null!;
        public DbSet <Player> Players {get; set;} = null!;
	}
}
